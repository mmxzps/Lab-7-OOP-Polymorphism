using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rektangel() 
        {
            Width = 10.2;
            Height = 5.5;
        }
    public override double Area()
        {
            return Width * Height;
        }
    }
}

