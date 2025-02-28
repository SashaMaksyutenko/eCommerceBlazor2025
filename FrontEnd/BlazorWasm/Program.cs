using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasm;
using NetcodeHub.Packages.WebAssembly.Storage.Cookie;
using ClientLibrary.Helper;
using ClientLibrary.Services;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorWasm.Authentication;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddNetcodeHubCookieStorageService();
builder.Services.AddScoped<ITokenService,TokenService>();
builder.Services.AddScoped<IHttpClientHelper,HttpClientHelper>();
builder.Services.AddScoped<IApiCallHelper,ApiCallHelper>();
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();
builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthStateProvider>();
builder.Services.AddScoped<RefreshTokenHandler>();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient(Constant.ApiClient.Name,option=>{
    option.BaseAddress=new Uri("http://localhost:5286/api/");
}).AddHttpMessageHandler<RefreshTokenHandler>();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorizationCore();
await builder.Build().RunAsync();