using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            int rate = rates[new Pair(from, to)];
            return rate;
        }
        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }
    }
}
