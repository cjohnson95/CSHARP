using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    class Quads {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }     // these are the properties of the Quad or thing we are progamming
        public int Side4 { get; set; }


        public void Print() 
        {

            Console.WriteLine($"Perimeter: {Perimeter()}");

        }



        public int Perimeter() {
                                                          // there is always a () at the end of the name i.e. Perimeter. 
            return Side1 + Side2 + Side3 + Side4;         // this is a method. You can tell by the return command
        }                                                 // It is what tells the program what data to return...
                                                          // methods always have a return type even if its void
        public Quads(int Side1, int Side2, int Side3, int Side4) {                              
            
            this.Side1 = Side1;
            this.Side2 = Side2;                                         // this is a constructor; looks like a methodm but 
            this.Side3 = Side3;                                         // does not have a return. Will always have the name
            this.Side4 = Side4;                                         //of the class in it; see "Quad"
                                                                          

        }
    }
}








