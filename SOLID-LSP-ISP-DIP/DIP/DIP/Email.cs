using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Email : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Email enviado: " + mensaje);
        }
    }
}
