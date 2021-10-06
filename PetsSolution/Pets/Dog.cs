using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets {
    class Dog {
       
        public string Name { get; set; } = "Lassie";
        public string Color { get; set; } = "Golden";
        public string BarkSound { get; set; } = "Woof";

        public string Bark() {
            return BarkSound;
        }
    }
}

