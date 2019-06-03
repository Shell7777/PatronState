using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class EnEspera : IEstado
    {
        public void EjecutaAccion()
        {
            Console.WriteLine("Se ha heco una compra y se espera que el pago sea correcto");

        }
    }
}
