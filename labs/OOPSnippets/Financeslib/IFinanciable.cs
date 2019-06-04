using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeslib
{
    public interface IFinanciable
    {
        double computeInterest(double interestRate, double amount);
    }
}
