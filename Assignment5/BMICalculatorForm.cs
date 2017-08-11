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
 Version: 0.2 - Added RadioButtons' CheckedChanged methods
     */

namespace Assignment5
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "inches";
            WeightUnitLabel.Text = "pounds";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "meters";
            WeightUnitLabel.Text = "kilograms";
        }
    }
}
