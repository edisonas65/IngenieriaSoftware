using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace PRYDonacion
{
    internal class ManejadoraDonacion
    {

        public ManejadoraDonacion()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public string estadoTipo;

        public Boolean registrarDonacion(BeanDonacion objDonacion)
        {
            String sentencia;
            
            sentencia = " insert into DetalleDonacion (CodTipoDonacion,CodUsuario,Fecha,DescripcionDonacion,Cantidad,Monto) select " 
             + "CodTipoDonacion" + ",1," + "getdate(),'"+ objDonacion.DescripcionDonacion + "','" + objDonacion.CantidadDonacion + "','" + objDonacion.MontoDonacion + "' from TipoDonacion where DescripcionTipoDonacion='" + objDonacion.TipoDonacion + "'";

            Boolean respuesta = true;

            SqlConnection objConexion = new SqlConnection();
            SqlCommand objCommand = new SqlCommand();

            objConexion.ConnectionString = "Data Source=DESKTOP-HQ6M0AV\\SQL2019; Database=DONACIONES; Integrated Security = SSPI";

            try
            {
                objConexion.Open();
                objCommand.Connection = objConexion;
                try
                {
                    objCommand.CommandText = sentencia;

                    objCommand.CommandType = CommandType.Text;
                    respuesta = (objCommand.ExecuteNonQuery() > 0);

                    objCommand.Dispose();
                    objConexion.Close();
                    estadoTipo = "Ok, Se guardo correctamente";
                }
                catch (Exception ex)
                {
                    estadoTipo = ex.Message;
                    objCommand.Dispose();
                    objConexion.Close();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
            }
            return respuesta;

        }

    }

}