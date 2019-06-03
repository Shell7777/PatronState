using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState
{
    class Compra
    {
        public IEstado Estado { get; set; }
        public void cambiarEstado() {
            Estado.EjecutaAccion();
        }
    }
}
