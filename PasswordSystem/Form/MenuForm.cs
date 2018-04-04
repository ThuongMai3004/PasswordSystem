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
    public partial class MenuForm : Form
    {
        GenerateForm generateForm = null;
        LoginForm loginForm = null;
        GenerateManyForm generateManyForm = null;
        LoginManyForm loginManyForm = null;

        public MenuForm()
        {
            InitializeComponent();
            Logger.CleanLogFile();
        }

        private void createPasswordBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to create single password (part 2)", 3);
            ReadWriteFiles.DisplayForm(ref generateForm);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to login single password (part 2)", 3);
            ReadWriteFiles.DisplayForm<LoginForm>(ref loginForm);
        }

        private void createMassBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to create 3 passwords (part 3)" , 3);
            ReadWriteFiles.DisplayForm(ref generateManyForm);
        }

        private void loginMassBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to login 3 passwords (part 3)", 3);
            ReadWriteFiles.DisplayForm(ref loginManyForm);
        }

        private void displayLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.DisplayLogFile();
        }

        private void displayAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.accountFileName);
        }

        private void displayBankingAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.bankAccountFile);
        }

        private void displayShoppingAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.shoppingAccountFile);
        }
    }
}
