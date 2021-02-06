using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace PRYDonacion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////
        //  Registrar un usuario
        /// //////////////////////////////////////////////

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnRegistrar_Click1(object sender, EventArgs e)
        {
            try
            {
                BeanUsuario objBeanUsuario = new BeanUsuario();
                objBeanUsuario.CedulaUsuario = txtCedula.Text;
                objBeanUsuario.NombresUsuario = txtNombres.Text;
                objBeanUsuario.ApellidosUsuario = txtApellidos.Text;
                objBeanUsuario.CorreoUsuario = txtCorreo.Text;
                objBeanUsuario.TelefonoUsuario = txtTelefono.Text;
                objBeanUsuario.PassUsuario = txtPass.Text;


                ManejadoraUsuario objBeanUsuarioo = new ManejadoraUsuario();

                ManejadoraUsuario objManejadoraUsuario = new ManejadoraUsuario();
                objManejadoraUsuario.registrar(objBeanUsuario);

                lbEstadoTipo.Text = objManejadoraUsuario.estadoTipo;

                txtCedula.Text = " ";
                txtNombres.Text = " ";
                txtApellidos.Text = " ";
                txtCorreo.Text = " ";
                txtTelefono.Text = " ";

            }
            catch
            {
                // txtNombreTipoProducto.Enabled = false;       
            }
        }
    }
}