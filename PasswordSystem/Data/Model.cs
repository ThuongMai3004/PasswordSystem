using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSystem.Data
{
    public static class Model
    {
        public const string accountFileName = @"\Data\accountsList.txt";
        public const string logFileName = @"\Data\LogFile.txt";
        public const string wordsFileName = @"Data\wordsList.txt";

        public const string emailAccountFile = @"\Data\emailAccount.txt";
        public const string bankAccountFile = @"\Data\bankAccount.txt";
        public const string shoppingAccountFile = @"\Data\shoppingAccount.txt";

        private static string keyWord;
        public static string KeyWord { get { return keyWord; } set { keyWord = value; } }

        private static int count;
        public static int Count { get { return count; } set { count = value; } }

        private static int index;
        public static int Index { get { return index; } set { index = value; } }

        private static Random rand;
        public static Random Rand { get { rand = new Random(Guid.NewGuid().GetHashCode()); return rand; } }

        private static string userName;
        public static string UserName { get { return userName; } set { userName = value; } }

        private static string password;
        public static string Password { get { return password; } set { password = value; } }

        private static Dictionary<string, string> accounts = new Dictionary<string, string>();
        public static Dictionary<string, string> Accounts
        {
            get { return accounts; }
        }
        public static void AddToAccounts(string key, string value)
        {
            if (!accounts.ContainsKey(key))
                accounts[key] = value;
        }
        public static void EraseAccounts()
        {
            accounts.Clear();
        }
        public static bool CheckPasswordForAccount(string user, string inputPassword)
        {
            if (accounts.ContainsKey(user))
            {
                if (accounts[user] == inputPassword)
                    return true;
                return false;
            }
            return false;
        }
        public static string ReturnPasswordForThisUser (string user)
        {
            if (accounts.ContainsKey(user))
            {
                return accounts[user];
            }
            return "null";
        }

        public static bool CheckFormOpen(Form myForm)
        {
            FormCollection collection = Application.OpenForms;
            foreach (Form form in collection)
            {
                if (form.Text == myForm.Text)
                    return true;
            }
            return false;
        }

        private static int attempt;
        public static int Attempt { get { return attempt; } set { attempt = value; } }
    }
}
