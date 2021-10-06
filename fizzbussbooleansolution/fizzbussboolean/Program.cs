#define french
using System;

namespace fizzbussboolean {
    class Program {
        static void Main(string[] args) {


            var yes = "Yes";
            var no = "No";

#if french
            yes = "Oui";
            no = "Non";

#endif
            var boolean = false;

            Console.WriteLine($"Boolean is { boolean }); text is { (boolean ? yes : no)}");
        }
    }
}

                    
    

