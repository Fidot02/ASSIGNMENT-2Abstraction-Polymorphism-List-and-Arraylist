using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_2Abstraction_Polymorphism_List_and_Arraylist
{
    public class SavingsAccount : BankAccount
    {
        public decimal _initialbalance;
        public override string AccountNumber
        {
            get
            {
                return _Accountnumber;
            }
        }
        public override decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        public SavingsAccount (string Accountnumber, decimal initialbalance) :base( Accountnumber, initialbalance)
        {
            _initialbalance = initialbalance;
        }
        
        public override void deposit(decimal amount)
        { if (amount == 0)
            {
                _balance = amount;
            }
            else
            {
                _balance = _initialbalance + amount;
            }
        }
        public override void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                _balance = 0;
            }
            else
            {
                _balance = Balance - amount;
            }
        }

    }

}
