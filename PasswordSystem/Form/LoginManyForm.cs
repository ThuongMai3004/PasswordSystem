using PasswordSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSystem
{
    public partial class LoginManyForm : Form
    {
        public int shopAttempt = 3, bankAttempt = 3, emailAttempt = 3;
        
        public LoginManyForm()
        {
            //Logger.Log("-----Initialize LOGIN MANY PASSWORD FORM------", isInit: true);
            InitializeComponent();
            ReadWriteFiles.ReadAccountFile(Model.emailAccountFile);
            UpdateUserName("svp" + --Model.Count);
            RandomizeGroupBox();
        }

        private void RandomizeGroupBox()
        {
            Point temp1 = this.BankGroupBox.Location;
            Point temp2 = this.EmailGroupBox.Location;
            Point temp3 = this.ShopGroupBox.Location;

            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int t1 = rand.Next(0, 3);
            switch (t1)
            {
                case 0:
                    break;
                case 1:
                    this.BankGroupBox.Location = temp2;
                    this.EmailGroupBox.Location = temp3;
                    this.ShopGroupBox.Location = temp1;
                    break;
                case 2:
                    this.BankGroupBox.Location = temp3;
                    this.EmailGroupBox.Location = temp2;
                    this.ShopGroupBox.Location = temp1;
                    break;
            }
        }

        private void loginShopBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, Model.UserName, "Shopping", Model.shoppingAccountFile, shopAttempt);
            loginForm.Show();
        }

        private void loginBankBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, Model.UserName, "Banking", Model.bankAccountFile, bankAttempt);
            loginForm.Show();
        }

        private void loginEmailBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, Model.UserName, "Email", Model.emailAccountFile, emailAttempt);
            loginForm.Show();
        }

        private void UpdateUserName(string userName)
        {
            this.userLb.Text = userName;
            Model.UserName = userName;
        }

        public string StatusShop { set { this.statusShopLb.Text = value; } }
        public string StatusBank { set { this.statusBankLb.Text = value; } }
        public string StatusEmail { set { this.statusEmailLb.Text = value; } }
        public Button GetEmailBtn { get { return this.loginEmailBtn; } }
        public Button GetBankBtn { get { return this.loginBankBtn; } }
        public Button GetShopBtn { get { return this.loginShopBtn; } }

        private void LoginManyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.loginEmailBtn.Enabled || this.loginShopBtn.Enabled || this.loginBankBtn.Enabled)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to quit ?", "Warning", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                        e.Cancel = true;
                    else
                    {
                        Logger.Log("User [" + Model.UserName + "] quit the login form");
                        e.Cancel = false;
                    }
                }
            }
        }
    }
}
