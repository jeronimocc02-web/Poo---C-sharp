using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    using System;

    namespace Facade
    {
        public class Shipping
        {
            public void PreparePackage(string product)
            {
                Console.WriteLine($"Preparando el paquete de {product}...");
            }

            public void Ship(string product)
            {
                Console.WriteLine($"Envio {product}...");
            }
        }
    }

}
