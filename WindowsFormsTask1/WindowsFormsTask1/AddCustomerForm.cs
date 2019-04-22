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
using System.Configuration;

namespace WindowsFormsTask1
{
    public partial class AddCustomerForm : Form
    {
        DataContext db;
        List<TextBox> fields;
        int mId;
        public AddCustomerForm(int id)
        {
            InitializeComponent();
            mId = id;
            db = new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            fields = new List<TextBox>();
            fields.Add(NameTb);
            fields.Add(SNameTb);
            fields.Add(AgeTB);
            fields.Add(PNTB);
            fields.Add(CountyTB);
            fields.Add(TownTB);
            fields.Add(SumTB);
        }

        private bool CheckSum(int s)
        {
            var users = db.GetTable<User>();
            List<User> tU = new List<User>();
            foreach (var u in users)
                if (u.ManagerId == mId)
                    tU.Add(u);
            DateTime lastDT = DateTime.MinValue;
            foreach (var u in tU)
                if (u.RDate > lastDT)
                    lastDT = u.RDate;
            int sum = 0;
            int n = 0;
            foreach (var u in tU)
                if (u.RDate.Month == lastDT.Month && u.RDate.Year == lastDT.Year)
                {
                    sum += u.Sum;
                    n++;
                }
            if (n == 0)
                return true;
            else if (s < sum / n + 500)
                return true;
            else
            return false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
          

            foreach (var f in fields)
                if (f.Text == "")
                {
                    StatusLbl.Text = "Invalid Property";
                    return;
                }
            int age = 0;
            ulong pn = 0;
            int sum = 0;
            if (!int.TryParse(fields[2].Text, out age))
            {
                StatusLbl.Text = "Invalid Property";
                return;
            }
            if (!ulong.TryParse(fields[3].Text, out pn))
            {
                StatusLbl.Text = "Invalid Property";
                return;
            }
            if (!int.TryParse(fields[6].Text, out sum))
            {
                StatusLbl.Text = "Invalid Property";
                return;
            }
            if (!CheckSum(sum))
            {
                StatusLbl.Text = "Invalid Sum";
                return;
            }
            User u = new User();
            u.Age = age;
            u.Name = fields[0].Text;
            u.Surname = fields[1].Text;
            u.PhNum = pn;
            u.Country = fields[4].Text;
            u.Town = fields[5].Text;
            u.RDate = DateTime.Now;
            u.Sum = sum;
            u.ManagerId = mId;
            db.GetTable<User>().InsertOnSubmit(u);
            db.SubmitChanges();
            foreach (var f in fields)
                f.Text = "";
            StatusLbl.Text = "Customer Added Successfully";
            
        }
    }
}
