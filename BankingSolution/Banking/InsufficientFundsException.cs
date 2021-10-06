using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    class InsufficientFundsException : Exception{

        public decimal CurrentBalance { get; set; }
        public decimal AmounttoWithdraw { get; set; }
        public InsufficientFundsException(decimal CurrentBalance, decimal AmounttoWithdraw)
            : base() 
            {
            this.CurrentBalance = CurrentBalance;
            this.AmounttoWithdraw = AmounttoWithdraw;
            }


        public InsufficientFundsException()           
            : base() { }

        public InsufficientFundsException(string Message)
            : base(Message) { }
        public InsufficientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
