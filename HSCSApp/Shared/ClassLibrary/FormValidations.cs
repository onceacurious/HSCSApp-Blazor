using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCSApp.Shared.ClassLibrary
{
    public class FormValidations : IFormValidations
    {
        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public string NumberDefaultFormat(string str)
        {
            if (str.StartsWith("09") && str.Length == 11)
            {
                return str;
            }
            else if (str.StartsWith("9") && str.Length == 10)
            {
                return "0" + str;
            }
            else if (str.StartsWith("+09") && str.Length == 12)
            {
                return str.Remove(0, 1);
            }
            else if (str.StartsWith("+9") && str.Length == 11)
            {
                return "0" + str.Remove(0, 1);
            }
            else if (str.StartsWith("+639") && str.Length == 13)
            {
                return "0" + str.Remove(0, 3);
            }
            else if (str.StartsWith("+630") && str.Length == 14)
            {
                return str.Remove(0, 3);
            }
            else if (str.StartsWith("630") && str.Length == 13)
            {
                return str.Remove(0, 2);
            }
            else if (str.Contains(')') && str.Contains('(') && str.Length < 9)
            {
                int index = str.IndexOf(')');
                string newStr = str.Remove(index, 1);
                int newIndex = str.IndexOf('(');
                return newStr.Remove(newIndex, 1);
            }
            else if (str.Length > 9)
            {
                return str + "***";
            }
            else
            {
                return str;
            }
        }
    }
}