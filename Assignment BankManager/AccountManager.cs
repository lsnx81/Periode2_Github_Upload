namespace Assignment_BankManager
{
    internal class AccountManager
    {
        HashSet<Account> accounts = new HashSet<Account>();

        public Account CreateAccountFor(string accountHolder, decimal initialDeposit)
        {
            var account = accounts.FirstOrDefault(a => string.Equals(a.Naam, accountHolder));
            if( account is null)
                account=new Account(accountHolder);

            accounts.Add(account);
            account.PayInFunds(initialDeposit);
            return account;
        }

        public bool TryWithDrawFunds(string rekeningnummer, decimal withdrawAmount, out decimal amountPayedOut)
        {
            amountPayedOut = 0;
            var account = accounts.FirstOrDefault(a => string.Equals(a.RekeningNummer, rekeningnummer));
            if (account == null)
            {
                return false;
            }
            if (account.Status == AccountStatus.Geblokkeerd)
            {
                return false;
            }
            if (withdrawAmount < 0)
            {
                throw new ArgumentException("You cannot withdraw negative amounts");
            }
            amountPayedOut = account.Bedrag >= withdrawAmount
                ? withdrawAmount
                : account.Bedrag;
            var transactionOk = account.WithDrawFunds(withdrawAmount) || account.WithDrawMaximunAvailable();
            if (transactionOk)
            {
                return true;
            }
            else
            {
                withdrawAmount = 0;
                return false;
            }
        }
        public int WithDrawFunds(string accountNumber, int amount)
        {
            if (TryWithDrawFunds(accountNumber, amount, out var aivalableForWithdraw))
            {
                return Convert.ToInt32(aivalableForWithdraw);
            }
            return 0;
        }
        public void ChangeState(string accountNumber, AccountStatus newState)
        {
            var account = accounts.FirstOrDefault(a => string.Equals(a.RekeningNummer, accountNumber));
            if (account == null)
            {
                throw new Exception("Account met dit nummer bestaat niet");
            }
            account.Status = newState;
        }
    }
}
