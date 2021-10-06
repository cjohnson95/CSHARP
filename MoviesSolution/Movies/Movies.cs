using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies {
    class Movies 
    {

        private static int NextId { get; set; } = 1;
        public int Id { get; set; }

         public string Title { get; set; }
         public string Genre { get; set; }
        public string Rating { get; set; } = "PG";
         public int Released { get; set; } // year only
         public int RuntimeinMinutes{ get; set; }
         public string Director{ get; set; }

        public static int CalcRuntimeInMinutes(int Hours, int Minutes);
        
        
                                                                                        // - this is the fucntion to calculate the total mins
         
           
              
        
            
      
        




    }
}
