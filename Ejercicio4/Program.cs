namespace EjerciciosSRP.Ejercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Libro libro = new Libro("Titulo", "Contenido");
            libro.ObtenerContenidoImprimible();
        }
    }
}