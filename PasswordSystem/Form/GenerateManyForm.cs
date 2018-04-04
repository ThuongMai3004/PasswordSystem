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
    public partial class GenerateManyForm : Form
    {
        public GenerateManyForm()
        {
            //Logger.Log("-----Initialize GENERATE MANY PASSWORD FORM------", isInit: true);
            InitializeComponent();
            ReadWriteFiles.ReadAccountFile(Model.emailAccountFile);
            UpdateUserName("svp" + Model.Count);
            this.createEmailPassBtn.Enabled = true;
            this.createShopPassBtn.Enabled = false;
            this.createBankPassBtn.Enabled = false;
        }

        private void createEmailPassBtn_Click(object sender, EventArgs e)
        {
            GenerateForm generateForm = new GenerateForm(Model.UserName, "Email", Model.emailAccountFile, this);
            generateForm.Show();
            Logger.Log("User [" + this.userLb.Text + "] chose to create [Email] password", 1);
        }

        private void createBankPassBtn_Click(object sender, EventArgs e)
        {
            GenerateForm generateForm = new GenerateForm(Model.UserName, "Banking", Model.bankAccountFile, this);
            generateForm.Show();
            Logger.Log("User [" + this.userLb.Text + "] chose to create [Banking] password", 1);
        }

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

        private void GenerateManyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (this.createEmailPassBtn.Enabled || this.createShopPassBtn.Enabled || this.createBankPassBtn.Enabled)
                {
                    MessageBox.Show("Please complete all password");
                    e.Cancel = true;
                }
                Logger.Log("Completed creating 3 passwords for this user [" + this.userLb.Text + "]", 2);
            }
        }
    }
}
