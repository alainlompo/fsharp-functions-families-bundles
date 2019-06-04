using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Financeslib;

namespace fcli
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Showcasing OOP's ceremonies");
            
            Console.WriteLine("Input the initial amount:");
            double initialAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Input interest rate");

            double interestRate = Double.Parse(Console.ReadLine());

            FinancialService financialService = new FinancialService();
            double interest = financialService.computeInterest(interestRate, initialAmount);
            double newAmount = financialService.computeNewAmount(interestRate, initialAmount);

            Console.WriteLine("The generate interest is: " + interest);
            Console.WriteLine("The new amount is: " + newAmount);

            Console.ReadKey();
        }
    }
}
