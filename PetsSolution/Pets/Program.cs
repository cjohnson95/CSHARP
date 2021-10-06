using System;
using System.Collections.Generic;

namespace Pets {
    class Program {
        static void Main(string[] args) {
            var dogs = new List<IBark>()

            {
                new Collie(),
                new Boxer(),
                new Chihuahua()
            };

            foreach (var dog in dogs) {
                Console.WriteLine($"The dog {dog.Name} barks {dog.Bark()}");
                var chawawa = dog as Chihuahua;
                if (chawawa is not null) {
                    Console.WriteLine($"Walking Chawawa is {chawawa.Walk()}");
            }

            }
        }
    }
}
