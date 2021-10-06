using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    class AmountGreaterThanZeroException : Exception 
    {                                                       // When creating an exception, exception should always be at the end of the name
        public AmountGreaterThanZeroException()            //base is the parent class when doing an inheritance/ This is also a constructor
            : base() { }

        public AmountGreaterThanZeroException(string Message)
            : base(Message) { }
        public AmountGreaterThanZeroException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
