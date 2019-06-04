using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeslib
{
    public class EnhancedFinancialService
    {
        public double computeNewAmount(double interestRate, double amount, IFinanciable interestCalculator)
        {
            return amount + interestCalculator.computeInterest(interestRate, amount);
        }
    }
}
