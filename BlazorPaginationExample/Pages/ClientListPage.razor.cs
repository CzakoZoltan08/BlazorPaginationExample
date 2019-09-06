using BlazorPaginationExample.Models;
using BlazorPaginationExample.Pages.Client;
using BlazorPaginationExample.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorPaginationExample.Pages
{
    public class ClientListCode : ComponentBase
    {
        public PageModel<ClientModel> PageModel { get; set; }

        [Inject]
        internal IPaginationService PaginationService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PageModel = await PaginationService.LoadPageTest<ClientModel>(1, "sample-data/clients");
        }

        public async Task LoadPage(int page)
        {
            this.PageModel = await this.PaginationService.LoadPageTest<ClientModel>(page, "sample-data/clients");
        }
    }
}
