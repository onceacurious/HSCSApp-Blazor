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

        public string NumberValidation(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            if (str.Length > 1)
            {
                if (str.StartsWith('+'))
                {
                    int index = str.IndexOf('+');
                    return str.Remove(index, 1);
                }
                else if (str.Contains(')') && str.Contains('('))
                {
                    int index = str.IndexOf(')');
                    string newStr = str.Remove(index, 1);
                    int newIndex = str.IndexOf('(');
                    return newStr.Remove(newIndex, 1);
                }
                else
                {
                    return str;
                }
            }

            return str;
        }
    }
}