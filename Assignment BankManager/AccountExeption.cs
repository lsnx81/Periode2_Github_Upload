using System.Runtime.Serialization;

namespace Assignment_BankManager
{
   
    internal class AccountExeption : Exception
    {
        

        public AccountExeption(string? message) : base(message)
        {

        }

    }
}