# BlazorPaginationExample
Example for using the BlazorPaginationComponent nuget package

## Install the BlazorPaginationComponent 
The NuGet package can be installed from [NuGet]: https://www.nuget.org/packages/BlazorPaginationComponent/1.0.0 or by using the following command in the Package Manager Consol: Install-Package BlazorPaginationComponent -Version 1.0.0

## Import the component

Add **@using BlazorPaginationComponent** to the **_Imports** file in the root folder.

## Define your custom page model

```C#
public class PageModel<T>
{
    public IList<T> Entities { get; set; }

    public PaginationModel PaginationModel { get; set; }
}

public class PaginationModel
{
    public int TotalItems { get; set; }
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
}
```

## Define the CallBack for the OnePageChange event

The BlazorPaginationComponent defines an **EvenCallback<int>** called **OnPageChange**. This will fire each time the user selects a new page. In your component you should define the logic which has to be executed when the user selects a new page. 

For example:
```C#
public async Task LoadPage(int page)
{
    this.PageModel = await await this._httpClient.GetJsonAsync<PageModel<T>>('url');
}
```

## Use the component

```html
<div class>
    <PaginationComponent TotalItems="@PageModel.PaginationModel.TotalItems"
                         CurrentPage="@PageModel.PaginationModel.CurrentPage"
                         PageSize="@PageModel.PaginationModel.PageSize"
                         OnePageChange="LoadPage"></PaginationComponent>
</div>
```
