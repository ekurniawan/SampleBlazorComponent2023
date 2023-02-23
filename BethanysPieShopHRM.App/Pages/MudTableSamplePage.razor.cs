using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;
using MudBlazor;
using static MudBlazor.CategoryTypes;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class MudTableSamplePage
    {
        private string message = string.Empty;
        private bool _loading;
        public List<Employee> Employees { get; set; } = default!;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees.ToList();
        }

        public void RowClickEvent(TableRowClickEventArgs<Employee> tableRowClickEventArgs)
        {
            message = "item clicked";
        }
    }

    
}
