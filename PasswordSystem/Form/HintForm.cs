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
    public partial class HintForm : Form
    {
        public HintForm()
        {
            InitializeComponent();
            RefreshHintForm();
        }

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

        private void HintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Logger.Log("User [" + Model.UserName + "] closed Hint form");
            }
        }
    }
}
