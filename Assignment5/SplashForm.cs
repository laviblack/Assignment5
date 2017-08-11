using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Name: Lyrica Yoshida
 ID: 300923951
 Date: August 11, 2017
 Description: Assignment 5 - BMI Calculator Project 
 Version: 0.1 - Created the SplashForm
     */

namespace Assignment5
{
    public partial class SplashForm : Form
    {
        // PUBLIC PROPERTIES
        public BMICalculatorForm BMICalculatorForm
        {
            get
            {
                return Program.BMIcalculatorForm;
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculatorForm.Show();

            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }
    }
}
