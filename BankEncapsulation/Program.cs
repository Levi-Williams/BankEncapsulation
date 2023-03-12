using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Hello! Welcome to Limited ATM");

            Console.WriteLine("Please choose from the following options:");

            Console.WriteLine("Select '1' to check balance");
            Console.WriteLine("Select '2' to deposit into account");
            Console.WriteLine("select '3' to exit terminal");

            var selection = Console.ReadLine();

            double accountBalance = account.GetBalance();

                if (selection == "1")
                {
                    Console.WriteLine($"{accountBalance}");
                }
                if (selection == "2")
                {
                    Console.WriteLine("Please enter the amount you would like to deposit:");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Your new balance is {account.GetBalance()}");
                }
                if (selection == "3") { Console.WriteLine("Goodbye, have a great day!"); }
 
        }


    }
}