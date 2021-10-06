using System;

namespace FIZZBUZZ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

           
                for (var idx = 1; idx <= 30; idx++) {
                if (idx % 3 == 0 && idx % 5 == 0) {
                    Console.Write("FIZZBUZZ");
                }
                else if (idx % 3 == 0) {
                    Console.Write("FIZZ");
                    {
                        if (idx % 5 == 0) {
                            Console.Write("Buzz");
                        }
                    }
                }
                   
            }

        }
    }
}
