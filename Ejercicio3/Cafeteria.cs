namespace EjerciciosSRP.Ejercicio3
{
    public class Cafeteria
    {
        private string Nombre;
        private string Ciudad;
        private string CodigoPostal;

        public Cafeteria(string nombre, string ciudad, string codigoPostal)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
        }

        public string ObtenerNombre() => Nombre;

        public void CambiarDireccion(string ciudad, string codigoPostal)
        {
            CodigoPostal = codigoPostal;
            Ciudad = ciudad;
        }
    }
}