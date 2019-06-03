using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronDeDiseñoState.WhitOutState;
using PatronDeDiseñoState.WhitState;
namespace PatronDeDiseñoState
{
    class Program
    {
        static void Main (string[] args)
        {

            Principal principal = new Principal();
            principal.metodoPrincipal(args);
        }
    }
}
