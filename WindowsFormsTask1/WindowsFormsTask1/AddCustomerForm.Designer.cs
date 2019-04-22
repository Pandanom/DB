namespace WindowsFormsTask1
{
    partial class AddCustomerForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.SNameTb = new System.Windows.Forms.TextBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.PNTB = new System.Windows.Forms.TextBox();
            this.CountyTB = new System.Windows.Forms.TextBox();
            this.TownTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SumTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBtn.Location = new System.Drawing.Point(297, 173);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(95, 64);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add Customer";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(64, 38);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(149, 22);
            this.NameTb.TabIndex = 9;
            // 
            // SNameTb
            // 
            this.SNameTb.Location = new System.Drawing.Point(64, 83);
            this.SNameTb.Name = "SNameTb";
            this.SNameTb.Size = new System.Drawing.Size(149, 22);
            this.SNameTb.TabIndex = 10;
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(64, 128);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(149, 22);
            this.AgeTB.TabIndex = 11;
            // 
            // PNTB
            // 
            this.PNTB.Location = new System.Drawing.Point(64, 173);
            this.PNTB.Name = "PNTB";
            this.PNTB.Size = new System.Drawing.Size(149, 22);
            this.PNTB.TabIndex = 12;
            // 
            // CountyTB
            // 
            this.CountyTB.Location = new System.Drawing.Point(64, 218);
            this.CountyTB.Name = "CountyTB";
            this.CountyTB.Size = new System.Drawing.Size(149, 22);
            this.CountyTB.TabIndex = 13;
            // 
            // TownTB
            // 
            this.TownTB.Location = new System.Drawing.Point(64, 263);
            this.TownTB.Name = "TownTB";
            this.TownTB.Size = new System.Drawing.Size(149, 22);
            this.TownTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Town";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(294, 128);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(0, 17);
            this.StatusLbl.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sum";
            // 
            // SumTB
            // 
            this.SumTB.Location = new System.Drawing.Point(64, 308);
            this.SumTB.Name = "SumTB";
            this.SumTB.Size = new System.Drawing.Size(149, 22);
            this.SumTB.TabIndex = 23;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.SumTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TownTB);
            this.Controls.Add(this.CountyTB);
            this.Controls.Add(this.PNTB);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.SNameTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.AddBtn);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox SNameTb;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox PNTB;
        private System.Windows.Forms.TextBox CountyTB;
        private System.Windows.Forms.TextBox TownTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SumTB;
    }
}