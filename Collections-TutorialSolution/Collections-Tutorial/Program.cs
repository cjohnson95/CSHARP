using System;
using System.Collections.Generic;

namespace Collections_Tutorial {
    class Program {
        static void Main(string[] args) {

            var rnd = new Random();
            var frames = new List<int>();

            for (int idx = 0; idx < 30; idx++) 
            {
               var frame = rnd.Next(0, 31);
                frames.Add(frame);
            }

            var game = 0;
            foreach (var score in frames) 
            {
                game += score;
            }
            Console.WriteLine($"Games is {game}");


        }
    }


            
            
            






            /* 
             var ListOfNumbers = new List<int>();
              ListOfNumbers.Add(98);
              ListOfNumbers.Add(7);
              ListOfNumbers.Add(56);
              ListOfNumbers.Add(13);
              ListOfNumbers.Add(72);
              ListOfNumbers.Add(42);
              ListOfNumbers.Add(44);

              var sum = 0; 
              foreach(var nbr in ListOfNumbers) // use foreach to do sums of data
              {
                  sum += nbr; // equivalent to sum = sum + nbr
              }
              Console.WriteLine($"Sum is {sum}");
          }
            */
        }
    