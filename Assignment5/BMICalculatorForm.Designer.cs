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
            this.MetricLabel = new System.Windows.Forms.Label();
            this.MetricHeight = new System.Windows.Forms.Label();
            this.HeightInCm = new System.Windows.Forms.TextBox();
            this.MetricWeight = new System.Windows.Forms.Label();
            this.WeightInKG = new System.Windows.Forms.TextBox();
            this.ImperialLabel = new System.Windows.Forms.Label();
            this.ImperialHeight = new System.Windows.Forms.Label();
            this.ImperialWeight = new System.Windows.Forms.Label();
            this.HeightInFT = new System.Windows.Forms.TextBox();
            this.WeightInLBS = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIResult = new System.Windows.Forms.Label();
            this.RangeResult = new System.Windows.Forms.Label();
            this.HeightInIN = new System.Windows.Forms.TextBox();
            this.HeightCM = new System.Windows.Forms.Label();
            this.WeightKG = new System.Windows.Forms.Label();
            this.HeightFT = new System.Windows.Forms.Label();
            this.HeightIN = new System.Windows.Forms.Label();
            this.WeightLBS = new System.Windows.Forms.Label();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.ResultTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetricLabel
            // 
            this.MetricLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricLabel.AutoSize = true;
            this.MetricLabel.BackColor = System.Drawing.Color.DarkRed;
            this.MetricTableLayoutPanel.SetColumnSpan(this.MetricLabel, 3);
            this.MetricLabel.ForeColor = System.Drawing.Color.White;
            this.MetricLabel.Location = new System.Drawing.Point(3, 0);
            this.MetricLabel.Name = "MetricLabel";
            this.MetricLabel.Size = new System.Drawing.Size(288, 41);
            this.MetricLabel.TabIndex = 0;
            this.MetricLabel.Text = "Metric";
            this.MetricLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetricHeight
            // 
            this.MetricHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricHeight.AutoSize = true;
            this.MetricHeight.BackColor = System.Drawing.Color.Transparent;
            this.MetricHeight.Location = new System.Drawing.Point(3, 41);
            this.MetricHeight.Name = "MetricHeight";
            this.MetricHeight.Size = new System.Drawing.Size(141, 40);
            this.MetricHeight.TabIndex = 1;
            this.MetricHeight.Text = "Height:";
            this.MetricHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeightInCm
            // 
            this.HeightInCm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightInCm.BackColor = System.Drawing.Color.Snow;
            this.HeightInCm.Location = new System.Drawing.Point(150, 44);
            this.HeightInCm.Name = "HeightInCm";
            this.HeightInCm.Size = new System.Drawing.Size(82, 67);
            this.HeightInCm.TabIndex = 2;
            // 
            // MetricWeight
            // 
            this.MetricWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricWeight.AutoSize = true;
            this.MetricWeight.BackColor = System.Drawing.Color.Transparent;
            this.MetricWeight.Location = new System.Drawing.Point(3, 81);
            this.MetricWeight.Name = "MetricWeight";
            this.MetricWeight.Size = new System.Drawing.Size(141, 42);
            this.MetricWeight.TabIndex = 3;
            this.MetricWeight.Text = "Weight:";
            this.MetricWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightInKG
            // 
            this.WeightInKG.BackColor = System.Drawing.Color.Snow;
            this.WeightInKG.Location = new System.Drawing.Point(150, 84);
            this.WeightInKG.Name = "WeightInKG";
            this.WeightInKG.Size = new System.Drawing.Size(82, 67);
            this.WeightInKG.TabIndex = 4;
            // 
            // ImperialLabel
            // 
            this.ImperialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialLabel.AutoSize = true;
            this.ImperialLabel.BackColor = System.Drawing.Color.Navy;
            this.ImperialTableLayoutPanel.SetColumnSpan(this.ImperialLabel, 3);
            this.ImperialLabel.ForeColor = System.Drawing.Color.White;
            this.ImperialLabel.Location = new System.Drawing.Point(3, 0);
            this.ImperialLabel.Name = "ImperialLabel";
            this.ImperialLabel.Size = new System.Drawing.Size(288, 41);
            this.ImperialLabel.TabIndex = 5;
            this.ImperialLabel.Text = "Imperial";
            this.ImperialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImperialHeight
            // 
            this.ImperialHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialHeight.AutoSize = true;
            this.ImperialHeight.BackColor = System.Drawing.Color.Transparent;
            this.ImperialHeight.Location = new System.Drawing.Point(3, 41);
            this.ImperialHeight.Name = "ImperialHeight";
            this.ImperialHeight.Size = new System.Drawing.Size(141, 41);
            this.ImperialHeight.TabIndex = 6;
            this.ImperialHeight.Text = "Height:";
            this.ImperialHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImperialWeight
            // 
            this.ImperialWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialWeight.AutoSize = true;
            this.ImperialWeight.BackColor = System.Drawing.Color.Transparent;
            this.ImperialWeight.Location = new System.Drawing.Point(3, 123);
            this.ImperialWeight.Name = "ImperialWeight";
            this.ImperialWeight.Size = new System.Drawing.Size(141, 41);
            this.ImperialWeight.TabIndex = 7;
            this.ImperialWeight.Text = "Weight:";
            this.ImperialWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeightInFT
            // 
            this.HeightInFT.Location = new System.Drawing.Point(150, 44);
            this.HeightInFT.Name = "HeightInFT";
            this.HeightInFT.Size = new System.Drawing.Size(82, 67);
            this.HeightInFT.TabIndex = 8;
            // 
            // WeightInLBS
            // 
            this.WeightInLBS.Location = new System.Drawing.Point(150, 126);
            this.WeightInLBS.Name = "WeightInLBS";
            this.WeightInLBS.Size = new System.Drawing.Size(82, 67);
            this.WeightInLBS.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(3, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(141, 35);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkGreen;
            this.ResultTableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(150, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 35);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMIResult
            // 
            this.BMIResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResult.AutoSize = true;
            this.BMIResult.BackColor = System.Drawing.Color.Transparent;
            this.ResultTableLayoutPanel.SetColumnSpan(this.BMIResult, 3);
            this.BMIResult.Location = new System.Drawing.Point(3, 41);
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.Size = new System.Drawing.Size(288, 40);
            this.BMIResult.TabIndex = 12;
            this.BMIResult.Text = "Your BMI is ";
            this.BMIResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RangeResult
            // 
            this.RangeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RangeResult.AutoSize = true;
            this.RangeResult.BackColor = System.Drawing.Color.Transparent;
            this.ResultTableLayoutPanel.SetColumnSpan(this.RangeResult, 3);
            this.RangeResult.Location = new System.Drawing.Point(3, 81);
            this.RangeResult.Name = "RangeResult";
            this.RangeResult.Size = new System.Drawing.Size(288, 42);
            this.RangeResult.TabIndex = 13;
            this.RangeResult.Text = "Your weight is";
            this.RangeResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightInIN
            // 
            this.HeightInIN.Location = new System.Drawing.Point(150, 85);
            this.HeightInIN.Name = "HeightInIN";
            this.HeightInIN.Size = new System.Drawing.Size(82, 67);
            this.HeightInIN.TabIndex = 14;
            // 
            // HeightCM
            // 
            this.HeightCM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightCM.AutoSize = true;
            this.HeightCM.BackColor = System.Drawing.Color.Transparent;
            this.HeightCM.Location = new System.Drawing.Point(238, 41);
            this.HeightCM.Name = "HeightCM";
            this.HeightCM.Size = new System.Drawing.Size(53, 40);
            this.HeightCM.TabIndex = 15;
            this.HeightCM.Text = "cm";
            this.HeightCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeightKG
            // 
            this.WeightKG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightKG.AutoSize = true;
            this.WeightKG.BackColor = System.Drawing.Color.Transparent;
            this.WeightKG.Location = new System.Drawing.Point(238, 81);
            this.WeightKG.Name = "WeightKG";
            this.WeightKG.Size = new System.Drawing.Size(53, 42);
            this.WeightKG.TabIndex = 16;
            this.WeightKG.Text = "kg";
            this.WeightKG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightFT
            // 
            this.HeightFT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightFT.AutoSize = true;
            this.HeightFT.BackColor = System.Drawing.Color.Transparent;
            this.HeightFT.Location = new System.Drawing.Point(238, 41);
            this.HeightFT.Name = "HeightFT";
            this.HeightFT.Size = new System.Drawing.Size(53, 41);
            this.HeightFT.TabIndex = 17;
            this.HeightFT.Text = "ft";
            this.HeightFT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightIN
            // 
            this.HeightIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightIN.AutoSize = true;
            this.HeightIN.BackColor = System.Drawing.Color.Transparent;
            this.HeightIN.Location = new System.Drawing.Point(238, 82);
            this.HeightIN.Name = "HeightIN";
            this.HeightIN.Size = new System.Drawing.Size(53, 41);
            this.HeightIN.TabIndex = 18;
            this.HeightIN.Text = "in";
            this.HeightIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WeightLBS
            // 
            this.WeightLBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLBS.AutoSize = true;
            this.WeightLBS.BackColor = System.Drawing.Color.Transparent;
            this.WeightLBS.Location = new System.Drawing.Point(238, 123);
            this.WeightLBS.Name = "WeightLBS";
            this.WeightLBS.Size = new System.Drawing.Size(53, 41);
            this.WeightLBS.TabIndex = 19;
            this.WeightLBS.Text = "lbs";
            this.WeightLBS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.BackColor = System.Drawing.Color.MistyRose;
            this.MetricTableLayoutPanel.ColumnCount = 3;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MetricTableLayoutPanel.Controls.Add(this.MetricLabel, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.WeightInKG, 1, 2);
            this.MetricTableLayoutPanel.Controls.Add(this.MetricWeight, 0, 2);
            this.MetricTableLayoutPanel.Controls.Add(this.HeightInCm, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MetricHeight, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.HeightCM, 2, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.WeightKG, 2, 2);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 3;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(294, 123);
            this.MetricTableLayoutPanel.TabIndex = 1;
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.ImperialTableLayoutPanel.ColumnCount = 3;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightInFT, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialHeight, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightFT, 2, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightLBS, 2, 3);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightInLBS, 1, 3);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialWeight, 0, 3);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightInIN, 1, 2);
            this.ImperialTableLayoutPanel.Controls.Add(this.HeightIN, 2, 2);
            this.ImperialTableLayoutPanel.Controls.Add(this.ImperialLabel, 0, 0);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(0, 123);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 4;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(294, 164);
            this.ImperialTableLayoutPanel.TabIndex = 2;
            // 
            // ResultTableLayoutPanel
            // 
            this.ResultTableLayoutPanel.BackColor = System.Drawing.Color.LightYellow;
            this.ResultTableLayoutPanel.ColumnCount = 3;
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ResultTableLayoutPanel.Controls.Add(this.ResetButton, 1, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.BMIResult, 0, 1);
            this.ResultTableLayoutPanel.Controls.Add(this.CalculateButton, 0, 0);
            this.ResultTableLayoutPanel.Controls.Add(this.RangeResult, 0, 2);
            this.ResultTableLayoutPanel.Location = new System.Drawing.Point(0, 287);
            this.ResultTableLayoutPanel.Name = "ResultTableLayoutPanel";
            this.ResultTableLayoutPanel.RowCount = 3;
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.ResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ResultTableLayoutPanel.Size = new System.Drawing.Size(294, 123);
            this.ResultTableLayoutPanel.TabIndex = 3;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(294, 409);
            this.Controls.Add(this.ResultTableLayoutPanel);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.ResultTableLayoutPanel.ResumeLayout(false);
            this.ResultTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label MetricLabel;
        private System.Windows.Forms.Label MetricHeight;
        private System.Windows.Forms.TextBox HeightInCm;
        private System.Windows.Forms.Label MetricWeight;
        private System.Windows.Forms.TextBox WeightInKG;
        private System.Windows.Forms.Label ImperialLabel;
        private System.Windows.Forms.Label ImperialHeight;
        private System.Windows.Forms.Label ImperialWeight;
        private System.Windows.Forms.TextBox HeightInFT;
        private System.Windows.Forms.TextBox WeightInLBS;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label BMIResult;
        private System.Windows.Forms.Label RangeResult;
        private System.Windows.Forms.TextBox HeightInIN;
        private System.Windows.Forms.Label HeightCM;
        private System.Windows.Forms.Label WeightKG;
        private System.Windows.Forms.Label HeightFT;
        private System.Windows.Forms.Label HeightIN;
        private System.Windows.Forms.Label WeightLBS;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ResultTableLayoutPanel;
    }
}

