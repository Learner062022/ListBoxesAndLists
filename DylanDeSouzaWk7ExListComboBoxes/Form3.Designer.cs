namespace DylanDeSouzaWk7ExListComboBoxes
{
    partial class Form3
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
            this.btnNumberNames = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnDeleteName = new System.Windows.Forms.Button();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnSortList = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lblCurrentNames = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNumberNames
            // 
            this.btnNumberNames.Location = new System.Drawing.Point(189, 76);
            this.btnNumberNames.Name = "btnNumberNames";
            this.btnNumberNames.Size = new System.Drawing.Size(108, 34);
            this.btnNumberNames.TabIndex = 0;
            this.btnNumberNames.Text = "Display the number of list names";
            this.btnNumberNames.UseVisualStyleBackColor = true;
            this.btnNumberNames.Click += new System.EventHandler(this.btnNumberNames_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(189, 118);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(108, 23);
            this.btnAddName.TabIndex = 1;
            this.btnAddName.Text = "Add the name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnDeleteName
            // 
            this.btnDeleteName.Location = new System.Drawing.Point(189, 147);
            this.btnDeleteName.Name = "btnDeleteName";
            this.btnDeleteName.Size = new System.Drawing.Size(108, 34);
            this.btnDeleteName.TabIndex = 2;
            this.btnDeleteName.Text = "Delete the Entered name";
            this.btnDeleteName.UseVisualStyleBackColor = true;
            this.btnDeleteName.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(189, 187);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(108, 36);
            this.btnRemoveName.TabIndex = 3;
            this.btnRemoveName.Text = "Remove the name Selected";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(189, 229);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(108, 23);
            this.btnSortList.TabIndex = 4;
            this.btnSortList.Text = "Sort the List";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Items.AddRange(new object[] {
            "Spencer Ryan",
            "Smith John",
            "Johns Adam",
            "Patrick Lynch",
            "Pari Khoob"});
            this.lstNames.Location = new System.Drawing.Point(303, 50);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 199);
            this.lstNames.TabIndex = 5;
            // 
            // lblCurrentNames
            // 
            this.lblCurrentNames.AutoSize = true;
            this.lblCurrentNames.Location = new System.Drawing.Point(318, 34);
            this.lblCurrentNames.Name = "lblCurrentNames";
            this.lblCurrentNames.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentNames.TabIndex = 6;
            this.lblCurrentNames.Text = "Current Names";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(206, 34);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(72, 13);
            this.lblEnterName.TabIndex = 7;
            this.lblEnterName.Text = "Enter a Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.lblCurrentNames);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.btnDeleteName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.btnNumberNames);
            this.Name = "Form3";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumberNames;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnDeleteName;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lblCurrentNames;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtName;
    }
}