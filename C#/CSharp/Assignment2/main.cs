using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Run
    {
        public static void RunThis()
        {

        }
    }
     abstract class GeometricSymbols
    {
        abstract public decimal Perimeter { get; }
        abstract public decimal Area();
    }
    
    class Triangle : GeometricSymbols
    {   
        private int side1,side2,side3;

        public Triangle(int side1,int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override decimal Perimeter
        {
            get
            {
                return this.side1 + this.side2 +this.side3;
            }
        }
        public override decimal Area()
        {
            
        }

    }
    class Quadrilateral : GeometricSymbols
    {

    }
    class Square : Quadrilateral 
    {

    }
    class Rectangle :Quadrilateral
    {

    }
}
