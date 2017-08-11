using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Name: Lyrica Yoshida
 ID: 300923951
 Date: August 11, 2017
 Description: Assignment 5 - BMI Calculator Project 
 Version: 0.1 - Created the instance of the BMICalculatorForm object
     */


namespace Assignment5
{
    static class Program
    {
        // Create Reference to Forms
        public static BMICalculatorForm BMIcalculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BMIcalculatorForm = new BMICalculatorForm();
            // instantiate a new object of type BMICalculatorForm

            Application.Run(new SplashForm());
        }
    }
}
