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
    /**
     *<summary>
     * Hint Form is used to display the keyword for the password
     * Help user to memorize the password easier
     * </summary>
     */
    public partial class HintForm : Form
    {
        public HintForm()
        {
            InitializeComponent();
            RefreshHintForm();
        }

        //This function will be called everytime by Refresh Password button in GenerateForm
        public void RefreshHintForm()
        {
            try
            {
                string lastTwoPassword = Model.Password.Substring(Model.Password.Length - 2);
                this.dayHintLb.Text = lastTwoPassword + " -> day";
                this.keyLb.Text = "Key: " + Model.KeyWord;
                this.Update();
            }
            catch (Exception e)
            {
                Logger.Log("ERROR: " + e);
            }
        }

        //Logging the username with date and time when s/he closes the form
        private void HintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Logger.Log("User [" + Model.UserName + "] closed Hint form");
            }
        }
    }
}
