using System;

namespace Wallet
{
    public class Money : IMoney
    {
        public double MoneyCount { get; set; }
        /// <summary>
        /// цей метод показує кількість грошей в гаманці
        /// </summary>
        /// <returns>повертає кількість грошей</returns>
        public double CountMoney()
        {
            return MoneyCount;
        }
        /// <summary>
        /// цей метод бере гроші з гаманця
        /// </summary>
        /// <param name="count"></param>
        /// <returns>повертає можливість проведення данної транзакції</returns>
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
        /// <summary>
        /// цей метод кладе гроші в гаманець
        /// </summary>
        /// <param name="count"></param>
        /// <returns>повертає можливість проведення данної транзакції</returns>
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
        /// <summary>
        /// цим методом беремо в кредит суму "count"
        /// сума повинна бути менше 20000
        /// </summary>
        /// <param name="count"></param>
        /// <returns>чи можливо отримати кредит</returns>
        public bool GetCredit(double count)
        {
            if (count <= 20000)
            {
                Balance -= count;
                return true;
            }
                
            else return false;
        }
        /// <summary>
        /// цим методом повертаємо кредитні кошти
        /// </summary>
        /// <param name="count"></param>
        /// <returns>можливість проведення даної операції</returns>
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