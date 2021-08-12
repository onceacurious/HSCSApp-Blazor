using System.Linq;
using System.Threading.Tasks;
using Blazor.IntersectionObserver;
using HSCSApp.Client.Services.ProductService;
using HSCSApp.Client.Services.QuotationFormService;
using HSCSApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HSCSApp.Client.Pages
{
    public partial class Index : ComponentBase

    {
        protected override void OnInitialized()
        {
            productService.LoadProducts();
        }

        public ElementReference FooterObserver { get; set; }

        public bool IsIntersecting { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await SetupObserver();
            }
        }

        public async Task SetupObserver()
        {
            var options = new IntersectionObserverOptions
            {
                RootMargin = "10px 0px 0px 0px"
            };

            await observer.Observe(FooterObserver, (entries) =>
            {
                var entry = entries.FirstOrDefault();
                IsIntersecting = entry.IsIntersecting;
                StateHasChanged();

                if (entry.IsIntersecting)
                {
                    js.InvokeVoidAsync("ShowHeader");
                }
                else
                {
                    js.InvokeVoidAsync("HideHeader");
                }
            }, options);
        }

        private IntersectionObserver Observer;

        public async ValueTask DisposeAsync()
        {
            if (this.Observer != null)
            {
                await this.Observer.Dispose();
            }
            else
            {
                await js.InvokeVoidAsync("HideHeader");
            }
        }

        //private async Task ShowQuote()
        //{
        //    await js.InvokeVoidAsync("QuoteShow");
        //}

        private async Task CTA_Clicked()
        {
            await js.InvokeVoidAsync("QuoteShow");
            await js.InvokeVoidAsync("QuoteTitle");
        }

        private ProductService service = new ProductService();

        private async Task Service_Clicked()
        {
            await js.InvokeVoidAsync("QuoteShow");
        }
    }
}