using System;
using System.Linq;
using System.Threading.Tasks;
using HSCSApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HSCSApp.Client.Shared
{
    public partial class QuotationForm : ComponentBase
    {
        private async Task CloseQuote()
        {
            await js.InvokeVoidAsync("QuoteHide");
        }
    }
}