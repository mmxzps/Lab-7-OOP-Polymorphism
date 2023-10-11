using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        //creating propertie for the Ellips
        public double A { get; set; }
        public double B { get; set; }

        //adding value to the propertie in this constructor.
        public Ellips() 
            {
                A = 20; 
                B = 15;
            }

        //Overriding the "Area" method and adding the specifik calculations for this class
        public override double Area()
        {
            return A * B * Math.PI;
        }
    }
   
}
