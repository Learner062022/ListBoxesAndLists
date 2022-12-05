namespace DylanDeSouzaEx7List
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
            this.btnAcceptProduct = new System.Windows.Forms.Button();
            this.btnProductsAbove = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lstProductsPrices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAcceptProduct
            // 
            this.btnAcceptProduct.Location = new System.Drawing.Point(175, 62);
            this.btnAcceptProduct.Name = "btnAcceptProduct";
            this.btnAcceptProduct.Size = new System.Drawing.Size(120, 23);
            this.btnAcceptProduct.TabIndex = 0;
            this.btnAcceptProduct.Text = "Accept Product";
            this.btnAcceptProduct.UseVisualStyleBackColor = true;
            this.btnAcceptProduct.Click += new System.EventHandler(this.btnAcceptProduct_Click);
            // 
            // btnProductsAbove
            // 
            this.btnProductsAbove.Location = new System.Drawing.Point(175, 91);
            this.btnProductsAbove.Name = "btnProductsAbove";
            this.btnProductsAbove.Size = new System.Drawing.Size(120, 23);
            this.btnProductsAbove.TabIndex = 1;
            this.btnProductsAbove.Text = "Products above $10";
            this.btnProductsAbove.UseVisualStyleBackColor = true;
            this.btnProductsAbove.Click += new System.EventHandler(this.btnProductsAbove_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(125, 17);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(138, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(175, 10);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(120, 20);
            this.txtProduct.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(175, 36);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // lstProductsPrices
            // 
            this.lstProductsPrices.FormattingEnabled = true;
            this.lstProductsPrices.Location = new System.Drawing.Point(175, 120);
            this.lstProductsPrices.Name = "lstProductsPrices";
            this.lstProductsPrices.Size = new System.Drawing.Size(120, 95);
            this.lstProductsPrices.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstProductsPrices);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnProductsAbove);
            this.Controls.Add(this.btnAcceptProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptProduct;
        private System.Windows.Forms.Button btnProductsAbove;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lstProductsPrices;
    }
}

