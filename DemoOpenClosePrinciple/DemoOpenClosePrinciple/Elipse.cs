using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    internal class Elipse : Shape
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public override double Area() => (this.MinorAxis * this.MinorAxis * Math.PI);
    }
}
