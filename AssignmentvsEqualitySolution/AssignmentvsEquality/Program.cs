using System;

namespace AssignmentvsEquality { 
    class Program 
    {

        /* x | y | x&&y
         * =   =   ==
         * T   T    T
         * T   F    F
         * F   T    F
         * F   F    F
         * 
         * x | y | x||y
         * =   =   ==
         * T    T   T
         * T    F   F   
         * F    T   F
         * F    F   F
         * 
         * x | !x
         * T    F   
         * F    T
        */
        static void Main(string[] args) 
            {
                var TheNumber = 5;
            if ((TheNumber > 0) && (TheNumber < 10)) { 
                Console.WriteLine($"The numer is GT zero and LT 10");
                Console.WriteLine("Display this message also");
            }
                
           
            
            


                

                
            
            
            var TF = (TheNumber > 0) && (TheNumber < 10);
            TF = TheNumber < 10 && TheNumber > -7;
            TF = TheNumber < -7 || TheNumber > 10;
            TF = TheNumber > -7 || TheNumber < 10;

            var mod = 19 % 3;
            mod = 19 - (3 * (19 / 3));
            var a = 1;
            var b = 1;
            var IsAAndBEqual = (a == b);
            if(true) 
               {
                // these statements will ALWAYS be done
                }

        }
    }
}
