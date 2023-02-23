using BethanysPieShopHRM.Shared.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.ComponetsLibrary
{
    public partial class Map
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }


        string elementId = $"map-{Guid.NewGuid():D}";

        [Parameter]
        public double Zoom { get; set; }

        [Parameter]
        public List<Marker> Markers { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync(
                "deliveryMap.showOrUpdate",
                elementId,
                Markers);
        }
    }
}
