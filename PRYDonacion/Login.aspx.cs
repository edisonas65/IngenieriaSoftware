using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace PRYDonacion
{
    public partial class Loguin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (ManejadoraUsuario.Autenticar(Login1.UserName, Login1.Password) == true)
            {
                DataTable tblUsuario = ManejadoraUsuario.ConsultarUsuario(Login1.UserName, Login1.Password);


                Session["id_rol"] = tblUsuario.Rows[0]["id_rol"].ToString();
                Session["ced_usuario"] = tblUsuario.Rows[0]["ced_usuario"].ToString();
             
                Response.Redirect("~/Inicio.aspx");

            }
        }
    }
}