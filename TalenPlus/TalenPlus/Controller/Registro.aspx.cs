using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btn_Registrar_Click(object sender, EventArgs e)
    {

        ClientScriptManager cm = this.ClientScript;
        EDatos verificar = new EDatos();
        verificar.Correo = tb_email.Text;
        verificar.Username = tb_username.Text;

        verificar = new DaoUsuario().verificarCorreo(verificar);

        if(verificar == null)
        {
            EDatos usuario = new EDatos();
            usuario.Nombre = tb_nombre.Text;
            usuario.Apellido = tb_apellido.Text;
            usuario.Correo = tb_email.Text;
            usuario.Username = tb_username.Text;
            usuario.Password = tb_password.Text;

            new DaoUsuario().InsertarUsuario(usuario);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'El usuario se ha registrado satisfactoriamente' );</script>");
            return;
        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ( 'el correo o usuario ya se encuentran registrados' );</script>");
            return;

        }

       
    }
}