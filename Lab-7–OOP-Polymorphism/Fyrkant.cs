using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        //creating propertie for the Fyrkant
        public double Width { get; set; }
        public double Height { get; set; }

        //adding value to the propertie in this constructor.
        public Fyrkant()
        {
            Width = 7.1;
            Height = 7.1;
        }

        //Overriding the "Area" method and adding the specifik calculations for this class
        public override double Area()
        {
            return Width * Height;
        }
    }
   
}
