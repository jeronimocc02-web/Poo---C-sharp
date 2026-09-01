using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot está trabajando.");
        }
    }

}
