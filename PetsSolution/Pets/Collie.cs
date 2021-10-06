using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    class Collie : Dog, IBark {
       

        public new string Bark()
        {
            return BarkSound;
        }
    }
}

