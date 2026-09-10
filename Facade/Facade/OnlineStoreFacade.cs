using Facade.Facade;
using System;   
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class OnlineStoreFacade
    {
        private Inventory inventory;
        private Payment payment;
        private Shipping shipping;
        private Notification notification;

        public OnlineStoreFacade()
        {
            inventory = new Inventory();
            payment = new Payment();
            shipping = new Shipping();
            notification = new Notification();
        }

        public void BuyProduct(string product, double price)
        {
            Console.WriteLine($"Iniciando Compra de {product}...");
            Console.WriteLine();

            if (!inventory.CheckStock(product))
            {
                Console.WriteLine("Este producto se acabo");
                return;
            }

            payment.ProcessPayment(price);

            shipping.PreparePackage(product);
            shipping.Ship(product);

            notification.SendConfirmation(product);

            Console.WriteLine();
            Console.WriteLine("Compra realisada");
        }
    }
}
