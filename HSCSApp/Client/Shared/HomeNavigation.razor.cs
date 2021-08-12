using HSCSApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using HSCSApp.Client.Services.ProductService;

namespace HSCSApp.Client.Shared
{
    public partial class HomeNavigation : ComponentBase
    {
        private string hamburger;
        private string close = "hide";

        private string toggleMenu = "hide";

        private string serviceMenu = "hide";

        protected override void OnInitialized()
        {
            ps.LoadProducts();
        }

        private void Toggler()
        {
            if (close == "hide")
            {
                hamburger = "hide";
                close = string.Empty;
                toggleMenu = "toggle-menu";
            }
            else
            {
                hamburger = string.Empty;
                close = "hide";
                toggleMenu = "hide";
            }
        }

        private void ToggleMenu_Clicked()
        {
            toggleMenu = "hide";
            close = "hide";
            hamburger = string.Empty;
        }

        private void Service_Clicked()
        {
            if (serviceMenu == "hide")
            {
                serviceMenu = "service-menu";
            }
            else
            {
                serviceMenu = "hide";
            }
        }

        private void Service_focusOut()
        {
            serviceMenu = "hide";
        }
    }
}