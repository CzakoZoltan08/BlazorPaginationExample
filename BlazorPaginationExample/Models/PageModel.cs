using System.Collections.Generic;

namespace BlazorPaginationExample.Models
{
    public class PageModel<T>
    {
        public IList<T> Entities { get; set; }

        public PaginationModel PaginationModel { get; set; }
    }
}
