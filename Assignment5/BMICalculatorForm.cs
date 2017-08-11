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
 Version: 0.6 - Added the _showScaleResult method
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
        private bool _isValid;
        private double _result;

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

        public bool IsValid
        {
            get
            {
                return this._isValid;
            }
            set
            {
                this._isValid = value;
            }
        }

        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value; 
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
                this.IsValid = true;
            }
            catch (Exception exception)
            {
                HeightTextBox.BackColor = this.ErrorColor;
                this.IsValid = false;
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
                this.IsValid = true;
            }
            catch (Exception exception)
            {
                WeightTextBox.BackColor = this.ErrorColor;
                this.IsValid = false;
            }
        }

        /// <summary>
        /// This is the event handler for when CalculateBMIButton clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            BMIResultTextBox.Text = string.Empty;
            ScaleResultTextLabel.Text = string.Empty;
            this._validation();
            if(this.IsValid)
            {
                this._calculate();
                this._showScaleResult();
            }
        }

        /// <summary>
        /// This method shows the scale result depending on the BMI calculated
        /// </summary>
        private void _showScaleResult()
        {
            if(this.Result < 18.5)
            {
                ScaleResultTextLabel.Text = "Underweight";
                ScaleResultTextLabel.ForeColor = Color.FromArgb(30, 144, 255);
            }
            else if(this.Result < 25)
            {
                ScaleResultTextLabel.Text = "Normal";
                ScaleResultTextLabel.ForeColor = Color.FromArgb(50, 205, 50);
            }
            else if(this.Result < 30)
            {
                ScaleResultTextLabel.Text = "Overweight";
                ScaleResultTextLabel.ForeColor = Color.FromArgb(255, 200, 0);
            }
            else
            {
                ScaleResultTextLabel.Text = "Obese";
                ScaleResultTextLabel.ForeColor = Color.FromArgb(220, 20, 60);
            }
        }
        /// <summary>
        /// This method calculates the BMI
        /// </summary>
        private void _calculate()
        {
            if (ImperialRadioButton.Checked)
            {
                this.Result = this.WeightValue * 703 / this.HeightValue / this.HeightValue;
            }
            else if (MetricRadioButton.Checked)
            {
                this.Result = this.WeightValue / this.HeightValue / this.HeightValue;
            }
            BMIResultTextBox.Text = this.Result.ToString();
        }

        /// <summary>
        /// This method validates the user input
        /// </summary>
        private void _validation()
        {
            if(HeightTextBox.Text == string.Empty)
            {
                HeightTextBox.BackColor = this.ErrorColor;
                this.IsValid = false;
            }
            if(WeightTextBox.Text == string.Empty)
            {
                WeightTextBox.BackColor = this.ErrorColor;
                this.IsValid = false;
            }
        }

        /// <summary>
        /// This is the event handler for when reset button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this._reset();
        }

        /// <summary>
        /// This method resets all input
        /// </summary>
        private void _reset()
        {
            HeightTextBox.Text = string.Empty;
            HeightTextBox.BackColor = this.NomalColor;
            WeightTextBox.Text = string.Empty;
            WeightTextBox.BackColor = this.NomalColor;
            ScaleResultTextLabel.Text = string.Empty;
            BMIResultTextBox.Text = string.Empty;
            this.IsValid = true;
        }

        /// <summary>
        /// This is the event handler for when the BMI calculator loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this._reset();
        }
    }
}
