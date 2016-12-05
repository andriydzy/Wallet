using System;

namespace Wallet
{
    public class Money : IMoney
    {
        public double MoneyCount { get; set; }

        public double CountMoney()
        {
            return MoneyCount;
        }

        public bool GetMoney(double count)
        {
            if (count > MoneyCount)
                return false;
            else
            {
                MoneyCount -= count;
                return true;
            }
        }

        public bool SetMoney(double count)
        {
            if (count > 0)
                MoneyCount += count;
            else return false;
            return true;
        }
    }
    public class CreditCard : ICreditCard
    {
        public IMoney money { get; set; }
        private double Balance { get; set; }
        public bool GetCredit(double count)
        {
            if (count <= 20000)
            {
                Balance -= count;
                return true;
            }
                
            else return false;
        }
        
        public bool PayOffCredit(double count)
        {
            if (count > 0)
            {
                Balance += count;
                return true;
            }
               
            else return false;
        }
       
        public CreditCard()
        {
            money = new Money();
        }
    }
    public class BuisnesCard:IBuisnesCard
    {
        public BuisnesCard()
        {
            money = new Money();
            creditCard = new CreditCard();
        }

        public IMoney money { get; set; }
        public ICreditCard creditCard { get; set; }
        void IBuisnesCard.GetCreditMoney(double count)
        {
            creditCard.GetCredit(count);
        }
    }
}