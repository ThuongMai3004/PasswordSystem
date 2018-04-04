using PasswordSystem.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordSystem
{
    /**
     * <summary>
     * LoginMany form is used for Part 3 
     * It will display 3 parts Email, Banking and Shopping
     * Each part will pass appropriate value to the login form using 2nd constructor
     * </summary>
     */

    public partial class LoginManyForm : Form
    {
        public int shopAttempt = 3, bankAttempt = 3, emailAttempt = 3;
        
        public LoginManyForm()
        {
            InitializeComponent();
            ReadWriteFiles.ReadAccountFile(Model.emailAccountFile);
            UpdateUserName("svp" + --Model.Count);
            RandomizeGroupBox();
        }

        //Simple function to shuffle 3 parts Email, Shopping and Banking each time user opens the form
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

        //Login button handler for Shopping
        private void loginShopBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, Model.UserName, "Shopping", Model.shoppingAccountFile, shopAttempt);
            loginForm.Show();
        }

        //Login button handler for Banking
        private void loginBankBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this, Model.UserName, "Banking", Model.bankAccountFile, bankAttempt);
            loginForm.Show();
        }

        //Login button handler for Email
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

        /*
         * Will be called if user closes this form
         * it will check if user has tried to login all the parts and give warning
         */ 
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
