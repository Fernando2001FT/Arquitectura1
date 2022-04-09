using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio3
{
    public class Direccion
    {
        private string Ciudad;
        private string CodigoPostal;

            public Direccion(string ciudad, string codigoPostal)
        {
            CodigoPostal = codigoPostal;
            Ciudad = ciudad;
        }
        public void CambiarDireccion(string ciudad, string codigoPostal)
         {
            CodigoPostal = codigoPostal;
            Ciudad = ciudad;
          }
     }
}
