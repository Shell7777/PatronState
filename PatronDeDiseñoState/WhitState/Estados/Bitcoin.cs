using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Bitcoin : IPago
    {
        public void datosDeUsuario()
        {
            Console.WriteLine("Introduzca codigo de wallet ");
            String nmro;
            nmro = Console.ReadLine();

        }

        public string Transaccion(bool datos)
        {
            return datos == true ? "Transaccion exitosa" : "Ha ocurido un error";
        }
    }
}
