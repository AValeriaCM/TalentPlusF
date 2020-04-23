using Npgsql;
using NpgsqlTypes;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;

public partial class View_Login : System.Web.UI.Page
{
    String idUser;
    String user;
    String pass;
    String nombre;
    String apellido;
    String correo;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Login_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        EDatos usuario = new EDatos();
        usuario.Username = tb_username.Text;
        usuario.Password = tb_password.Text;

        usuario = new DaoUsuario().login(usuario);

        if (usuario == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ('Usuario o Contraseña incorrecta' );</script>");
            return;
        }
        else
        {
            Session["valida"] = usuario;
            Session["username"] = usuario.Username;
            Response.Redirect("InicioUsuario.aspx");
        }

    }
}