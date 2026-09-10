using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Notification
    {
        public void SendConfirmation(string product)
        {
            Console.WriteLine($"Confirmación del envio: {product}.");
        }
    }
}
