using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Wallet
    {
        double money;
        public Wallet(double Money)
        {
            this.money = Money;
        }
        public double Money
        { get { return this.money; } }
        public double ChangeMoney
        { set { this.money = value; } }

    }
}
