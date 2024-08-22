using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Money : IExpression
    {
        public int amount { get; set; }
        protected string currency { get; set; }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return money.amount == amount
                   && Currency().Equals(money.Currency());
        }

        public override string ToString()
        {
            return $"{amount} {currency}";
        }

        public virtual IExpression Times(int multipler)
        {
            return new Money(amount * multipler, currency);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(amount / rate, to);
        }

        public string Currency()
        {
            return currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
