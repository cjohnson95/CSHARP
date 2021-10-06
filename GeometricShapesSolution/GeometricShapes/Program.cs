using System;

namespace GeometricShapes {
    class Program {
        static void Main(string[] args) {

            var s1 = new Sqr(5);
            s1.Print(); {

                
               
            };
            Console.WriteLine($"Perimeter is {s1.Perimeter()}");
            Console.WriteLine($"Area is {s1.Area()}");
                                                          //console is like a class and writeline tells what to do in that class
            var s2 = new Sqr(5);                           // console is a class in microsoft office i.e. visual studio that
            Console.WriteLine($"Perimeter is {s2.Perimeter()}"); // helps programmers do things. They are not part of the classes
            Console.WriteLine($"Area is {s2.Area()}");          // that programmers create in a project.


            var r1 = new Rect (3, 5) {
                Side1 = 3,
                Side2 = 5,
                Side3 = 3,
                Side4 = 5
            };

            Console.WriteLine($"Area is {r1.Area()}");
            Console.WriteLine($"Perimeter is {r1.Perimeter()}");

            var r2 = new Rect(3, 7);
                        


            Console.WriteLine($"Area is {r2.Area()}");
            
            Console.WriteLine($"Perimeter is {r2.Perimeter()}");



            var q1 = new Quads(3, 4, 5, 6); 
             
            
            Console.WriteLine($"Perimeter is {q1.Perimeter()}");

        }
    }
}
