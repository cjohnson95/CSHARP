using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary {
    public static class StringExtensionMethods                                          //  class has to be static in an extension method 
       {
       

        public static int ConcatInt(this int i, int j)
        {
            return i * 10 + j;
        }
        public static void Print(this int i) 
        {
            Console.WriteLine($"Fred is {i} years old");
        }
         public static void Print(this string str)

            {

                var s = $"Fred is {str}";
                Console.WriteLine(s);
                System.Diagnostics.Debug.WriteLine(s);

            }
                
        }
            
        
           
        }

    

    
    

