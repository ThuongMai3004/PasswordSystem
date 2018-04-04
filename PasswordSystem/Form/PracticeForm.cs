using PasswordSystem.Data;
using System;
using System.Windows.Forms;

namespace PasswordSystem
{
    /**
     * <summary>
     * Practice form is used for user to practice the password
     * Help user to familiarize the password
     * </summary>
     */
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
            RefreshForm();
        }

        //Will be called by Refresh Password button in GenerateForm
        public void RefreshForm ()
        {
            this.userLb.Text = "User: " + Model.UserName;
        }

        //Check button handler, will compare the input password with the password provided in GenerateForm
        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.practiceBox.Text))
                MessageBox.Show("Please input your password to practice", "Warning", MessageBoxButtons.OK);
            else if (String.Equals(this.practiceBox.Text, Model.Password))
            {
                MessageBox.Show("You entered password correctly", "Message", MessageBoxButtons.OK);
                Logger.Log("User [" + Model.UserName + "] entered password [" + Model.Password + "] correctly in practice form");
                this.practiceBox.Text = "";
            }
            else
            {
                MessageBox.Show("You made a mistake " + Model.Password, "Message", MessageBoxButtons.OK);
                Logger.Log("User [" + Model.UserName + "] entered wrong passwword [" + this.practiceBox.Text + "] in practice form. Correct password is [" + Model.Password + "]");
                this.practiceBox.Text = "";
            }
        }

        //Logging with date and time if user closes this form
        private void PracticeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Logger.Log("User [" + Model.UserName + "] closed practice form");
        }
    }
}
