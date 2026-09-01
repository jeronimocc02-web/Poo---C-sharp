using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Persona : ITrabajador, IComedor
    {
        public void Trabajar()
        {
            Console.WriteLine("La persona está trabajando.");
        }

        public void Comer()
        {
            Console.WriteLine("La persona está comiendo.");
        }
    }
}
