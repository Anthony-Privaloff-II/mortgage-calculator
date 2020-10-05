using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    // VIEW CLASS / FORM CLASS
    public partial class MainForm : Form, IView 
    {
        //FIELDS
        //PROPERTIES
        public int Period { get; set; }
        public decimal Principal { get; set; }
        public decimal MortgageTotal { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal InterestRate { get; set; }

        public event EventHandler CalculateEvent;
        public event EventHandler ValidateEvent;
        public event EventHandler SaveEvent;
        public event EventHandler LoadEvent;

        //METHODS
        ////CONSTRUCTOR
        public MainForm()
        {
            this.Principal = 0;
            this.Period = 0;
            this.MortgageTotal = 0m;
            this.MonthlyPayment = 0m;
            this.InterestRate = 0m;
            InitializeComponent();
        }
        ////
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void UpdateData()    // Method the Presenter calls to have the View update its fields with the data in the UI.
        {
            this.Period = Int32.Parse(comboBoxPeriodInput.Text);
            this.Principal = decimal.Parse(textBoxMortgageAmountInput.Text);
            this.InterestRate = decimal.Parse(textBoxInterestRateInput.Text);
        }

        public void UpdateUI()   // Method the Presenter calls to update the data in the View's fields after the Model performs its back-end logic.
        {
            textBoxPrincipalOutput.Text = this.Principal.ToString();
            textBoxMortgageTotal.Text = this.MortgageTotal.ToString();
            textBoxPeriodOutput.Text = this.Period.ToString();
            textBoxMonthlyPayment.Text = this.MonthlyPayment.ToString();
            textBoxInterestRateOutput.Text = this.InterestRate.ToString();
        }

        //BUTTON CLICK EVENTS
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMortgageAmountInput.Text) && !string.IsNullOrWhiteSpace(textBoxInterestRateInput.Text))   // Very simple validation to make sure nulls aren't passed.
            {
                EventHandler Handler = this.CalculateEvent; // Assigning delegate to a temporary variable to snapshot value.
                Handler?.Invoke(this, EventArgs.Empty);    // Invokes the CalculateEvent EventHandler delegate in a thread-safe way using the null-conditional operator '?'.
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        // KEYPRESS EVENTS - Basic keystroke validation takes place below; this is better left to the UI handling before any input is made.
        private void textBoxMortgageAmount_KeyPress(object sender, KeyPressEventArgs e)  // Only allows digits and backspaces to be entered into textBox
        {
            if (!char.IsDigit(e.KeyChar))
                if(e.KeyChar != '\b')
                    e.Handled = true;
        }

        private void textBoxInterestRate_KeyPress(object sender, KeyPressEventArgs e)   // Only allows digits, backspaces and '.' to be entered into textBox
        {
            if (!char.IsDigit(e.KeyChar))
                if (e.KeyChar != '\b' && e.KeyChar != '.')
                    e.Handled = true;
        }

        private void comboBoxPeriod_KeyPress(object sender, KeyPressEventArgs e)    // Allows nothing to be entered into textBox
        {
            e.Handled = true;
        }

    }
}
