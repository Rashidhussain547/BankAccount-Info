using System;
// Encapsulation
namespace AccountInformation
{
    class personDetails
    {
        private int AccountNumber; 
        private string AccountTitle ="";
        private int DepositAmount;
        private int WithdrawAmount;
        private int AccountBalance;

        public void Accountdetailset(int AccountNumber , string AccountTitle)
        {
            if (AccountNumber <0)
            {
                Console.WriteLine("Account number is invalid!!!!!!!!!!");
            }
            else if (string.IsNullOrEmpty(AccountTitle))
            {
                Console.WriteLine("Account title is required!!!!!!!!!");
            }
            else
            {
                this.AccountNumber = AccountNumber;
                this.AccountTitle = AccountTitle;
            }
                
        }
        public void Accountdetailget()
        {
            if (this.AccountNumber < 0)
            {
            }
            else if (string.IsNullOrEmpty(this.AccountTitle))
            {   
            }
            else
            {
                Console.WriteLine("Account number is: {0}", this.AccountNumber);
                Console.WriteLine("Account title is: {0}", this.AccountTitle);
            }

        }
        public void DepositAmountset(int DepositAmount)
        {
            if(DepositAmount < 0) 
            {
                Console.WriteLine("Amount should be in positive!!!!!!!!!");
            }
            else
            {
                this.DepositAmount = DepositAmount;
            }
        }
        public void DepositAmountget()
        {
            if (DepositAmount < 0)
            {
            }
            else
            {
                Console.WriteLine("Your account BALANCE IS : {0}",this.DepositAmount);
            }
        }
        public void WithdrawAmountset(int WithdrawAmount)
        {
            if (WithdrawAmount > DepositAmount)
            {
                Console.WriteLine("You have sufficient balance!!!!!!!!");
            }
            else
            {
                this.WithdrawAmount = WithdrawAmount;
            }
        }
        public void WithdrawAmountget()
        {
            if (this.WithdrawAmount > this.DepositAmount)
            {
            }
            else
            {
                Console.WriteLine("Withdraw amount is : {0}", this.WithdrawAmount);
            }
            
        }
        public void AccountBalanceget()                             // Readonly method
        {
            this.AccountBalance =  DepositAmount - WithdrawAmount;
            Console.WriteLine("Your account balance after withdraw is : {0}", this.AccountBalance);
        }
    }
    class Tester
    {
        public static void Main(string[] args)
        {
            personDetails p = new personDetails();
            p.Accountdetailset(35445764 , "MuhammadRashidhussain"); // write data
            p.Accountdetailget();
            p.DepositAmountset(30000);
            p.DepositAmountget();
            p.WithdrawAmountset(10000);
            p.WithdrawAmountget();
            p.AccountBalanceget();
            Console.ReadKey();

        }

    }
}