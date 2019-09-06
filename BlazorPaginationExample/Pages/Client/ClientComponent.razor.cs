using Microsoft.AspNetCore.Components;

namespace BlazorPaginationExample.Pages.Client
{
    public class ClientComponentCode :  ComponentBase
    {
        [Parameter] public ClientModel ClientParameter { get; set; }

        private const string DefaultAvatarPicture = "https://via.placeholder.com/150";
        private const string MoneyFormat = "#,#.00#";

        public string GetAvatarImage()
        {
            return ClientParameter.Picture ?? DefaultAvatarPicture;
        }

        public string MoneyFormatWithCurrency(string currencySimbol, decimal money)
        {
            return $"{currencySimbol} {money}";
        }

        public string GetNetMoney(string currencySimbol)
        {
            decimal balance = this.ClientParameter.Earnings - this.ClientParameter.Expenses;
            return $"{currencySimbol} {balance.ToString(MoneyFormat)}";
        }
    }
}
