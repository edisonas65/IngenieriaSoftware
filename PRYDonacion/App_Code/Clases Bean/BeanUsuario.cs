namespace PRYDonacion
{
    internal class BeanUsuario
    {
        private string cedulaUsuario;
        private string nombresUsuario;
        private string apellidosUsuario;
        private string correoUsuario;
        private string passUsuario;
        private string telefonoUsuario;

        public BeanUsuario()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public string CedulaUsuario { get => cedulaUsuario; set => cedulaUsuario = value; }
        public string NombresUsuario { get => nombresUsuario; set => nombresUsuario = value; }
        public string ApellidosUsuario { get => apellidosUsuario; set => apellidosUsuario = value; }
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string PassUsuario { get => passUsuario; set => passUsuario = value; }
        public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
    }
}