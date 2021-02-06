namespace PRYDonacion
{
    internal class BeanDonacion
    {
        private string tipoDonacion;
        private string descripcionDonacion;
        private int cantidadDonacion;
        private float montoDonacion;

        public string TipoDonacion { get => tipoDonacion; set => tipoDonacion = value; }
        public string DescripcionDonacion { get => descripcionDonacion; set => descripcionDonacion = value; }
        public int CantidadDonacion { get => cantidadDonacion; set => cantidadDonacion = value; }
        public float MontoDonacion { get => montoDonacion; set => montoDonacion = value; }
    }

}