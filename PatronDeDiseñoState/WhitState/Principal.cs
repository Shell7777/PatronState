using PatronDeDiseñoState.WhitState.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseñoState.WhitState
{
    class Principal
    {
        public void metodoPrincipal (string[] args)
        {
            
            Compra compra = new Compra();
            compra.Estado = new Creada();
            compra.cambiarEstado();
            compra.Estado = new EnEspera();
            compra.cambiarEstado();
            compra.Estado = new Cancelada();
            compra.cambiarEstado();
            compra.Estado = new Enviada();
            Console.ReadKey();
        }
    }
}
