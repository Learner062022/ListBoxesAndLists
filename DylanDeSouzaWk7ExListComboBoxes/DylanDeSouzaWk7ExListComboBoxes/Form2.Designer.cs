namespace DylanDeSouzaWk7ExListComboBoxes
{
    partial class Form2
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
            this.lstTravelMethods = new System.Windows.Forms.ListBox();
            this.lblTravelMethods = new System.Windows.Forms.Label();
            this.lblPerthToSydney = new System.Windows.Forms.Label();
            this.lblNumberOfTravellers = new System.Windows.Forms.Label();
            this.txtNumberTravellers = new System.Windows.Forms.TextBox();
            this.txtTravelCost = new System.Windows.Forms.TextBox();
            this.lblTravelCost = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTravelMethods
            // 
            this.lstTravelMethods.FormattingEnabled = true;
            this.lstTravelMethods.Items.AddRange(new object[] {
            "Bus",
            "Train",
            "Plane"});
            this.lstTravelMethods.Location = new System.Drawing.Point(391, 204);
            this.lstTravelMethods.Name = "lstTravelMethods";
            this.lstTravelMethods.Size = new System.Drawing.Size(120, 95);
            this.lstTravelMethods.TabIndex = 17;
            this.lstTravelMethods.SelectedIndexChanged += new System.EventHandler(this.lstTravelMethods_SelectedIndexChanged);
            // 
            // lblTravelMethods
            // 
            this.lblTravelMethods.AutoSize = true;
            this.lblTravelMethods.Location = new System.Drawing.Point(388, 188);
            this.lblTravelMethods.Name = "lblTravelMethods";
            this.lblTravelMethods.Size = new System.Drawing.Size(127, 13);
            this.lblTravelMethods.TabIndex = 16;
            this.lblTravelMethods.Text = "Select the Travel Method";
            // 
            // lblPerthToSydney
            // 
            this.lblPerthToSydney.AutoSize = true;
            this.lblPerthToSydney.Location = new System.Drawing.Point(360, 126);
            this.lblPerthToSydney.Name = "lblPerthToSydney";
            this.lblPerthToSydney.Size = new System.Drawing.Size(82, 13);
            this.lblPerthToSydney.TabIndex = 15;
            this.lblPerthToSydney.Text = "Perth to Sydney";
            // 
            // lblNumberOfTravellers
            // 
            this.lblNumberOfTravellers.AutoSize = true;
            this.lblNumberOfTravellers.Location = new System.Drawing.Point(300, 163);
            this.lblNumberOfTravellers.Name = "lblNumberOfTravellers";
            this.lblNumberOfTravellers.Size = new System.Drawing.Size(105, 13);
            this.lblNumberOfTravellers.TabIndex = 14;
            this.lblNumberOfTravellers.Text = "Number of Travellers";
            // 
            // txtNumberTravellers
            // 
            this.txtNumberTravellers.Location = new System.Drawing.Point(411, 156);
            this.txtNumberTravellers.Name = "txtNumberTravellers";
            this.txtNumberTravellers.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTravellers.TabIndex = 13;
            // 
            // txtTravelCost
            // 
            this.txtTravelCost.Location = new System.Drawing.Point(411, 305);
            this.txtTravelCost.Name = "txtTravelCost";
            this.txtTravelCost.Size = new System.Drawing.Size(100, 20);
            this.txtTravelCost.TabIndex = 12;
            // 
            // lblTravelCost
            // 
            this.lblTravelCost.AutoSize = true;
            this.lblTravelCost.Location = new System.Drawing.Point(299, 312);
            this.lblTravelCost.Name = "lblTravelCost";
            this.lblTravelCost.Size = new System.Drawing.Size(61, 13);
            this.lblTravelCost.TabIndex = 11;
            this.lblTravelCost.Text = "Travel Cost";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(285, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTravelMethods);
            this.Controls.Add(this.lblTravelMethods);
            this.Controls.Add(this.lblPerthToSydney);
            this.Controls.Add(this.lblNumberOfTravellers);
            this.Controls.Add(this.txtNumberTravellers);
            this.Controls.Add(this.txtTravelCost);
            this.Controls.Add(this.lblTravelCost);
            this.Controls.Add(this.btnReset);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTravelMethods;
        private System.Windows.Forms.Label lblTravelMethods;
        private System.Windows.Forms.Label lblPerthToSydney;
        private System.Windows.Forms.Label lblNumberOfTravellers;
        private System.Windows.Forms.TextBox txtNumberTravellers;
        private System.Windows.Forms.TextBox txtTravelCost;
        private System.Windows.Forms.Label lblTravelCost;
        private System.Windows.Forms.Button btnReset;
    }
}