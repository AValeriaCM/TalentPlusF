using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Usuario : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();

        if (Session["valida"] != null)
        {
          
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }



    //protected void onClickCerrarSesion(object sender, EventArgs e)
    //{
    //    Mapeo mapeo = new Mapeo();
    //    mapeo.Database.Connection.Close();
    //    //Response.Redirect("Inicio.aspx");
    //}


    protected void btn_CerrarSesion_Click(object sender, EventArgs e)
    {
        Session["valida"] = null;
    }
}
