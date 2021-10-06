using System;
using System.Collections.Generic;
using System.Linq;

namespace linqtutorial {
    class Program {
        static void Main(string[] args) 
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Amazon" },
                new Customer { Id = 2, Name = "Target" },
                new Customer { Id = 3, Name = "Microsoft" }
            };


            var orders = new List<Order>()
            {
            new Order { Id = 1, Description = "1st Order", Sales = 1000, CustomerId = 1 },
            new Order { Id = 2, Description = "2nd Order", Sales = 2000, CustomerId = 3 },
            new Order { Id = 3, Description = "3rd Order", Sales = 3000, CustomerId = 2 }
            };

            var CustOrders = from o in orders
                             join c in customers
                             on o.CustomerId equals c.Id
                             select new { o, c };

            foreach(var co in CustOrders) 
            {
                Console.WriteLine($"{co.c.Name} | { co.o.Description} | { co.o.Sales}");

            }

        }
        
            
            
           
           
                                                                                        


            /*int[] ints = new int[]             // ints is the collection of number
            {
                620, 849, 649, 989, 993, 524, 216, 173, 136, 482,
                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
                621, 981, 103, 482, 917, 124, 276, 839, 476 ,789,
                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
            };

                Console.WriteLine($"Average is {ints.Average()}");          // this is the average syntax

            var sum = ints.Sum() - ints.Min() - ints.Max();         // this is subtracting the min and max from sum
            var avg = sum / (ints.Count() - 2.0);                   // this is saying avg is the sum divided by the amount of integers/data
            Console.WriteLine($"Average without max and min is {avg}");  // the 2.0 
            

            //List of ints less than Avg ordered descending; the below code
            var lowInts = ints.Where(i => i < ints.Average()).OrderByDescending(i => i);
            foreach(var i in lowInts) 
            {
                Console.Write($"{i}");
            }

            //This is an exmaple w/o LAMDA

            var lowInts2 = from i in ints
                           where i < ints.Average()
                           orderby i descending
                           select i;


            foreach(var i in lowInts) 
            {
                Console.Write($"{i}");
            }
                
            */
        }
    }




