using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Plus(IExpression addend);
        IExpression Times(int multiplier);
    }
}
