using BankAccountApp;
using System.Transactions;

BankAccount b =  new BankAccount();
b.AccountHolder = "Account Holder";
b.Balance = 1234.12;
b.WithdrawMoney (0);

while (true)
{
    Console.WriteLine($"--- Welcome {b.AccountHolder} ---");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit Amount");
    Console.WriteLine("3. Withdraw Amount");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an Option");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine($"Your Current balance is {b.Balance}");
            break;
        case "2":
            Console.Write("Enter an amount: ");
            if (Double.TryParse(Console.ReadLine(), out double DepositAmount))
            {
                Console.WriteLine(DepositAmount);
                Console.WriteLine($"Your Updated Balance is: {DepositAmount + b.Balance}");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            break;
        case "3":
            Console.Write("Enter an Amount: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double amount))
            {
                if (amount > b.Balance)
                {
                    Console.WriteLine("Invalid Amount or Insufficient Balance");
                }
                else
                {
                    Console.WriteLine($"Withdrawl Success Full Your Current Balance is {b.Balance - amount}");

                }
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
            break;
            
        case "4":
            Console.WriteLine("Thank You For using our system");
            return;
        default:
            Console.WriteLine("Invalid Choice");
            break;            

    }
}








