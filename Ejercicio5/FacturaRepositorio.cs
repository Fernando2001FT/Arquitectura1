using System.Net.Mail;

namespace EjerciciosSRP.Ejercicio5
{
    public class FacturaRepositorio
    {
        public void GuardarFactura(Factura factura)
        {
            //Código para guardar factura
            new EmailCorreo().EnviarFactura(Email new MailMessage());
        }
        
        public void EliminarFactura(string numeroFactura)
        {
            //Código para eliminar factura
        }

     
      
    }
}