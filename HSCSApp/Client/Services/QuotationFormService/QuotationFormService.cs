using HSCSApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSCSApp.Client.Services.QuotationFormService
{
    public class QuotationFormService
    {
        public string ServiceIcon;

        public readonly List<Product> Products = new List<Product>();

        public QuotationFormService(string serviceIcon)
        {
            this.ServiceIcon = serviceIcon;
        }

        /*

         */
    }
}