using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_InicioUsuario : System.Web.UI.Page
{
    String nombre;
    String extension;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["valida"] != null)
        {
           
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        lb_username.Text = ((EDatos)Session["valida"]).Username;
        
    }

    protected void btn_Subir_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        String archivo = "~\\Videos\\" + System.IO.Path.GetFileName(fu_video.PostedFile.FileName);
        fu_video.PostedFile.SaveAs(Server.MapPath(archivo));
        nombre = fu_video.FileName;
        extension = archivo;
        //System.IO.Path.GetExtension(fu_video.PostedFile.FileName);
        EVideo video = new EVideo();
        video.Id_usuario = ((EDatos)Session["valida"]).Id;
        video.Nombre = nombre;
        video.Url = extension;

        DaoUsuario dao = new DaoUsuario();
        dao.insertarVideo(video);

        if (video != null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert ('Video registrado satisfactoriamente' );</script>");
            return;
        }

    }
}