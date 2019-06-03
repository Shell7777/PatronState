using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class CreditCard : IPago
    {
        public void datosDeUsuario()
        {
            Console.WriteLine("Introduzca numero de targeta");
            String nmro;
            nmro = Console.ReadLine();

            Console.WriteLine("Introduzca numero de fecha devencimiento");
            String fecha;
            fecha  = Console.ReadLine();

            Console.WriteLine("Introduzca el codigo de seguridad de la targeta");
            String cod;
            cod = Console.ReadLine();

        }

        public string Transaccion(bool datos)
        {
            return datos == true ? "Transaccion exitosa" : "Ha ocurido un error";

        }
    }
}
