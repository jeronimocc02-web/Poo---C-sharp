using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Triangle : Shape
    {
        public double Base{ get; set; }
        public double Heigh{  get; set; }
        public override double Area() => (this.Base * this.Heigh) / 2;
    }
}
