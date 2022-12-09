using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {



            BankAccount bankAccount = new();
            {
                Console.WriteLine($"Please enter deposit amount?");

                var amountToDep = double.Parse(Console.ReadLine());


                bankAccount.Deposit(amountToDep);

                Console.WriteLine($"You're new balance is {bankAccount.GetBalance()}");



               

                









            }




        }
    }
}
