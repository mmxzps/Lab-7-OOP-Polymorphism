using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    //creating propertie for the Parallellogram
    internal class Parallellogram : Geometri
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //adding value to the propertie in this constructor.
        public Parallellogram ()
        {
            Width = 7;
            Height = 4;
        }

        //Overriding the "Area" method and adding the specifik calculations for this class
        public override double Area()
        {
            return Width * Height;
        }
    }
    
}
