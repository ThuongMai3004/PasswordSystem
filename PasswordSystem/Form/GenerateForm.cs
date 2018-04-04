using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using PasswordSystem.Data;
using System.Diagnostics;

namespace PasswordSystem
{
    public partial class GenerateForm : Form
    {
        ToolTip tooltip = new ToolTip();
        List<string> lines = File.ReadAllLines(Model.wordsFileName).ToList();
        Dictionary<string, string> accounts = new Dictionary<string, string>();
        HintForm hintForm = null;
        PracticeForm practiceForm = null;
        GenerateManyForm generateManyForm = null;
        string pathFileToSave = Model.accountFileName;
        string whatPurpose = "Creating Password";
        bool lockButton = false;

        public GenerateForm()
        {
            //Logger.Log("--- INITIALIZATION GENERATING PASSWORD FORM-----", isInit: true);
            InitializeComponent();
            InitializeToolTip();
            ReadWriteFiles.ReadAccountFile(pathFileToSave);
            UpdateUserName("svp" + Model.Count);
            UpdatePassword(String.Empty);
            //Logger.Log(this.userLb.Text, "Start creating password for this user");
        }

        public GenerateForm(string username, string _whatPurpose, string saveToThisFile, GenerateManyForm _form = null)
        {
            //Logger.Log("--- INITIALIZATION GENERATING PASSWORD FORM for " + whatPurpose + "-----", isInit: true);
            InitializeComponent();
            InitializeToolTip();
            UpdateUserName(username);
            UpdatePassword(String.Empty);
            this.pathFileToSave = saveToThisFile;
            this.whatPurpose = _whatPurpose;
            this.titleLb.Text = "Team 48 Password Scheme for " + _whatPurpose;
            this.generateManyForm = _form;
            //Logger.Log(this.userLb.Text, "Start creating password for this user");
            Logger.Log(whatPurpose, 2);
        }

        private void InitializeToolTip()
        {
            tooltip.ToolTipTitle = "Helpful: ";
            tooltip.AutoPopDelay = 10000;
            tooltip.SetToolTip(hintBtn, "Provide the key word to help user memorize the password easier");
            tooltip.SetToolTip(refreshBtn, "Provide another password to the user");
            tooltip.SetToolTip(practiceBtn, "Provide another form for user to practice the password");
            tooltip.SetToolTip(acceptBtn, "You accept the password for this user");
        }

        /** -----------LISTENER BUTTON---------------- */

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.userLb.Text))
            {
                Model.Count++;
                //this.userLb.Text = "svp" + Model.Count;
                UpdateUserName("svp" + Model.Count);
                Logger.Log(this.userLb.Text, "Start creating password for this user [" + Model.UserName + "]");
            }

            //or Random rnd = new Random(new System.DateTime().Millisecond).Next());
            Model.Index = Model.Rand.Next(0, lines.Count);
            UpdateKeyWord(lines[Model.Index]);
            String password = PasswordFactory.convertToPassword(Model.KeyWord);
            UpdatePassword(password);
            
            Logger.Log("User [" + this.userLb.Text + "] refreshed the password - Current key is [" + Model.KeyWord + "] and Password is [" + Model.Password + "]");

            if (hintForm != null)
                hintForm.RefreshHintForm();
            if (practiceForm != null)
                practiceForm.RefreshForm();
        }

        private void practiceBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                Logger.Log("User [" + this.userLb.Text + "] used practice form for password [" + Model.Password + "] and keyword [" + Model.KeyWord + "]");
                if (practiceForm == null || practiceForm.Text == "")
                {
                    practiceForm = new PracticeForm();
                    practiceForm.Dock = DockStyle.Fill;
                    practiceForm.Show();
                }
                else if (Model.CheckFormOpen(practiceForm))
                {
                    practiceForm.WindowState = FormWindowState.Normal;
                    practiceForm.Dock = DockStyle.Fill;
                    practiceForm.Show();
                    practiceForm.Focus();
                }
            }
        }

        private void hintBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                Logger.Log("User [" + this.userLb.Text + "] used hint button");
                if (hintForm == null || hintForm.Text == "")
                {
                    hintForm = new HintForm();
                    hintForm.Dock = DockStyle.Fill;
                    hintForm.Show();
                }
                else if (Model.CheckFormOpen(hintForm))
                {
                    hintForm.WindowState = FormWindowState.Normal;
                    hintForm.Dock = DockStyle.Fill;
                    hintForm.Show();
                    hintForm.Focus();
                }
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                //Save this password to this user
                addNewAccount();
                //Remove this word from the list
                removeWordFromFile();
                //Clean up the GUI
                cleanUpGUI();
                this.Close();
            }
            else
                MessageBox.Show("Please click Refresh button to generate new password");
        }

        /**----------------MENU STRIP LISTENER---------------*/
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult clickBtn = MessageBox.Show("This will reset everything including:\n - Clean accounts file\n - " +
                "Reset password file\n - Clean logging file\nAre you sure you want to do that?", "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (clickBtn == System.Windows.Forms.DialogResult.Yes)
            {
                //Clean up GUI
                cleanUpGUI();
                //Clean up data
                cleanUpFiles();
            }
        }

        private void displayLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.DisplayLogFile();
        }

        private void displayAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(pathFileToSave);
        }

        /**------------------HELPER FUNCTION-------------------*/
        private void addNewAccount()
        {
            foreach (string key in accounts.Keys)
            {
                if (String.Equals(key, this.userLb.Text))
                {
                    Logger.Log("This user already had password");
                    return;
                }
            }

            accounts.Add(this.userLb.Text, this.passwordTxtBox.Text);

            //string path = Directory.GetCurrentDirectory() + @"\Data\accountsList.txt";
            string msg = Model.UserName + "," + Model.Password + "," + Model.KeyWord;
            ReadWriteFiles.WriteToFile(pathFileToSave, msg);
            //Logger.Log("Added password [" + Model.Password + "] and keyword [" + Model.KeyWord + "] to this account [" + Model.UserName + "] to the file at [" + this.pathFileToSave + "]");
            Logger.Log("User [" + Model.UserName + "] - password [" + Model.Password + "] - keyword [" + Model.KeyWord + "] has been added to the file at [" + this.pathFileToSave + "]");
            Logger.Log("Completed [" + whatPurpose + "] form");
            this.lockButton = true;
        }

        private void removeWordFromFile()
        {
            lines.RemoveAt(Model.Index);
        }

        private void cleanUpGUI()
        {
            UpdatePassword(String.Empty);
            //UpdateUserName(String.Empty);
            this.userLb.Text = String.Empty;
            UpdateKeyWord(String.Empty);
        }

        private void cleanUpFiles()
        {
            Logger.CleanLogFile();
        }


        private void UpdatePassword(string newPass)
        {
            this.passwordTxtBox.Text = newPass;
            Model.Password = newPass;
        }
        private void UpdateUserName(string userName)
        {
            this.userLb.Text = userName;
            Model.UserName = userName;
        }
        private void UpdateKeyWord(string newKey)
        {
            Model.KeyWord = newKey;
        }

        private void GenerateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (generateManyForm != null)
                {
                    if (!this.lockButton)
                    {
                        Logger.Log("User [" + this.userLb.Text + "] closed the [" + whatPurpose + "] signup form without creating password");
                    }
                    else
                    {
                        switch (whatPurpose)
                        {
                            case "Email":
                                generateManyForm.GetEmailBtn.Enabled = this.lockButton ? false : true;
                                generateManyForm.GetBankBtn.Enabled = this.lockButton ? true : false;
                                generateManyForm.SetEmailStatus = "Completed";
                                generateManyForm.SetBankStatus = "Ready to create password";
                                break;
                            case "Banking":
                                generateManyForm.GetBankBtn.Enabled = this.lockButton ? false : true;
                                generateManyForm.GetShopBtn.Enabled = this.lockButton ? true : false;
                                generateManyForm.SetBankStatus = "Completed";
                                generateManyForm.SetShopStatus = "Ready to create password";
                                break;
                            case "Shopping":
                                generateManyForm.GetShopBtn.Enabled = this.lockButton ? false : true;
                                generateManyForm.SetShopStatus = "Completed";
                                generateManyForm.Close();
                                break;
                        }
                        generateManyForm.Refresh();
                    }
                }
            }
        }
    }
}
