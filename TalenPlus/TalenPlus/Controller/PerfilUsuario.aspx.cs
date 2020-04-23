using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_PerfilUsuario : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {

        //valido session existente - sino logueo enviar al login para evitar salto de URL
        if (Session["valida"] != null)
        {
            EDatos usuario = this.userSession();
            lb_nombre.Text = usuario.Nombre;
            lb_apellido.Text = usuario.Apellido;
            lb_email.Text = usuario.Correo;
            lb_username.Text = usuario.Username;
            lb_contrasela.Text = usuario.Password;
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }

    public EDatos userSession()
    {
        String user = Session["username"].ToString();
        EDatos usuario = new DaoUsuario().usuarioSesion(user);
        return usuario;
    }

    protected void btn_Modificar_Click(object sender, EventArgs e)
    {
        EDatos usuario = this.userSession();
        tb_Nnombre.Visible = true;
        tb_Napellido.Visible = true;
        tb_Nusername.Visible = true;
        tb_Npass.Visible = true;

        tb_Nnombre.Text = usuario.Nombre;
        tb_Napellido.Text = usuario.Apellido;
        tb_Nusername.Text = usuario.Username;
        tb_Npass.Text = usuario.Password;

        btn_Guardar.Visible = true;
        btn_Modificar.Visible = false;

    }

    protected void btn_Guardar_Click(object sender, EventArgs e)
    {
        EDatos usuario = new EDatos();
        usuario.Nombre = tb_Nnombre.Text;
        usuario.Apellido = tb_Napellido.Text;
        usuario.Correo = lb_email.Text;
        usuario.Username = tb_Nusername.Text;
        usuario.Password = tb_Npass.Text;
        usuario.Id = id;

        DaoUsuario dao = new DaoUsuario();
        dao.actualizarDatos(usuario);

        Response.Redirect("PerfilUsuario.aspx");
    }

    protected void btn_Eliminar_Click(object sender, EventArgs e)
    {

        lb_nombre.Visible = false;
        lb_apellido.Visible = false;
        lb_email.Visible = false;
        lb_username.Visible = false;
        lb_contrasela.Visible = false;
        btn_Eliminar.Visible = false;
        tb_Dusername.Visible = true;
        btn_Confirmar.Visible = true;


    }

    protected void btn_Confirmar_Click(object sender, EventArgs e)
    {

        string nombre = tb_Dusername.Text;

        DaoUsuario dao = new DaoUsuario();
        bool response = dao.eliminarUsuario(nombre);

        if (response == true)
        {
            Response.Redirect("Inicio.aspx");
        }
        else
        {
            ClientScriptManager cm = this.ClientScript;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ('El usuario no existe' );</script>");
            return;
        }

    }

    protected void onClickCerrarSesion(object sender, EventArgs e)
    {
        //EDatos usuario = this.userSession();
        Session["valida"] = null;
    }
}