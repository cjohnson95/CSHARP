using System;

namespace MathLib {
    public static class MathLibrary                             // if you mark your class static, everything in it must also be static.
    {
        public static string About { get; set; } = "About Class1";     // get set controls the reading and the writing of these properties
        public static decimal PI = 3.1415927m;

        public static double Inverse(double a)                      // static methods are not allowed to access any other instances. If your not accessing other instances
                                                                   // in your class, making the methods static is a the way to go.
        {
            return 1 / a;
        }

        public static int Modulo(int a, int b)                 
        {
            return a - (a / b * b);                             // this is the equation for modulo
        }

        public static long Cubed (int a) 
            
        {
            return a * a * a;
        }


    
        
       


    }

    
    
}
