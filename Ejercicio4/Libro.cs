using System;

namespace EjerciciosSRP.Ejercicio4
{
    public class Libro
    {
        private string Titulo;
        private string Contenido;

        public Libro(string titulo, string contenido)
        {
            Titulo = titulo;
            Contenido = contenido;
        }

        public string ObtenerContenidoImprimible()
        {
            return $"{Titulo}{Environment.NewLine}{Contenido}";
        }
    }
}