using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        //creating propertie for the Rektangel
        public double Width { get; set; }
        public double Height { get; set; }

        //adding value to the propertie in this constructor.
        public Rektangel() 
        {
            Width = 10.2;
            Height = 5.5;
        }

        //Overriding the "Area" method and adding the specifik calculations for this class
        public override double Area()
        {
            return Width * Height;
        }
    }
}

