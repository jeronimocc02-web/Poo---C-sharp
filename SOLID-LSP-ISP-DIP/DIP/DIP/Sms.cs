using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class SMS : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("SMS enviado: " + mensaje);
        }
    }
}
