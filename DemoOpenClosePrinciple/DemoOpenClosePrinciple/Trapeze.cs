using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    internal class Trapeze : Shape
    {
        public double LargerBase { get; set; }
        public double SmallerBase { get; set; }
        public double Heigh { get; set; }

        public override double Area() => (this.Heigh * (this.LargerBase + this.SmallerBase) / 2);
    }
}
