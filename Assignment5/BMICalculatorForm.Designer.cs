namespace Assignment5
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMICaluculatorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.ScaleResultLabel = new System.Windows.Forms.Label();
            this.ScaleResultTextLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.BMICaluculatorTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICaluculatorTableLayout
            // 
            this.BMICaluculatorTableLayout.ColumnCount = 2;
            this.BMICaluculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICaluculatorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICaluculatorTableLayout.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMICaluculatorTableLayout.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMICaluculatorTableLayout.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICaluculatorTableLayout.Controls.Add(this.CalculateBMIButton, 0, 5);
            this.BMICaluculatorTableLayout.Controls.Add(this.WeightLabel, 0, 3);
            this.BMICaluculatorTableLayout.Controls.Add(this.WeightTextBox, 0, 4);
            this.BMICaluculatorTableLayout.Controls.Add(this.HeightTextBox, 0, 2);
            this.BMICaluculatorTableLayout.Controls.Add(this.HeightUnitLabel, 1, 2);
            this.BMICaluculatorTableLayout.Controls.Add(this.WeightUnitLabel, 1, 4);
            this.BMICaluculatorTableLayout.Controls.Add(this.BMIResultLabel, 0, 6);
            this.BMICaluculatorTableLayout.Controls.Add(this.ScaleResultLabel, 0, 7);
            this.BMICaluculatorTableLayout.Controls.Add(this.ScaleResultTextLabel, 0, 8);
            this.BMICaluculatorTableLayout.Controls.Add(this.ResetButton, 1, 5);
            this.BMICaluculatorTableLayout.Controls.Add(this.BMIResultTextBox, 1, 6);
            this.BMICaluculatorTableLayout.Location = new System.Drawing.Point(0, -1);
            this.BMICaluculatorTableLayout.Name = "BMICaluculatorTableLayout";
            this.BMICaluculatorTableLayout.RowCount = 9;
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.BMICaluculatorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.BMICaluculatorTableLayout.Size = new System.Drawing.Size(293, 413);
            this.BMICaluculatorTableLayout.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(140, 39);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(149, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(141, 39);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.BMICaluculatorTableLayout.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Location = new System.Drawing.Point(3, 45);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(265, 45);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(43, 93);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 67);
            this.HeightTextBox.TabIndex = 4;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(43, 183);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 67);
            this.WeightTextBox.TabIndex = 5;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Navy;
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 228);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(140, 39);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.BMICaluculatorTableLayout.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(3, 135);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(277, 45);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(149, 90);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(125, 45);
            this.HeightUnitLabel.TabIndex = 8;
            this.HeightUnitLabel.Text = "inches";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(149, 180);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(114, 45);
            this.WeightUnitLabel.TabIndex = 9;
            this.WeightUnitLabel.Text = "pounds";
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Location = new System.Drawing.Point(3, 270);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(138, 45);
            this.BMIResultLabel.TabIndex = 10;
            this.BMIResultLabel.Text = "Your BMI";
            // 
            // ScaleResultLabel
            // 
            this.ScaleResultLabel.AutoSize = true;
            this.BMICaluculatorTableLayout.SetColumnSpan(this.ScaleResultLabel, 2);
            this.ScaleResultLabel.Location = new System.Drawing.Point(3, 315);
            this.ScaleResultLabel.Name = "ScaleResultLabel";
            this.ScaleResultLabel.Size = new System.Drawing.Size(234, 45);
            this.ScaleResultLabel.TabIndex = 11;
            this.ScaleResultLabel.Text = "Your weight is";
            // 
            // ScaleResultTextLabel
            // 
            this.ScaleResultTextLabel.AutoSize = true;
            this.BMICaluculatorTableLayout.SetColumnSpan(this.ScaleResultTextLabel, 2);
            this.ScaleResultTextLabel.Location = new System.Drawing.Point(3, 360);
            this.ScaleResultTextLabel.Name = "ScaleResultTextLabel";
            this.ScaleResultTextLabel.Size = new System.Drawing.Size(0, 53);
            this.ScaleResultTextLabel.TabIndex = 12;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Navy;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(149, 228);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 39);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.Location = new System.Drawing.Point(149, 273);
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(100, 67);
            this.BMIResultTextBox.TabIndex = 14;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(294, 409);
            this.Controls.Add(this.BMICaluculatorTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICaluculatorTableLayout.ResumeLayout(false);
            this.BMICaluculatorTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICaluculatorTableLayout;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.Label ScaleResultLabel;
        private System.Windows.Forms.Label ScaleResultTextLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox BMIResultTextBox;
    }
}

