using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Money
    {
        public int amount { get; set; }
        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return money.amount == amount 
                   && this.GetType().Name.Equals(money.GetType().Name);
        }

    }
}
