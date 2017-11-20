/*
 * RealEstateProfitCalculator
 * J.Thatcher
 * Simple Console App to calculate earning from real estate property
 * Class, Fields, Properties, Methods, Overloaded Constructor, etc.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProfitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double annualTaxAmount = 0.00d;
            double monthlyTaxAmount = 0.00d;
            double annualInsurance = 0.00d;
            double monthlyInsurance = 0.00d;

            RealEstateInvestment myRE = new RealEstateInvestment("101 1st Street", 1993, 235647);
            Console.WriteLine("Property Information");
            Console.WriteLine("Address: " + myRE.StreetAddress);
            Console.WriteLine("Year Built: " + myRE.YearBuilt.ToString());
            Console.WriteLine("Purchase Price: " + myRE.PurchasePrice.ToString("C2"));


            Console.WriteLine("\n");
            Console.Write("Please Enter Income From Rent: ");
            myRE.IncomeFromRent = double.Parse(Console.ReadLine());

            Console.Write("Please Enter Annual Tax Amount: ");
            annualTaxAmount = double.Parse(Console.ReadLine());
            monthlyTaxAmount = annualTaxAmount / 12;

            Console.Write("Please Enter Annual Insurance Amount: ");
            annualInsurance = double.Parse(Console.ReadLine());
            monthlyInsurance = annualInsurance / 12;

            myRE.MonthlyExpense = monthlyInsurance + monthlyTaxAmount;

            Console.Write("\n");
            Console.WriteLine("Real Estate Investment Summary");

            Console.WriteLine("Monthly Income: " + myRE.IncomeFromRent.ToString("C2"));
            Console.WriteLine("Monthly Expense: " + myRE.MonthlyExpense.ToString("C2"));
            Console.WriteLine("Monthly Earnings: " + myRE.GetMonthlyEarnings().ToString("C2"));

            Console.ReadLine();
        }
    }
}
