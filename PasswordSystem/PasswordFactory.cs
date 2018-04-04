using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSystem
{
    public static class PasswordFactory
    {
        /**
         * <summary>
         * Main Password function.
         * It will get the keyword and convert it to the Password with 2 digit number for day
         * </summary>
         */ 
        public static string convertToPassword(string keyWord)
        {
            string password = keyWord.Replace('a', '@').Replace('b', '8').Replace('i', '!').Replace('s', '$').Replace('o', '0').Replace('t', '+');
            DateTime thisDay = DateTime.Today;
            String theDate = thisDay.Day.ToString();
            if (theDate.Length == 1)
                theDate = "0" + theDate;
            password += theDate;
            return password;
        }

        //Haven't used yet
        #region 2nd password Scheme Function
        public static string convertToPassword2(string keyWord)
        {
            Random rand;
            int index;
            string password = "";
            if (keyWord.Contains('a'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('a', 'a'); break;
                    case 1: password = keyWord.Replace('a', 'A'); break;
                    case 2: password = keyWord.Replace('a', '@'); break;
                }
            }
            else if (keyWord.Contains('b'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('b', 'b'); break;
                    case 1: password = keyWord.Replace('b', 'B'); break;
                    case 2: password = keyWord.Replace('b', '8'); break;
                }
            }
            else if (keyWord.Contains('i'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('i', 'i'); break;
                    case 1: password = keyWord.Replace('i', 'I'); break;
                    case 2: password = keyWord.Replace('i', '!'); break;
                }
            }
            else if (keyWord.Contains('s'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('s', 's'); break;
                    case 1: password = keyWord.Replace('s', 'S'); break;
                    case 2: password = keyWord.Replace('s', '$'); break;
                }
            }
            else if (keyWord.Contains('o'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('o', 'o'); break;
                    case 1: password = keyWord.Replace('o', 'O'); break;
                    case 2: password = keyWord.Replace('o', '0'); break;
                }
            }
            else if (keyWord.Contains('t'))
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                index = rand.Next(0, 3);
                switch (index)
                {
                    case 0: password = keyWord.Replace('t', 't'); break;
                    case 1: password = keyWord.Replace('t', 'T'); break;
                    case 2: password = keyWord.Replace('t', '+'); break;
                }
            }
            DateTime thisDay = DateTime.Today;
            password += thisDay.Day.ToString();
            return password;
        }
        #endregion
    }
}
