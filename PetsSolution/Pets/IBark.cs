using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    interface IBark 
    {
        
        string Name { get; set; }
        string Color { get; set; }
        string BarkSound { get; set; }

        string Bark();
    }
     
}

