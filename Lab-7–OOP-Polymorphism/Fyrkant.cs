using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Fyrkant()
        {
            Width = 7.1;
            Height = 7.1;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
   
}
