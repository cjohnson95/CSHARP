using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    class Account {

        public int Id { get; set; }
        public Decimal Balance { get; set; } = 0;
        public String Description { get; set; }

        public bool Deposit(Decimal amount) 
        { 
        
        if(amount <= 0) 

        {
                throw new AmountGreaterThanZeroException();
        }
            this.Balance = this.Balance + amount;
            return true;
            
        }

        public bool Withdraw(decimal amount) 
        {
            if (amount <= 0) {
                Console.WriteLine($"AmountGreaterThanZeroException");
            }
            if (amount > this.Balance) {
                Console.WriteLine($"InsufficientFundsException");
            }
            Balance = this.Balance - amount;
            return true;
        }

        public bool Transfer(decimal amount, Account ToAccount) {
            var success = this.Withdraw(amount);
            if (success) {
                ToAccount.Deposit(amount);

            }
            return true;
        }
        public void Print() {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}


//added return true inside the curly brackets or the body of the command
// because the method was basically saying that if you transfer funds, even
//without the funds, it would return true. To fix that, the above was done to 
// reiterate the true statement ONLY if ACTUALLY true.











































