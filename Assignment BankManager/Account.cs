namespace Assignment_BankManager
{

    internal class Account
    {
        public Account(string accountHolder)
        {
            Naam = accountHolder;
            RekeningNummer = $"BE {DateTime.Now.DayOfYear}-{DateTime.Now:HHmmss}";

        }
        public string Naam { get; set; }
        public decimal Bedrag { get; set; }

        public string RekeningNummer { get; set; }

        public AccountStatus Status { get; set; }
        public decimal GetBalance() => Bedrag;
        internal Boolean PayInFunds(decimal deposit)
        {
            if (deposit < 0)
            {
                return false;
            }
            if (Status==AccountStatus.Geblokkeerd)
            {
                throw new AccountExeption("De rekening is geblokkeerd. GEEN ACTIVITEIT MOGELIJK");
            }
            Bedrag += deposit;
            return true;
        }

        internal bool WithDrawFunds(decimal withdrawAmount)
        {
            if (withdrawAmount < 0)
            {
                throw new ArgumentException("Withdraws can not be negative");
            }
            if (Bedrag < withdrawAmount)
            {
                return false;
            }
            if (Status == AccountStatus.Geblokkeerd)
            {
                throw new AccountExeption("De rekening is geblokkeerd. GEEN ACTIVITEIT MOGELIJK");
            }
            Bedrag -= withdrawAmount;
            return true;
        }

        internal bool WithDrawMaximunAvailable()
        {
            if (Status == AccountStatus.Geblokkeerd)
            {
                throw new AccountExeption("De rekening is geblokkeerd. GEEN ACTIVITEIT MOGELIJK");
            }
            if (Bedrag == 0)
            {
                return false;
            }
            Bedrag = 0;
            return true;
        }
        public override string ToString()
        {
            return $"{Naam} {RekeningNummer} balance = {GetBalance()} Status = {Status}";
        }
    }
}
