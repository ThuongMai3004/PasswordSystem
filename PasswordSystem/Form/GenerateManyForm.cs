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
     * <summary>
     * GenerateManyForm class to display 3 creating password parts : Email, Banking and Shopping (Part 3 only)
     * </summary>
     */ 
    public partial class GenerateManyForm : Form
    {
        public GenerateManyForm()
        {
            InitializeComponent();
            ReadWriteFiles.ReadAccountFile(Model.emailAccountFile);

            UpdateUserName("svp" + Model.Count);

            //Only enable the first button to force user to create all 3 password in ordered
            this.createEmailPassBtn.Enabled = true;
            this.createShopPassBtn.Enabled = false;
            this.createBankPassBtn.Enabled = false;
        }

        //Create password for Email, it will call GenerateForm
        private void createEmailPassBtn_Click(object sender, EventArgs e)
        {
            GenerateForm generateForm = new GenerateForm(Model.UserName, "Email", Model.emailAccountFile, this);
            generateForm.Show();
            Logger.Log("User [" + this.userLb.Text + "] chose to create [Email] password", 1);
        }

        //Create password for Banking, it will call GenerateForm
        private void createBankPassBtn_Click(object sender, EventArgs e)
        {
            GenerateForm generateForm = new GenerateForm(Model.UserName, "Banking", Model.bankAccountFile, this);
            generateForm.Show();
            Logger.Log("User [" + this.userLb.Text + "] chose to create [Banking] password", 1);
        }

        //Create password for Shopping, it will call GenerateForm
        private void createShopPassBtn_Click(object sender, EventArgs e)
        {
            GenerateForm generateForm = new GenerateForm(Model.UserName, "Shopping", Model.shoppingAccountFile, this);
            generateForm.Show();
            Logger.Log("User [" + this.userLb.Text + "] chose to create [Shopping] password", 1);
        }

        private void UpdateUserName(string userName)
        {
            this.userLb.Text = userName;
            Model.UserName = userName;
        }

        public Button GetEmailBtn { get { return createEmailPassBtn; } }
        public Button GetShopBtn { get { return createShopPassBtn; } }
        public Button GetBankBtn { get { return createBankPassBtn; } }
        public String SetEmailStatus { set { this.statusEmailLb.Text = value; } }
        public String SetShopStatus { set { this.statusShopLb.Text = value; } }
        public String SetBankStatus { set { this.statusBankLb.Text = value; } }

        /*
         * Will be called if user close this form
         * It will disable the closing button if user has not completed creating all 3 passwords
         */ 
        private void GenerateManyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.createEmailPassBtn.Enabled || this.createShopPassBtn.Enabled || this.createBankPassBtn.Enabled)
                {
                    MessageBox.Show("Please complete all password");
                    e.Cancel = true; //Simply comment this line to activate the closing button
                }
                Logger.Log("Completed creating 3 passwords for this user [" + this.userLb.Text + "]", 2);
            }
        }
    }
}
