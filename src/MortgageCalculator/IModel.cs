using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    // MODEL INTERFACE
    public interface IModel
    {
        int Period { get; set; }
        decimal Principal { get; set; }
        decimal MortgageTotal { get; set; }
        decimal MonthlyPayment { get; set; }
        decimal InterestRate { get; set; }

        void Calculate(decimal principal, int period, decimal interestRate);
    }
}
