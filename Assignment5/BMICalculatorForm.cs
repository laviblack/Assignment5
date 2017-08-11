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
 Version: 0.3 - Added the event handler to validate the input
     */

namespace Assignment5
{
    public partial class BMICalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private Color _errorColor = Color.FromArgb(255, 228, 225);
        private Color _nomalColor = Color.FromArgb(255, 255, 255);
        private double _height;
        private double _weight;

        // PUBLIC PROPERTIES
        public Color ErrorColor
        {
            get
            {
                return this._errorColor;
            }
        }

        public Color NomalColor
        {
            get
            {
                return this._nomalColor;
            }
        }

        public double HeightValue
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        public double WeightValue
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        // CONSTRUCTOR
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for when imperial radio button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "inches";
            WeightUnitLabel.Text = "pounds";
        }

        /// <summary>
        /// This is the event handler for when metric radio button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "meters";
            WeightUnitLabel.Text = "kilograms";
        }
        
        /// <summary>
        /// This is the event handler to validate the input when height value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = this.NomalColor;
                this.HeightValue = double.Parse(HeightTextBox.Text);
            }
            catch (Exception exception)
            {
                HeightTextBox.BackColor = this.ErrorColor;
            }
        }

        /// <summary>
        /// This is the event handler to validate the input when weight value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WeightTextBox.BackColor = this.NomalColor;
                this.WeightValue = double.Parse(WeightTextBox.Text);
            }
            catch (Exception exception)
            {
                WeightTextBox.BackColor = this.ErrorColor;
            }
        }
    }
}
