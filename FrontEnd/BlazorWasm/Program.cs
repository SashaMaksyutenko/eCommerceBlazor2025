using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasm;
using NetcodeHub.Packages.WebAssembly.Storage.Cookie;
using ClientLibrary.Helper;
using ClientLibrary.Services;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddNetcodeHubCookieStorageService();
builder.Services.AddScoped<ITokenService,TokenService>();
builder.Services.AddScoped<IHttpClientHelper,HttpClientHelper>();
builder.Services.AddScoped<IApiCallHelper,ApiCallHelper>();
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
await builder.Build().RunAsync();