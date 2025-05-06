using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP
{
    public class Pank
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }
    }
}
