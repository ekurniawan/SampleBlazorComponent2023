using BethanysPieShopHRM.App;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddHttpClient<IEmployeeDataService,EmployeeDataService>(client=>
client.BaseAddress=new Uri(builder.HostEnvironment.BaseAddress));



await builder.Build().RunAsync();
