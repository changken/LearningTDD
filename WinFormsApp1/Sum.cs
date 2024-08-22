using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Sum : IExpression
    {
        public IExpression Augend { get; set; }
        public IExpression Addend { get; set; }

        public Sum(IExpression augend, IExpression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(this.Augend.Times(multiplier), this.Addend.Times(multiplier));
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = this.Augend.Reduce(bank, to).amount + 
                         this.Addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
