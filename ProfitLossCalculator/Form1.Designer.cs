namespace ProfitLossCalculator
{
    partial class Form1
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
            this.txtSharesSold = new System.Windows.Forms.TextBox();
            this.txtPricePerShare = new System.Windows.Forms.TextBox();
            this.txtSellDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCostPriceSoldShares = new System.Windows.Forms.Label();
            this.lblGainLoss = new System.Windows.Forms.Label();
            this.lblRemainingShares = new System.Windows.Forms.Label();
            this.lblCostPriceRemainingShares = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSharesSold
            // 
            this.txtSharesSold.Location = new System.Drawing.Point(218, 29);
            this.txtSharesSold.MaxLength = 10;
            this.txtSharesSold.Name = "txtSharesSold";
            this.txtSharesSold.Size = new System.Drawing.Size(100, 20);
            this.txtSharesSold.TabIndex = 0;
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.Location = new System.Drawing.Point(218, 55);
            this.txtPricePerShare.MaxLength = 15;
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerShare.TabIndex = 1;
            // 
            // txtSellDate
            // 
            this.txtSellDate.Location = new System.Drawing.Point(218, 81);
            this.txtSellDate.MaxLength = 10;
            this.txtSellDate.Name = "txtSellDate";
            this.txtSellDate.Size = new System.Drawing.Size(100, 20);
            this.txtSellDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shares Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price Per Share";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sell Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost Price of Sold Shares";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gain Loss on Sale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Remaining Shares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cost Price of Remaining Shares";
            // 
            // lblCostPriceSoldShares
            // 
            this.lblCostPriceSoldShares.AutoSize = true;
            this.lblCostPriceSoldShares.Location = new System.Drawing.Point(227, 225);
            this.lblCostPriceSoldShares.Name = "lblCostPriceSoldShares";
            this.lblCostPriceSoldShares.Size = new System.Drawing.Size(0, 13);
            this.lblCostPriceSoldShares.TabIndex = 10;
            // 
            // lblGainLoss
            // 
            this.lblGainLoss.AutoSize = true;
            this.lblGainLoss.Location = new System.Drawing.Point(227, 242);
            this.lblGainLoss.Name = "lblGainLoss";
            this.lblGainLoss.Size = new System.Drawing.Size(0, 13);
            this.lblGainLoss.TabIndex = 11;
            // 
            // lblRemainingShares
            // 
            this.lblRemainingShares.AutoSize = true;
            this.lblRemainingShares.Location = new System.Drawing.Point(227, 258);
            this.lblRemainingShares.Name = "lblRemainingShares";
            this.lblRemainingShares.Size = new System.Drawing.Size(0, 13);
            this.lblRemainingShares.TabIndex = 12;
            // 
            // lblCostPriceRemainingShares
            // 
            this.lblCostPriceRemainingShares.AutoSize = true;
            this.lblCostPriceRemainingShares.Location = new System.Drawing.Point(227, 274);
            this.lblCostPriceRemainingShares.Name = "lblCostPriceRemainingShares";
            this.lblCostPriceRemainingShares.Size = new System.Drawing.Size(0, 13);
            this.lblCostPriceRemainingShares.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(218, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "*Note: (-) indicates loss in Gain Loss on sale.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 354);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCostPriceRemainingShares);
            this.Controls.Add(this.lblRemainingShares);
            this.Controls.Add(this.lblGainLoss);
            this.Controls.Add(this.lblCostPriceSoldShares);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSellDate);
            this.Controls.Add(this.txtPricePerShare);
            this.Controls.Add(this.txtSharesSold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSharesSold;
        private System.Windows.Forms.TextBox txtPricePerShare;
        private System.Windows.Forms.TextBox txtSellDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCostPriceSoldShares;
        private System.Windows.Forms.Label lblGainLoss;
        private System.Windows.Forms.Label lblRemainingShares;
        private System.Windows.Forms.Label lblCostPriceRemainingShares;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
    }
}

