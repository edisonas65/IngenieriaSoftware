using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PRYDonacion
{
    public partial class Donacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!(IsPostBack)) //Sirve para que cargue una vez a lo que inicia la pagina
                {
                    this.cargaTipoDonacion();

                    /*string tipo = (string)Session["id_rol"];
                    if (tipo == "adm")
                    {
                        // HyperLink1.Visible = true;
                        hvEditarUsuario.Visible = true;
                        // Response.Write("Usuario Profesor");
                    }
                    else
                    {
                        //HyperLink1.Visible = false;
                        hvEditarUsuario.Visible = false;

                    }*/

                }

            }
            catch
            {

            }

        }
        

        public void cargaTipoDonacion()
        {
            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = "Data Source=DESKTOP-HQ6M0AV\\SQL2019; Database=DONACIONES; Integrated Security = SSPI";
            objConexion.Open();

            SqlCommand OrdenSqlSelect = new SqlCommand("select * from TipoDonacion", objConexion);
            SqlDataAdapter da = new SqlDataAdapter(OrdenSqlSelect.CommandText, objConexion);
            DataSet ds = new DataSet();
            da.Fill(ds);

            this.cbListaTipoDonacion.DataSource = ds;
            this.cbListaTipoDonacion.DataValueField = "CodTipoDonacion";
            this.cbListaTipoDonacion.DataTextField = "DescripcionTipoDonacion";
            this.cbListaTipoDonacion.DataBind();
            this.cbListaTipoDonacion.Items.Insert(0, new ListItem("Elija una Opcion..", "0"));

            objConexion.Close();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                BeanDonacion objBeanDonacion = new BeanDonacion();
                objBeanDonacion.DescripcionDonacion = txtDescripcionDonacion.Text;
                objBeanDonacion.CantidadDonacion = Convert.ToInt32(txtCantidad.Text);
                objBeanDonacion.MontoDonacion = Convert.ToSingle(txtMonto.Text);

                objBeanDonacion.TipoDonacion = cbListaTipoDonacion.SelectedItem.Text;

                if (cbListaTipoDonacion.SelectedItem.Text == "Elija una Opcion..")
                {
                    lbErroRol.Text = "Debe seleccionar un tipo";

                }
                else
                {
                    ManejadoraDonacion objManejadoraDonacion = new ManejadoraDonacion();
                    objManejadoraDonacion.registrarDonacion(objBeanDonacion);

                    lblRegistro.Text = objManejadoraDonacion.estadoTipo;

                    txtDescripcionDonacion.Text = " ";
                    txtCantidad.Text = " ";
                    txtMonto.Text = " ";
                    lbErroRol.Text = " ";
                    this.cargaTipoDonacion();
                }

            }
            catch
            {
                
            }
        }
    }
}