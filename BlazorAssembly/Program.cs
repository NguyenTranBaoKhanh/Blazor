using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorAssembly;
using BlazorAssembly.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<ICategoryApi, CategoryApi>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7165") });

await builder.Build().RunAsync();
