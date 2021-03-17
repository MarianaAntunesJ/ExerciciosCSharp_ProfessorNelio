namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string HoldersName { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string holdersName)
        {
            AccountNumber = accountNumber;
            HoldersName = holdersName;
        }

        public void Deposit(double deposit)
        {
            if (deposit >= 0)
                Balance += deposit;
        }

        public void WithDraw(double withDraw) => Balance -= (withDraw + 5);

        public override string ToString()
        {
            return ($"\nAccount data:\nAccount: {AccountNumber}, " +
                $"Holder: {HoldersName}, Balance: $ {Balance:F2}");
        }
    }
}
}
