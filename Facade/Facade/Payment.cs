using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Payment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Procesando el pago de ${amount}...");
        }
    }
}
