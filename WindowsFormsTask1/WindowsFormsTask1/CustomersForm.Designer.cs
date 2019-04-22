namespace WindowsFormsTask1
{
    partial class CustomersForm
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
            this.CustTable = new System.Windows.Forms.DataGridView();
            this.PassWBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.sowChB = new System.Windows.Forms.CheckBox();
            this.AddCustBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CustTable
            // 
            this.CustTable.AllowUserToAddRows = false;
            this.CustTable.AllowUserToDeleteRows = false;
            this.CustTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CustTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustTable.GridColor = System.Drawing.Color.Gainsboro;
            this.CustTable.Location = new System.Drawing.Point(12, 82);
            this.CustTable.Name = "CustTable";
            this.CustTable.ReadOnly = true;
            this.CustTable.RowTemplate.Height = 24;
            this.CustTable.Size = new System.Drawing.Size(1359, 460);
            this.CustTable.TabIndex = 2;
            this.CustTable.Visible = false;
            // 
            // PassWBox
            // 
            this.PassWBox.Location = new System.Drawing.Point(588, 324);
            this.PassWBox.Name = "PassWBox";
            this.PassWBox.Size = new System.Drawing.Size(202, 22);
            this.PassWBox.TabIndex = 4;
            this.PassWBox.Text = "Pasword...";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Location = new System.Drawing.Point(644, 390);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(82, 37);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Log in";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBox.FormattingEnabled = true;
            this.LoginBox.Location = new System.Drawing.Point(588, 262);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(202, 24);
            this.LoginBox.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBtn.Location = new System.Drawing.Point(695, 554);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 64);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Edit managers";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // sowChB
            // 
            this.sowChB.AutoSize = true;
            this.sowChB.Checked = true;
            this.sowChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sowChB.Location = new System.Drawing.Point(620, 352);
            this.sowChB.Name = "sowChB";
            this.sowChB.Size = new System.Drawing.Size(128, 21);
            this.sowChB.TabIndex = 8;
            this.sowChB.Text = "Show password";
            this.sowChB.UseVisualStyleBackColor = true;
            this.sowChB.CheckedChanged += new System.EventHandler(this.sowChB_CheckedChanged);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddCustBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCustBtn.Location = new System.Drawing.Point(588, 554);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(95, 64);
            this.AddCustBtn.TabIndex = 9;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = false;
            this.AddCustBtn.Visible = false;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1383, 624);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.sowChB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassWBox);
            this.Controls.Add(this.CustTable);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.CustTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CustTable;
        private System.Windows.Forms.TextBox PassWBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.ComboBox LoginBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.CheckBox sowChB;
        private System.Windows.Forms.Button AddCustBtn;
    }
}

