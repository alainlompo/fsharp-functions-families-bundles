using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosLibCSharp
{
    public class LoanRecommender
    {
        public static bool ShouldOfferLoanTo(Customer customer)
        {
            int failedCriteriasCount = Customer.GetCriteria().Count(criteria => criteria(customer));
            return failedCriteriasCount <= 1;
        }
    }
}
