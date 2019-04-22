namespace WindowsFormsTask1
{
    partial class AddingForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassWBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.IsAdminChB = new System.Windows.Forms.CheckBox();
            this.ManagersLB = new System.Windows.Forms.ListBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BlockChb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(48, 108);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(167, 22);
            this.NameBox.TabIndex = 1;
            this.NameBox.Text = "Full Name...";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(48, 153);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(167, 22);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.Text = "Login...";
            // 
            // PassWBox
            // 
            this.PassWBox.Location = new System.Drawing.Point(48, 198);
            this.PassWBox.Name = "PassWBox";
            this.PassWBox.Size = new System.Drawing.Size(167, 22);
            this.PassWBox.TabIndex = 2;
            this.PassWBox.Text = "Password...";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.Location = new System.Drawing.Point(119, 235);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 61);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add Manager";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // IsAdminChB
            // 
            this.IsAdminChB.AutoSize = true;
            this.IsAdminChB.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IsAdminChB.Location = new System.Drawing.Point(227, 103);
            this.IsAdminChB.Name = "IsAdminChB";
            this.IsAdminChB.Size = new System.Drawing.Size(50, 38);
            this.IsAdminChB.TabIndex = 4;
            this.IsAdminChB.Text = "admin";
            this.IsAdminChB.UseVisualStyleBackColor = true;
            // 
            // ManagersLB
            // 
            this.ManagersLB.FormattingEnabled = true;
            this.ManagersLB.ItemHeight = 16;
            this.ManagersLB.Location = new System.Drawing.Point(360, 41);
            this.ManagersLB.Name = "ManagersLB";
            this.ManagersLB.Size = new System.Drawing.Size(152, 100);
            this.ManagersLB.TabIndex = 5;
            this.ManagersLB.MouseCaptureChanged += new System.EventHandler(this.ManChoosed);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(48, 246);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 17);
            this.StatusLbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditBtn.Location = new System.Drawing.Point(48, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(167, 36);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit Manager";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Location = new System.Drawing.Point(48, 45);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(167, 36);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete Manager";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BlockChb
            // 
            this.BlockChb.AutoSize = true;
            this.BlockChb.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BlockChb.Location = new System.Drawing.Point(221, 146);
            this.BlockChb.Name = "BlockChb";
            this.BlockChb.Size = new System.Drawing.Size(61, 38);
            this.BlockChb.TabIndex = 12;
            this.BlockChb.Text = "blocked";
            this.BlockChb.UseVisualStyleBackColor = true;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(544, 350);
            this.Controls.Add(this.BlockChb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.ManagersLB);
            this.Controls.Add(this.IsAdminChB);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PassWBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.NameBox);
            this.Name = "AddingForm";
            this.Text = "AddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassWBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.CheckBox IsAdminChB;
        private System.Windows.Forms.ListBox ManagersLB;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.CheckBox BlockChb;
    }
}