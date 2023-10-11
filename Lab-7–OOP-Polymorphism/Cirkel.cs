using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        //creating propertie for the Radius
        public double Radius { get; set; }

        //adding value to the propertie in this constructor.
        public Cirkel()
        {
            Radius = 4.0;
        }

        //Overriding the "Area" method and adding the specifik calculations for this class
        public override double Area()
        {
            
            return Radius * Radius * Math.PI;
        }
    }
    
}
