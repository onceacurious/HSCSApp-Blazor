using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCSApp.Shared
{
    public class MyNavigation
    {

        private string _display;
        public string Display
        {
            get { return _display; }
            set { _display = value; }
        }
        public string GetDisplay()
        {
            return _display;
        }

    }
}