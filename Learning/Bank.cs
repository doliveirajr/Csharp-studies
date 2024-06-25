namespace Bank
{
    public class BankAccount
    {
        string firstName_, lastName_;
        decimal balance_;
        public BankAccount(string fName, string lName, decimal balance = 0.0m)
        {
            firstName_ = fName;
            lastName_ = lName;
            Balance = balance;
        }

        public decimal Balance
        {
            set => balance_ += value;
            get => balance_;
        }

        public string AccountOwner
        {
            get => firstName_ + " " + lastName_;
        }

        public void Deposit(decimal amount)
        {
            balance_ += amount;
        }

        public virtual bool Withdraw(decimal amount)
        {
            balance_ -= amount;
            return true;
        }
    }

    public class CheckingAcct(string fName, string lName, decimal balance = 0.0m) : BankAccount(fName, lName, balance)
    {
        public override bool Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
            {
                Balance = Balance - amount - 35;
                return true;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }

    public class SavingsAcct(string fName, string lName, decimal interestRate) : BankAccount(fName, lName)
    {
        decimal interestRate_ = interestRate;
        int tentatives = 0;

        public decimal InterestRate
        {
            get => interestRate_;
            set => interestRate_ = value;
        }

        public void ApplyInterest()
        {
            Balance = Balance * interestRate_;
        }

        public override bool Withdraw(decimal amount)
        {

            if (Balance - amount < 0)
            {
                return false;
            }
            else
            {
                if (tentatives <= 3)
                {
                    Balance -= amount;
                    return true;
                }
                else
                {
                    Balance = Balance - amount - 2;
                    return true;
                }
            }
        }

    }
}