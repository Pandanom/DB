using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsTask1
{
    public partial class CustomersForm : Form
    {
        Manager cm;
        string connectionString;
        static string[] coll = { "id","Name","Surname","Age","Registration Date","Phone Number","Country","Town","Manager","Sum"};
        List<CheckBox> checkColls;
        List<Manager> managers;
        ManagerSqlRepository mnr;
        DataContext db;
        public CustomersForm()
        {
            InitializeComponent();
       
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            checkColls = new List<CheckBox>();
          
            db = new DataContext(connectionString);
                 mnr = new ManagerSqlRepository(db);
            managers = mnr.GetList().ToList();
            List<string> logins = new List<string>();
            foreach (var m in managers)
                logins.Add(m.login);
            LoginBox.DataSource = logins;

            bool waterMarkActive = true;
            PassWBox.ForeColor = Color.Gray;
            PassWBox.GotFocus += (s, e) =>
            {
                if (waterMarkActive)
                {
                    waterMarkActive = false;
                    PassWBox.Text = "";
                    PassWBox.ForeColor = Color.Black;
                }
            };

          

            LoginBox.SelectedIndexChanged += (s, e) =>
            {
                checkTry();
            };



            int x=30;
            foreach (var c in coll)
            {
                CheckBox cb = new CheckBox();
                cb.Text = c;
                cb.Location = new Point(x, 25);
                x += cb.Size.Width;
                cb.Checked = true;
               
                cb.Visible = false;
                checkColls.Add(cb);
                this.Controls.Add(cb);
                cb.CheckedChanged += (s, e) => {
                    CustTable.Columns.Clear();
                    ShowDb();
                };
                
            }
            
            ShowDb();
        }

        bool checkTry()
        {
            cm = null;
            foreach (var m in managers)
                if (m.login == LoginBox.Text)
                {
                    cm = m;
                    break;
                }
            if (cm.wrongTrys >= 3)
            {
                PassWBox.Text = "User Blocked";
                PassWBox.ReadOnly = true;
                return false;
            }
            else
            {
                if (PassWBox.Text == "User Blocked")
                    PassWBox.Text = "";
                PassWBox.ReadOnly = false;
                return true;
            }
        }

        private void ShowDb()
        {
            CustTable.Rows.Clear();
            CustTable.Columns.Clear();
            CustTable.Refresh();
            for (int i = 0; i < checkColls.Count; i++)
                if(checkColls[i].Checked)
                    CustTable.Columns.Add(coll[i],coll[i]);
            
    
            Table<User> users = db.GetTable<User>();
            foreach (var user in users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(CustTable);
                int j = 0;
                for (int i = 0; i < checkColls.Count; i++)
                    if (checkColls[i].Checked)
                    {
                        if(i ==8)
                            row.Cells[j].Value =mnr.GetItem(int.Parse( user.GetCell(i))).FullName;
                        else
                        row.Cells[j].Value = user.GetCell(i);
                        j++;
                    }
                CustTable.Rows.Add(row);
            }
            CustTable.Refresh();


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!checkTry())
                return;


            cm = null;
            foreach (var m in managers)
                if (m.login == LoginBox.Text)
                {
                    cm = m;
                    break;
                }
            if (cm == null)
                return;

            if(PasswordChecker.Check( PassWBox.Text,cm.password))
            {
                PassWBox.Visible = false;
                foreach (var chB in checkColls)
                    chB.Visible = true;
                CustTable.Visible = true;
                AddCustBtn.Visible = true;
                LoginBox.Visible = false;
                LoginBtn.Visible = false;
                sowChB.Visible = false;
                this.Text = cm.FullName;
                if (cm.isAdmin)
                    AddBtn.Visible = true;

                mnr.GetItem(cm.id).wrongTrys = 0;
                mnr.Save();
                       
            }
            else
            {

                mnr.GetItem(cm.id).wrongTrys++;
                mnr.Save();

                checkTry();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form f = new AddingForm();
            f.Show();
            f.FormClosed += (s, ev) => { this.Show(); };
            this.Hide();
        }

        private void sowChB_CheckedChanged(object sender, EventArgs e)
        {
            if (sowChB.Checked)
                PassWBox.PasswordChar = '\0';
            else
                PassWBox.PasswordChar = '•';
            
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Form f = new AddCustomerForm(cm.id);
            f.Show();
            f.FormClosed += (s, ev) => { this.Show(); ShowDb(); };
            this.Hide();
        }
    }
}
