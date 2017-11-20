using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProfitCalculator
{
    class RealEstateInvestment
    {

        private int yearBuilt;
        private string streetAddress;
        private double purchasePrice;
        private double monthlyExpense;
        private double incomeFromRent;

        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public double PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }

        public double MonthlyExpense
        {
            get { return monthlyExpense; }
            set { monthlyExpense = value; }
        }

        public double IncomeFromRent
        {
            get { return incomeFromRent; }
            set { incomeFromRent = value; }
        }

        public RealEstateInvestment(string address, int year, double price)
        {
            StreetAddress = address;
            PurchasePrice = price;
            YearBuilt = year;
        }

        public RealEstateInvestment(int year, double price)
        {
            YearBuilt = year;
            PurchasePrice = price;

        }

        public RealEstateInvestment(string address, double price)
        {
            StreetAddress = address;
            PurchasePrice = price;
        }

        public double GetMonthlyEarnings()
        {
            return incomeFromRent - monthlyExpense;
        }
    }
}
