using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Net.Http;
using BlazorPaginationExample.Models;

namespace BlazorPaginationExample.Services
{
    public class PaginationService : IPaginationService
    {
        private readonly HttpClient _httpClient;

        public PaginationService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<PageModel<T>> LoadPage<T>(int pageNumber, int pageSize, string url)
        {
            string queryString = $"{url}?pageNumber={pageNumber}&pageSize={pageSize}";
            return await this._httpClient.GetJsonAsync<PageModel<T>>(queryString);
        }

        public async Task<PageModel<T>> LoadPageTest<T>(int pageNumber, string url)
        {
            string pageUrl = $"{url}_page{pageNumber}.json";
            return await this._httpClient.GetJsonAsync<PageModel<T>>(pageUrl);
        }
    }
}
