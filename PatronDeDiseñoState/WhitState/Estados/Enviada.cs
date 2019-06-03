using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Enviada : IEstado
    {
        public void EjecutaAccion()
        {
            Console.WriteLine("El pedido ha sido enviado.");
        }
    }
}
