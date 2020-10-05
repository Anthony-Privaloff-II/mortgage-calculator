using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    // MODEL CLASS
    public class MortgageModel : IModel
    {
        //FIELDS
        private int _period;
        private decimal _principal;
        private decimal _mortgageTotal;
        private decimal _monthlyPayment;
        private decimal _interestRate;

        //PROPERTIES
        public int Period
        {
            get
            {
                return _period;
            }
            set
            {
                _period = value;
            }
        }
        public decimal Principal
        {
            get
            {
                return _principal;
            }
            set
            {
                _principal = value;
            }
        }
        public decimal MortgageTotal
        {
            get
            {
                return _mortgageTotal;
            }
            set
            {
                _mortgageTotal = value;
            }
        }
        public decimal MonthlyPayment
        {
            get
            {
                return _monthlyPayment;
            }
            set
            {
                _monthlyPayment = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                _interestRate = value;
            }
        }

        //METHODS
        ////CONSTRUCTOR
        public MortgageModel()
        {
            this.Principal = 0;
            this.MortgageTotal = 0;
            this.Period = 0;
            this.InterestRate = 0;
            this.MonthlyPayment = 0;
        }
        ////
        // This method performs the basic back-end calculations that determine the MonthlyPayment and MortgageTotal.
        public void Calculate(decimal principal, int period, decimal interestRate)
        {
            //public void Validate();

            this.Principal = principal;
            this.Period = period;
            this.InterestRate = interestRate;
            
            double MonthlyInterestRate = ((double) this.InterestRate / 100) / 12;                 // First we find out the monthly interest rate.
            int TotalPeriods = this.Period * 12;                                                 // Then we find out the total amount of monthly payments for the mortgage.
                                                                                                // Formulas for determining Total Mortgage and Monthly Payments below.
            this.MonthlyPayment = (decimal) (this.Principal * ( (decimal) (MonthlyInterestRate * Math.Pow(1 + MonthlyInterestRate, TotalPeriods))) / (decimal) (Math.Pow(1 + MonthlyInterestRate, TotalPeriods) - 1));
            this.MortgageTotal = this.MonthlyPayment * TotalPeriods;

            this.MonthlyPayment = Decimal.Round(this.MonthlyPayment, 2);                     // Rounding the decimals to 2 decimal places for proper currency format.
            this.MortgageTotal = Decimal.Round(this.MortgageTotal, 2);
        }

        private void Validate()  // Method for the Model to perform the more complicated validations needed after the basic UI validations in the View.
        {

        }

    }
}