using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace PRYDonacion
{
    internal class ManejadoraUsuario
    {

        public ManejadoraUsuario()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }


        public string estadoTipo;
        public string sql2;

        public SqlConnection objConexion1;
        public SqlDataAdapter sentencia1;

        public static string EncodePassword(string originalPassword)
        {
            if (originalPassword is null)
            {
                throw new ArgumentNullException(nameof(originalPassword));
            }

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha1.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }

        public static bool Autenticar(string usuario, string password)
        {
            //consulta a la base de datos
            string sql = @"select count(*) from Usuarios where Correo=@Correo and Pass=@Pass";

            //cadena conexion
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HQ6M0AV\\SQL2019; Database=DONACIONES; Integrated Security = SSPI"))
            {
                conn.Open();//abrimos conexion

                SqlCommand cmd = new SqlCommand(sql, conn); //ejecutamos la instruccion
                cmd.Parameters.AddWithValue("@Correo", usuario); //enviamos los parametros

                string hash = ManejadoraUsuario.EncodePassword(string.Concat(usuario, password));

                cmd.Parameters.AddWithValue("@Pass", hash);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
        }

        public Boolean registrar(BeanUsuario objUsuario)
        {
            String sentencia;

            string password = ManejadoraUsuario.EncodePassword(string.Concat(objUsuario.NombresUsuario, objUsuario.PassUsuario));

            sentencia = " insert into Usuarios (Cedula,NombreUsuario,ApellidoUsuario,Correo,Telefono,Pass,CodTipoPerfil) select '"
                + objUsuario.CedulaUsuario + "', '" + objUsuario.NombresUsuario + "', '" + objUsuario.ApellidosUsuario + "','" + objUsuario.CorreoUsuario + "','"
                + objUsuario.TelefonoUsuario + "','"+ password + "','" + "1'" ;

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

        public static DataTable ConsultarUsuario(string usuario, string password)
        {
            string sql = @"SELECT Correo
                           FROM Usuarios 
                            WHERE Correo = @user AND Pass = @pass";

            //cadena conexion
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HQ6M0AV\\SQL2019; Database=DONACIONES; Integrated Security = SSPI"))
            {


                SqlCommand cmd = new SqlCommand(sql, conn); //ejecutamos la instruccion
                cmd.Parameters.AddWithValue("@user", usuario); //enviamos los parametros

                string hash = ManejadoraUsuario.EncodePassword(string.Concat(usuario, password));

                cmd.Parameters.AddWithValue("@pass", hash);


                conn.Open();//abrimos conexion
                SqlDataAdapter daAdaptador = new SqlDataAdapter(cmd);
                DataTable dtDatos = new DataTable();
                daAdaptador.Fill(dtDatos);
                return dtDatos;

            }

        }

    }        

}