using System;
using System.IO;

namespace EjerciciosSRP.Ejercicio2
{
    public class ServicioPublicacion
    {


        public void CrearPublicacion(Dbcontext contextoDB, string mensajeAPublicar)
        {
            try
            {
                contextoDB.Add(mensajeAPublicar);
            }
            catch(Exception ex)
            {
                new LogeoError(Dbcontext).Logear(ex);
            }
        }
    }
}