using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemosLibCSharp;

namespace DemosConsoleCSharp
{
    public class LoanRequestAssessment
    {
        public static void assessLoanRequests()
        {
            Customer customer = getCustomer();
            if (LoanRecommender.ShouldOfferLoanTo(customer))
            {
                Console.WriteLine("Customer " + customer.Name + " should receive the loan");
            }
            else
            {
                Console.WriteLine("Customer " + customer.Name + " should be refused the loan");

            }
        }

        private static Customer getCustomer()
        {
            return new Customer
            {
                Name = "Martin Aljabbar",
                YearlySalary = 48500.5M,
                CriminalRecord = false,
                ProfessionalExperience = 3,
                SociallyFit = false,
                YearlyTrainings = 1
            };
        }
    }
}
