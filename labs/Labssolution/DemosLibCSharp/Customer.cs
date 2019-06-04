using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosLibCSharp
{
    public class Customer
    {
        public string Name { get; set; }
        public Decimal YearlySalary { get; set; }
        public int ProfessionalExperience { get; set; }
        public bool SociallyFit { get; set; }
        public bool CriminalRecord { get; set; }
        public int YearlyTrainings { get; set; }

        public static List<Func<Customer, bool>> GetCriteria()
        {
            return new List<Func<Customer, bool>>
            {
                customer => customer.CriminalRecord,
                customer => customer.YearlySalary.CompareTo(60000) < 0,
                customer => !customer.SociallyFit,
                customer => customer.YearlyTrainings < 2,
                customer => customer.ProfessionalExperience < 3

            };
        }


    }
}
