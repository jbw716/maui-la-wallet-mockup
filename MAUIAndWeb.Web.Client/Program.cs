using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MAUIAndWeb.Shared.Services;
using MAUIAndWeb.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MAUIAndWeb.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
