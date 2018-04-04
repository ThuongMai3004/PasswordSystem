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
    public partial class LoginForm : Form
    {
        private string pathFileToRead = Model.accountFileName;
        private Label userLb = null;
        private Label statusLb = null;
        private int attempt = 3;
        private string whatPurpose = "Login Password";
        private LoginManyForm loginManyForm = null;
        private bool lockButton = false;
        string user = null;

        public LoginForm()
        {
            InitializeComponent();
            //Logger.Log("------INITIALIZE LOGIN FORM-----", isInit: true);
            this.listUserBox.SelectionMode = SelectionMode.One;
            ReadWriteFiles.ReadAccountFile(pathFileToRead);
            AddToListBox();
        }

        public LoginForm(LoginManyForm _form, string userName, string WhatPurpose, string ReadThisFile, int _attempt = 0)
        {
            InitializeComponent();
            //Logger.Log("------INITIALIZE LOGIN FORM for " + WhatPurpose, isInit: true);
            this.pathFileToRead = ReadThisFile;
            ReadWriteFiles.ReadAccountFile(pathFileToRead);
            this.titleLb.Text = "LOGIN FORM for " + WhatPurpose;
            this.Controls.Remove(this.listUserBox);
            this.userNameTitleLb.Text = "Username: ";
            this.whatPurpose = WhatPurpose;
            this.loginManyForm = _form;
            this.attempt = _attempt;
            this.userLb = new Label
            {
                Font = new Font("Microsoft Sans Serif", 8.25f),
                Text = userName,
                AutoSize = true,
                Location = new Point(70, 39),
                ForeColor = Color.NavajoWhite,
                BackColor = Color.Transparent,
            };
            this.user = userName;
            this.userLb.Show();
            this.Controls.Add(this.userLb);

            this.statusLb = new Label
            {
                Font = new Font("Microsoft Sans Serif", 10f),
                Text = "(" + attempt + " attempts)",
                AutoSize = true,
                Location = new Point(12, 72),
                ForeColor = Color.NavajoWhite,
                BackColor = Color.Transparent,
            };
            this.statusLb.Show();
            this.Controls.Add(this.statusLb);
            Logger.Log(whatPurpose, 2);
        }

        private void AddToListBox()
        {
            this.listUserBox.BeginUpdate();
            foreach (string n in Model.Accounts.Keys)
                this.listUserBox.Items.Add(n);
            this.listUserBox.EndUpdate();
            //Logger.Log("Finished adding the user list to the list box");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                MessageBox.Show("Please enter your password to login");
                return;
            }
            else
            {
                if (this.Controls.Contains(this.listUserBox))
                    user = this.listUserBox.SelectedItem.ToString();
                else
                    user = this.userLb.Text;
                if (Model.CheckPasswordForAccount(user, this.passwordTxtBox.Text))
                {
                    MessageBox.Show("You login successfully");
                    if (this.statusLb != null)
                        this.statusLb.Text = "Successfully logged in";
                    Logger.Log("User [" + user + "] has logged in successfully using password [" + this.passwordTxtBox.Text + "] at the " + (4 - this.attempt) + " times");
                    this.lockButton = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong password. Try again");
                    Logger.Log("User [" + user + "] has entered the wrong password for the " + (4 - this.attempt) + " times using password [" + this.passwordTxtBox.Text + "]. Correct password is [" + Model.ReturnPasswordForThisUser(user) + "]");
                    this.attempt--;
                    if (this.statusLb != null)
                        this.statusLb.Text = "(" + this.attempt + " attempts)";
                    if (this.attempt == 0)
                    {
                        this.statusLb.Text = "Failed to login";
                        Logger.Log("User [" + user + " ] failed to login. No more attempts");
                        this.lockButton = true;
                        this.Close();
                    }
                    clearBtn_Click(sender, e);
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.passwordTxtBox.Clear();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (loginManyForm != null)
                {
                    if (!this.lockButton)
                    {
                        Logger.Log("User [" + user + "] closed the [" + whatPurpose + "] login form without logging in");
                    }
                    switch (this.whatPurpose)
                    {
                        case "Email":
                            loginManyForm.StatusEmail = this.statusLb.Text;
                            loginManyForm.emailAttempt = this.attempt;
                            loginManyForm.GetEmailBtn.Enabled = this.lockButton ? false : true;
                            break;
                        case "Shopping":
                            loginManyForm.StatusShop = this.statusLb.Text;
                            loginManyForm.shopAttempt = this.attempt;
                            loginManyForm.GetShopBtn.Enabled = this.lockButton ? false : true;
                            break;
                        case "Banking":
                            loginManyForm.StatusBank = this.statusLb.Text;
                            loginManyForm.bankAttempt = this.attempt;
                            loginManyForm.GetBankBtn.Enabled = this.lockButton ? false : true;
                            break;
                        loginManyForm.Refresh();
                    }
                }
            }
        }
    }
}
