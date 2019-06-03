using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState
{
    class Compra
    {
        public IPago Metodo { get; set; }


        public void pagar() {
            Metodo.datosDeUsuario();
            Console.WriteLine(Metodo.Transaccion(true));
        }
        public void cancelarCompra()
        {
            Console.WriteLine("Su compra se ha cancelado");
        }
        public void EliminarCompra()
        {
            Console.WriteLine("Su compra se ha Eliminado");
        }
        // 
        // 
        //
        //

    }
}
