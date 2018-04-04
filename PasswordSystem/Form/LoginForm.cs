using PasswordSystem.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordSystem
{
    /**
     * <summary>
     * LoginForm class is a class that handle login for the current user.
     * It has function to compare the input password with associated username to the database.
     * For Part 2 and Part 3, all the other functions are similar except the default constructor.
     * </summary>
     */
    public partial class LoginForm : Form
    {
        private string pathFileToRead = Model.accountFileName;
        private Label userLb = null;
        private Label statusLb = null;
        private int attempt = 3;
        private string whatPurpose = "Login Password";
        private LoginManyForm loginManyForm = null; //Only initialize in 2nd constructor (part 3)
        private bool lockButton = false; //used to give the signal to lock Login button of LoginMany form (Part 3)
        string user = null;

        /**
         * Default constructor
         * It will intialize the listBox and add the list to this box.
         * Used for Part 2
         */
        public LoginForm()
        {
            InitializeComponent();
            this.listUserBox.SelectionMode = SelectionMode.One;
            ReadWriteFiles.ReadAccountFile(pathFileToRead);
            AddToListBox();
        }

        /**
         * Constructor
         * Remove the list box in GUI, add user and status lables
         * Used for Part 3
         */
        public LoginForm(LoginManyForm _form, string userName, string WhatPurpose, string ReadThisFile, int _attempt = 0)
        {
            InitializeComponent();

            //Read the path file and save the data to Data/Model
            this.pathFileToRead = ReadThisFile;
            ReadWriteFiles.ReadAccountFile(pathFileToRead);

            this.titleLb.Text = "LOGIN FORM for " + WhatPurpose;
            this.userNameTitleLb.Text = "Username: ";
            this.whatPurpose = WhatPurpose;
            this.loginManyForm = _form;
            this.attempt = _attempt;

            //Remove the listBox from the Controls/UI
            this.Controls.Remove(this.listUserBox);

            //Initialize user label that displays username and add it to Controls
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

            //Initialize status label that displays username and add it to Controls
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

            //Logging
            Logger.Log(whatPurpose, 2);
        }

        /**
         * <summary>
         * Add the list of key from the account file to the List+Box.
         * </summary>
         */
        private void AddToListBox()
        {
            this.listUserBox.BeginUpdate();
            foreach (string n in Model.Accounts.Keys)
                this.listUserBox.Items.Add(n);
            this.listUserBox.EndUpdate();
        }

        /**
         * Login button handler.
         * Reponsible for getting the input password and username, then compare to the database.
         * Counting the number of failed login for part 3
         * Return fail if user has used all 3 attempts (part 3) and success if correctly
         */
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //If the password textbox is empty, ask user to enter password
            if (String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                MessageBox.Show("Please enter your password to login");
                return;
            }
            else
            {
                /* Seperate the difference for part 2 and 3.
                 * If controls contains userBox (listbox initialized in constructor - part 2), it will get the user from selected item
                 * else, it will get directly from the userLb that passed from the second constructor (part 3)
                 */ 
                if (this.Controls.Contains(this.listUserBox))
                    user = this.listUserBox.SelectedItem.ToString();
                else
                    user = this.userLb.Text;
                
                //Check the correctness of the password for this current user
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

                    //Only for part 3 - if statusLb has not been initalized, it will be equal to null
                    if (this.statusLb != null)
                        this.statusLb.Text = "(" + this.attempt + " attempts)";
                    if (this.attempt == 0)
                    {
                        this.statusLb.Text = "Failed to login";
                        Logger.Log("User [" + user + " ] failed to login. No more attempts");
                        this.lockButton = true;
                        this.Close();
                    }

                    //Call the clearBtn handler to clean the input password textbox
                    clearBtn_Click(sender, e);
                }
            }
        }

        //Clear button handler to clear the input password textbox
        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.passwordTxtBox.Clear();
        }

        /**
         * LoginForm closing button. 
         * It will be activated if the user close this form.
         * It will send back the status, attempts to the parent loginManyForm (Part 3 only)
         */
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //Only part 3 can do this
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
                    }
                    loginManyForm.Refresh();
                }
            }
        }
    }
}
