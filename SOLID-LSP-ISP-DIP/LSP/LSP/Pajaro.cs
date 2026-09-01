using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Pajaro : Animal, IPuedeVolar
    {
        public Pajaro(string nombre) : base(nombre) { }
        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }
    }

}
