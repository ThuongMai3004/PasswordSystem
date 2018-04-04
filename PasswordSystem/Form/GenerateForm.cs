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
    /**
     * <summary>
     * This class is responsible to create new password for the user
     * it can be used by two parts of the requirements
     * Only different is part 2 will use the 1st constructor and part 3 will use the 2nd one
     * </summary>
     */
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

        //Default constructor for part 2
        public GenerateForm()
        {
            InitializeComponent();
            InitializeToolTip();

            //Read from the account file and save all available accounts to Data/Model
            ReadWriteFiles.ReadAccountFile(pathFileToSave);

            UpdateUserName("svp" + Model.Count);
            UpdatePassword(String.Empty);
        }

        //Default constructor for part 3
        public GenerateForm(string username, string _whatPurpose, string saveToThisFile, GenerateManyForm _form = null)
        {
            InitializeComponent();
            InitializeToolTip();

            UpdateUserName(username);
            UpdatePassword(String.Empty);

            this.pathFileToSave = saveToThisFile;
            this.whatPurpose = _whatPurpose;
            this.titleLb.Text = "Team 48 Password Scheme for " + _whatPurpose;
            this.generateManyForm = _form;

            Logger.Log(whatPurpose, 2);
        }

        //ToolTip is used when user hover the mouse over the button to display helpful hint
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
        /*
         * Refresh Password button handler
         * It used to generate new password everytime user click the button
         * It also refreshes the Hint and Practice form to the latest password
         */
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //If the userLb is empty, it means that this is the new user, so assign new username to this user
            if (String.IsNullOrEmpty(this.userLb.Text))
            {
                Model.Count++;
                UpdateUserName("svp" + Model.Count);
                Logger.Log(this.userLb.Text, "Start creating password for this user [" + Model.UserName + "]");
            }

            //or Random rnd = new Random(new System.DateTime().Millisecond).Next());
            Model.Index = Model.Rand.Next(0, lines.Count);
            UpdateKeyWord(lines[Model.Index]);
            String password = PasswordFactory.convertToPassword(Model.KeyWord);
            UpdatePassword(password);
            
            Logger.Log("User [" + this.userLb.Text + "] refreshed the password - Current key is [" + Model.KeyWord + "] and Password is [" + Model.Password + "]");

            //Refresh Hint and Practice forms to the latest password
            if (hintForm != null)
                hintForm.RefreshHintForm();
            if (practiceForm != null)
                practiceForm.RefreshForm();
        }

        /*
         * Practice button handler
         * It is used to call the practice form to practice the password as many time as they want
         * It will be refreshed by the Refresh button, so the password is always up to date. No need to close the form to refresh
         */
        private void practiceBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                Logger.Log("User [" + this.userLb.Text + "] used practice form for password [" + Model.Password + "] and keyword [" + Model.KeyWord + "]");
                //Use DisplayForm function to open only 1 form
                ReadWriteFiles.DisplayForm(ref practiceForm);
            }
        }

        /*
         * Hint button handler
         * It will call the Hint form with the keyword for user to memorize the password
         */ 
        private void hintBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.passwordTxtBox.Text))
            {
                Logger.Log("User [" + this.userLb.Text + "] used hint button");
                //Use DisplayForm function to open only 1 form
                ReadWriteFiles.DisplayForm(ref hintForm);
            }
        }

        /*
         * Accept Password button handler
         * Will add the password to this user to the database
         * Remove the word keyword out of the list of words
         * Clean up the GUI, then close it
         */ 
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
        /*
         * Reset toolStripMenuItem handler
         * It will reset the Logging file and more
         */ 
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

        //Display the Log File using notepad
        private void displayLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.DisplayLogFile();
        }

        //Display account file using notepad
        private void displayAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(pathFileToSave);
        }

        /**------------------HELPER FUNCTION-------------------*/
        //Handler adding new account to the database
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
            //Add the username with this password to the Dictionary accounts
            accounts.Add(this.userLb.Text, this.passwordTxtBox.Text);
            
            //Write the password with this username to the data file
            string msg = Model.UserName + "," + Model.Password + "," + Model.KeyWord;
            ReadWriteFiles.WriteToFile(pathFileToSave, msg);
            
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

        /*
         * Will be call if the user close this form
         * It only activated by Part 3 if generateManyForm is not null
         * It will pass info to the parent generateManyForm and close this form
         */ 
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
