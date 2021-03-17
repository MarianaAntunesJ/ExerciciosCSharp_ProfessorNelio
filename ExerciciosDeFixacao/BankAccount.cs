using System;
using System.Threading;

namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class BankAccount
    {
        private void Information()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the holder's name: ");
            string holdersName = Console.ReadLine();
            Account account = new Account(accountNumber, holdersName);

            MakeDeposit(account);

            Console.WriteLine(account.ToString());

            MakeDeposit(account);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account.ToString());

            WithdrawValue(account);
            Console.WriteLine("\nUpdated account data:");
            Console.WriteLine(account.ToString());
        }

        private void MakeDeposit(Account account)
        {
            Console.Write("It'll be an deposit (y/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'y')
                DepositValue(account);
        }

        private void DepositValue(Account account)
        {
            Console.Write("\nEnter the deposit value: ");
            double value = double.Parse(Console.ReadLine());
            account.Deposit(value);
        }

        private void WithdrawValue(Account account)
        {
            Console.Write("\nEnter the withdraw value: ");
            double value = double.Parse(Console.ReadLine());
            account.WithDraw(value);
        }
    }
}
