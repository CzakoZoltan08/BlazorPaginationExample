using BlazorPaginationExample.Models;
using System.Threading.Tasks;

namespace BlazorPaginationExample.Services
{
    public interface IPaginationService
    {
        Task<PageModel<T>> LoadPage<T>(int pageNumber, int pageSize, string url);
        Task<PageModel<T>> LoadPageTest<T>(int pageNumber, string url);
    }
}
