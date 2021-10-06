using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    class Rect : Quads {

        public new void Print() 
            
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
        public int Area() {

            return Side1 * Side2;
        }

        public Rect(int sideA, int sideB) : base(sideA, sideB, sideA, sideB)
        {
            Side1 = sideA;
            Side2 = sideB;                          // A constructor for rect. Base is the parent class
            Side3 = sideA;                          // sides A are equilateral and sides B are equilateral.
            Side4 = sideB;
        
        }

        









    }
}

