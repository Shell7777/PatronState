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
           Console.WriteLine("El total $ 256 , elija el metodo con el que desea pagar");
           Console.WriteLine("1.Bitcoins\n2.Targeta de credito\n3.Paypal");

            Compra compra = new Compra();

            string opcion = Console.ReadLine();
            
            switch (Int32.Parse(opcion))
            {
                case 1: compra.Metodo = new Bitcoin(); break;
                case 2: compra.Metodo = new CreditCard(); break;
                case 3: compra.Metodo = new Paypal(); break;
                default: break;
            }
            compra.pagar();
            Console.ReadLine();
        }
    }
}
