using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Verificada : IEstado
    {
        public void EjecutaAccion()
        {
            Console.WriteLine("El pago es correcto y se esta esperando enviar al producto");
        }
    }
}
