using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTaxOwed
{
    class Taxpayer
    {
        private string socialSNumber;
        private double yearlyIncome;
        private double taxOwed;
        public string SocialSNumber
        {
            get
            {
                return socialSNumber;
            }
            set
            {
                socialSNumber = value;
            }
        }
        public double YearlyIncome
        {
            get
            {
                return yearlyIncome;
            }
            set
            {
                yearlyIncome = value;
                CalcTax();
            }
        }
        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }
        private double CalcTax()
        {
            if (this.yearlyIncome < 30000)
            {
                taxOwed = yearlyIncome * 0.15;
            }
            if (this.yearlyIncome > 30000)
            {
                taxOwed = yearlyIncome * 0.28;
            }



            return taxOwed;
        }
    }
}
