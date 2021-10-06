using System;

namespace ClassTutorial {
    class Program {
        static void Main(string[] args) {



            var mathlib = new MathLib();
            var a = 1;
            var b = 6;
            var mod = mathlib.Mod(a, b);
            Console.WriteLine($"{a} mod {b} is {mod}");

           /* var fred = new Student();
            fred.Name = "Fred";
            var wilma = new Student();
            wilma.Name = "Wilma";
            var barney = new Student();
            barney.Name = "Barney";
            wilma.SAT = 2000;
            fred.SAT = 1000;
            var message = wilma.Print(1);
            Console.WriteLine(message);

            message = fred.Print(2);
            Console.WriteLine(message);
            barney.SAT = 1200;
            barney.Print(3);
            barney.SAT = barney.SAT + 20;
            barney.Print(4);
           */





        }
    }
    

}
