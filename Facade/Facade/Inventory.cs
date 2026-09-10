using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Inventory
    {
        public bool CheckStock(string product)
        {
            Console.WriteLine($"Revisando el stock de {product}...");

            return true;
        }
    }
}
