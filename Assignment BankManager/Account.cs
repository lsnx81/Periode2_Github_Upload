namespace Assignment_BankManager
{

    internal class Account
    {
        public Account(string accountHolder)
        {
            Naam = accountHolder;
            RekeningNummer = $"BE {DateTime.Now.DayOfYear}-{DateTime.Now:HHmmss}";

        }
        public string Naam { get; }
        public decimal Bedrag { get; private set; }

        public string RekeningNummer { get; init; }

        public AccountStatus Status { get; set; }
        public decimal GetBalance() => Bedrag;
        internal void PayInFunds(decimal deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentException("Deposits can not be negative");
            }
            Bedrag += deposit;
        }

        internal bool WithDrawFunds(decimal withdrawAmount)
        {
            if (Bedrag < withdrawAmount)
            {
                return false;
            }
            Bedrag -= withdrawAmount;
            return true;
        }

        internal bool WithDrawMaximunAvailable()
        {
            if (Bedrag == 0)
            { return false; }
            Bedrag = 0;
            return true;
        }
        public override string ToString()
        {
            return $"{Naam} {RekeningNummer} balance = {GetBalance()}";
        }
    }
}
