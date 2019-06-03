using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState
{
    interface IPago { 
        void datosDeUsuario();
        string Transaccion(Boolean datos);
    }
}
