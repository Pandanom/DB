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
    public partial class AddingForm : Form
    {

        
        ManagerSqlRepository msr;
        public AddingForm()
        {
            InitializeComponent();
            DataContext db = new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            msr = new ManagerSqlRepository(db);
            Reset();
          
          //  ManagersLB.DataSource = db.GetTable<>
        }
        void Reset()
        {
            var mgs = msr.GetList();
            List<string> names = new List<string>();
            foreach (var m in mgs)
                names.Add(m.FullName);
            ManagersLB.DataSource = names;



            PassWBox.ForeColor = Color.Gray;
            PassWBox.GotFocus += TBGotFocus;
            LoginBox.ForeColor = Color.Gray;
            LoginBox.GotFocus += TBGotFocus;
            NameBox.ForeColor = Color.Gray;
            NameBox.GotFocus += TBGotFocus;
            NameBox.Text = "Full Name...";
            LoginBox.Text = "Login...";
            PassWBox.Text = "Password...";
            void TBGotFocus(object sender, EventArgs e)
            {

                TextBox tb = (TextBox)sender;
                tb.Text = "";
                tb.ForeColor = Color.Black;
        
            }
        }

        private async Task AddManager()
        {
            if (NameBox.Text == "" || LoginBox.Text == "" || PassWBox.Text == "")
            {
                StatusLbl.Text = "Fill all data";
                await Task.Delay(500);
                StatusLbl.Text = "";
                return;
            }
            else if (NameBox.Text == "Full Name..." || LoginBox.Text == "Login..." || PassWBox.Text == "Password...")
            {
                StatusLbl.Text = "Fill all data";
                await Task.Delay(1000);
                StatusLbl.Text = "";
                return;
            }
            Manager mng = new Manager();
            mng.FullName = NameBox.Text;
            mng.login = LoginBox.Text;
            mng.password = PasswordChecker.GetHash(PassWBox.Text);
            mng.isAdmin = IsAdminChB.Checked;
            mng.wrongTrys = 0;
            mng.isBlocked = BlockChb.Checked;
            msr.Add(mng);
            Reset();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            await AddManager();
          //  Reset();
            ////////////
            
        }

        private  void ManChoosed(object sender, EventArgs e)
        {
            var mgs = msr.GetList();
            Manager cm = null;

            foreach (var m in mgs)
              if (m.FullName == ManagersLB.SelectedValue.ToString())
                {
                    cm = m;
                    break;
                }
            NameBox.Text= cm.FullName;
             LoginBox.Text = cm.login;
           PassWBox.Text = "Password...";
            IsAdminChB.Checked = cm.isAdmin;
           
            BlockChb.Checked = cm.isBlocked;

        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || LoginBox.Text == "" || PassWBox.Text == "")
            {
                StatusLbl.Text = "Fill all data";
                await Task.Delay(500);
                StatusLbl.Text = "";
                return;
            }
            else if (NameBox.Text == "Full Name..." || LoginBox.Text == "Login..." || PassWBox.Text == "Password...")
            {
                StatusLbl.Text = "Fill all data";
                await Task.Delay(1000);
                StatusLbl.Text = "";
                return;
            }
            var mgs = msr.GetList();
           

            foreach (var m in mgs)
                if (m.FullName == ManagersLB.SelectedValue)
                {
                    m.FullName = NameBox.Text;
                    m.login = LoginBox.Text;
                    m.password = PasswordChecker.GetHash(PassWBox.Text);
                    m.isAdmin = IsAdminChB.Checked;
                    m.isBlocked = BlockChb.Checked;
                    if (!BlockChb.Checked)
                        m.wrongTrys = 0;
                    msr.Save();
                    Reset();
                    return;
                }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var mgs = msr.GetList();
            Manager cm = null;

            foreach (var m in mgs)
                if (m.FullName == ManagersLB.SelectedValue)
                {
                    cm = m;
                    break;
                }
            msr.Delete(cm.id);
            Reset();
        }
    }
}
