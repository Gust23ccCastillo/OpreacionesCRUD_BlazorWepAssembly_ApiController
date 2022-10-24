/*Paquetes Nugets Instalados Cliente
 * Microsoft.AspNetCore.Components.Authorization 6.0.10
 * Blazored.SessionStorage 2.2.0
 * 
 * 
 */

using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Client;
using OpreacionesCRUD_BlazorWepAssembly_ApiController.Client.Authentications;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();
await builder.Build().RunAsync();
