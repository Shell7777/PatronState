using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Paypal : IPago
    {
        public void datosDeUsuario()
        {
            Console.WriteLine("Introduzca su usuario");
            String texto;
            texto = Console.ReadLine();
            
            Console.WriteLine("Usuario Correcto");
            Console.WriteLine("..........");

        }

        public string Transaccion(Boolean datos)
        {
            //datos de transaccion 
            return datos == true ? "Transaccion exitosa" : "Ha ocurido un error";

        }
    }
}
