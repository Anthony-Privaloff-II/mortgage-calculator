using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    // VIEW INTERFACE
    public interface IView
    {
        int Period { get; set; }
        decimal Principal { get; set; }
        decimal MortgageTotal { get; set; }
        decimal MonthlyPayment { get; set; }
        decimal InterestRate { get; set; }

        // Events that are triggered by user interaction with the controls:
        event EventHandler CalculateEvent;  // Event triggered when buttonCalculate is pressed.
        event EventHandler ValidateEvent;  //
        event EventHandler SaveEvent;     // Event triggered when buttonSave is pressed.
        event EventHandler LoadEvent;    // Event triggered when buttonLoad is pressed.

        void UpdateData(); // Method the Presenter calls to have the View update its fields with the data in the UI.
        void UpdateUI();  // Method the Presenter calls to update the data in the View's fields after the Model performs its back-end logic.
    }
}