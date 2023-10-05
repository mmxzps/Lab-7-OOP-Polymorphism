using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double A { get; set; }
        public double B { get; set; }

        public Ellips() 
            {
                A = 20; 
                B = 15;
            }
        public override double Area()
        {
            return A * B * Math.PI;
        }
    }
   
}
