using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    // PRESENTER CLASS
    public class MortgagePresenter
    {
        //FIELDS
        private IView _view;    // The Presenter needs to be able to interact with the View so it will contains a references to its interface.
        private IModel _model;  // The Presenter needs to be able to interact with the Model so it will contains a references to its interface.

        //PROPERTIES
        public IView View
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
            }
        }
        public IModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        //METHODS

        ////CONSTRUCTOR
        public MortgagePresenter(IView view, IModel model)
        {
            this.View = view;
            this.Model = model;
            // Subscribing the Presenter's relevant methods to their associated Events:
            View.CalculateEvent += this.HandleCalculateEvent;
        }
        ////

        public void Calculate() // Will grab the data in the View and send it to the MODEL for calculation.
        {
            // The PRESENTER calls the VIEW's UpdateData() method which stores the data entered into the UI's controls.
            View.UpdateData();
            // The PRESENTER then calls the MODEL's Calculate(int,int,int) method to perform the back-end logic with data from the VIEW.
            Model.Calculate(View.Principal, View.Period, View.InterestRate);
            // The PRESENTER then calls its own UpdateView() method to update the VIEW with data from the MODEL.
            this.UpdateView();
        }

        public void UpdateView()
        {
            // The PRESENTER updates the data stored in the VIEW with the data stored in the MODEL
            View.Principal = Model.Principal;
            View.MortgageTotal = Model.MortgageTotal;
            View.Period = Model.Period;
            View.MonthlyPayment = Model.MonthlyPayment;
            View.InterestRate = Model.InterestRate;
            // The PRESENTER then calls the VIEW's UpdateUI() method which updates the data displayed in the form's controls on the UI.
            View.UpdateUI();
        }

        private void HandleCalculateEvent(object sender, EventArgs e) // Will be called when the "Calculate" event is raised from the view.
        {
            this.Calculate();
        }

        private void HandleValidateEvent(object sender, EventArgs e)
        {

        }

        private void HandleSaveEvent(object sender, EventArgs e)
        {

        }

        private void HandleLoadEvent(object sender, EventArgs e)
        {

        }

    }
}
