using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    class Chihuahua : Dog, IBark{
      

        public new string Bark() 
        {
            return BarkSound;
             
        }
        public string Walk() 
            
            {
            return "Walking the Dog";
                
            }
    }
}
