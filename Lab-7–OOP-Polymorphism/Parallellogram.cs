using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Parallellogram ()
        {
            Width = 7;
            Height = 4;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
    
}
