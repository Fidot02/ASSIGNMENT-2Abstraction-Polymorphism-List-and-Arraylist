//ABATRACTION



using ASSIGNMENT_2Abstraction_Polymorphism_List_and_Arraylist;

BankAccount bankAccount = new SavingsAccount("1097645234",10000);

bankAccount.deposit(20000);

Console.WriteLine("the amount is " + bankAccount.Balance);

bankAccount.withdraw(5000);
Console.WriteLine(bankAccount.Balance);

Console.ReadKey();