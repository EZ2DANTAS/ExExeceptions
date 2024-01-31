using ExExeceptions.Entities;
using ExExeceptions.Entities.Excepitons;
using System;

namespace ExExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                account.Withdraw(withdraw);

                Console.WriteLine("New Balance: "+ account.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Whitdraw error: " + e.Message);
            }
        }
    }
}