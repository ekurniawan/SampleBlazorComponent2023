using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class QuickViewPopup
    {
        private Employee? _employee;

        [Parameter]
        public Employee? Employee { get; set; }
    }
}
