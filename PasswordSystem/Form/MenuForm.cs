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
     * The First form of the program. 
     * Display 2 Parts of the program, each part has login and creating password buttons
     * </summary>
     */
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

        //Create password button for the part 2
        private void createPasswordBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to create single password (part 2)", 3);
            ReadWriteFiles.DisplayForm(ref generateForm);
        }

        //Login button for the part 2
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to login single password (part 2)", 3);
            ReadWriteFiles.DisplayForm<LoginForm>(ref loginForm);
        }

        //Create password button for the part 3
        private void createMassBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to create 3 passwords (part 3)" , 3);
            ReadWriteFiles.DisplayForm(ref generateManyForm);
        }

        //Login button for the part 3
        private void loginMassBtn_Click(object sender, EventArgs e)
        {
            Logger.Log("User chose to login 3 passwords (part 3)", 3);
            ReadWriteFiles.DisplayForm(ref loginManyForm);
        }

        //ToolStripMenu for displaying log file
        private void displayLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.DisplayLogFile();
        }

        //ToolStripMenu for displaying account/email file
        private void displayAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.accountFileName);
        }

        //ToolStripMenu for displaying banking file
        private void displayBankingAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.bankAccountFile);
        }

        //ToolStripMenu for displaying shopping file
        private void displayShoppingAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadWriteFiles.DisplayFile(Model.shoppingAccountFile);
        }
    }
}
