namespace DylanDeSouzaWk7ExListComboBoxes
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
            this.btnShowCost = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTravelCost = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtNumberTravellers = new System.Windows.Forms.TextBox();
            this.lblNumberOfTravellers = new System.Windows.Forms.Label();
            this.lblPerthToSydney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstTravelMethods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowCost
            // 
            this.btnShowCost.Location = new System.Drawing.Point(235, 156);
            this.btnShowCost.Name = "btnShowCost";
            this.btnShowCost.Size = new System.Drawing.Size(75, 23);
            this.btnShowCost.TabIndex = 0;
            this.btnShowCost.Text = "Show Cost";
            this.btnShowCost.UseVisualStyleBackColor = true;
            this.btnShowCost.Click += new System.EventHandler(this.btnShowCost_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(235, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTravelCost
            // 
            this.lblTravelCost.AutoSize = true;
            this.lblTravelCost.Location = new System.Drawing.Point(249, 264);
            this.lblTravelCost.Name = "lblTravelCost";
            this.lblTravelCost.Size = new System.Drawing.Size(61, 13);
            this.lblTravelCost.TabIndex = 2;
            this.lblTravelCost.Text = "Travel Cost";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(361, 257);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(100, 20);
            this.txtCharge.TabIndex = 3;
            // 
            // txtNumberTravellers
            // 
            this.txtNumberTravellers.Location = new System.Drawing.Point(361, 108);
            this.txtNumberTravellers.Name = "txtNumberTravellers";
            this.txtNumberTravellers.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTravellers.TabIndex = 4;
            // 
            // lblNumberOfTravellers
            // 
            this.lblNumberOfTravellers.AutoSize = true;
            this.lblNumberOfTravellers.Location = new System.Drawing.Point(250, 115);
            this.lblNumberOfTravellers.Name = "lblNumberOfTravellers";
            this.lblNumberOfTravellers.Size = new System.Drawing.Size(105, 13);
            this.lblNumberOfTravellers.TabIndex = 5;
            this.lblNumberOfTravellers.Text = "Number of Travellers";
            // 
            // lblPerthToSydney
            // 
            this.lblPerthToSydney.AutoSize = true;
            this.lblPerthToSydney.Location = new System.Drawing.Point(310, 78);
            this.lblPerthToSydney.Name = "lblPerthToSydney";
            this.lblPerthToSydney.Size = new System.Drawing.Size(82, 13);
            this.lblPerthToSydney.TabIndex = 6;
            this.lblPerthToSydney.Text = "Perth to Sydney";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select the Travel Method";
            // 
            // lstTravelMethods
            // 
            this.lstTravelMethods.FormattingEnabled = true;
            this.lstTravelMethods.Items.AddRange(new object[] {
            "Bus",
            "Train",
            "Plane"});
            this.lstTravelMethods.Location = new System.Drawing.Point(341, 156);
            this.lstTravelMethods.Name = "lstTravelMethods";
            this.lstTravelMethods.Size = new System.Drawing.Size(120, 95);
            this.lstTravelMethods.TabIndex = 8;
            this.lstTravelMethods.SelectedIndexChanged += new System.EventHandler(this.lstTravelMethod_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTravelMethods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPerthToSydney);
            this.Controls.Add(this.lblNumberOfTravellers);
            this.Controls.Add(this.txtNumberTravellers);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.lblTravelCost);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShowCost);
            this.Name = "Form1";
            this.Text = "Fare Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCost;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTravelCost;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtNumberTravellers;
        private System.Windows.Forms.Label lblNumberOfTravellers;
        private System.Windows.Forms.Label lblPerthToSydney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstTravelMethods;
    }
}

