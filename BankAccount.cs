using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_2Abstraction_Polymorphism_List_and_Arraylist
{
    public abstract class BankAccount
    {
        protected string _Accountnumber;
        protected decimal _balance;

        public abstract string AccountNumber { get; }
        
        public abstract decimal Balance { get; }

        public BankAccount(string Accountnumber, decimal initialbalance)
        {
            _Accountnumber = Accountnumber;
            _balance = initialbalance;
        }


        public abstract void deposit(decimal amount);

        public abstract void withdraw(decimal amount);



    }
}
