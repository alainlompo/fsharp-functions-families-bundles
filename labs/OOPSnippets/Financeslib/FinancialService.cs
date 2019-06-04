using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeslib
{
    public class FinancialService
    {
        public double computeInterest(double interestRate, double amount)
        {
            return amount * interestRate;
        }

        public double computeNewAmount(double interestRate, double amount)
        {
            return amount + computeInterest(interestRate, amount);
        }
    }
}
