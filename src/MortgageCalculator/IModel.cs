using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    // MODEL INTERFACE
    public interface IModel
    {
        string RowName { get; set; }
        int Period { get; set; }
        decimal Principal { get; set; }
        decimal MortgageTotal { get; set; }
        decimal MonthlyPayment { get; set; }
        decimal InterestRate { get; set; }
        BindingSource DropDownDataSource { get; set; } // Object to encapsulate the DataSource for the "Load" drop down list.

        void Calculate(decimal principal, int period, decimal interestRate);
        void PopulateNames();
    }
}
