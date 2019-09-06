using Microsoft.AspNetCore.Components;

namespace BlazorPaginationExample.Pages.Client
{
    public class ClientPropertyCode<T> : ComponentBase
    {
        [Parameter] public T ClientProperty { get; set; }

        [Parameter] public string IconName { get; set; }

        [Parameter] public string LabelText { get; set; }
    }
}
