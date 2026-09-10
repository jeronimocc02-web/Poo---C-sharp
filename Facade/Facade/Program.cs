using Facade;
using Facade.Facade;

/*
OnlineStoreFacade store = new OnlineStoreFacade();
store.BuyProduct("Papa", 3000);
*/

Inventory inventory = new Inventory();
Payment payment = new Payment();
Shipping shipping = new Shipping();
Notification notification = new Notification();

string product = "Curos de Programacion Orientada a Objetos";
double price = 1000000;

if (inventory.CheckStock(product))
{
    payment.ProcessPayment(price);

    shipping.PreparePackage(product);
    shipping.Ship(product);

    notification.SendConfirmation(product);
}
