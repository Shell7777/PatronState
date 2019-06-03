using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState.Estados
{
    class Creada : IEstado
    {
        public void EjecutaAccion()
        {
            Console.WriteLine("La compra se acaba de crear");
        }
    }
}
