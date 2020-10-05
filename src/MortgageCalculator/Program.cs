using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    // THIS WINFORMS APPLICATION USES THE (M)ODEL (V)IEW (P)RESENTER PATTERN
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MortgageModel Model = new MortgageModel();                           // Creates Object for MODEL
            MainForm View = new MainForm();                                     // Creates Object for VIEW
            MortgagePresenter Presenter = new MortgagePresenter(View, Model);  // Creates Object for PRESENTER and passes references to the interfaces of the VIEW and MODEL as parameters.
                                                                              // WITH THE OBJECTS INSTANTIATED HERE, THE MODEL AND VIEW ARE ONLY AWARE OF THEMSELVES. THE PRESENTER HAS REFERENCES TO BOTH'S INTERFACES
            Application.Run(View);                                           // Creates the Message Loop and makes the VIEW's MainForm visible.
        }
    }
}
