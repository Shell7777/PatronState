using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Cancelada : IEstado
    {
        public void EjecutaAccion()
        {
            Console.WriteLine(
                                 "la compra se ha cancelado porque el usuario " +
                                 "no quiere ya el producto, no hay existencias" +
                                 " u otro motivo."
                             );
        }
    }
}
