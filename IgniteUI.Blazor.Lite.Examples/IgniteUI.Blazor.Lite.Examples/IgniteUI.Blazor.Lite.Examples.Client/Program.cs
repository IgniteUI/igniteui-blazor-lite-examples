using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddIgniteUIBlazor();

await builder.Build().RunAsync();
