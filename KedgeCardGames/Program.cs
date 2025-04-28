using KedgeCardGames;
using KedgeCardGames.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddRefitClient<IPokemonTcg>()
    .ConfigureHttpClient(x => x.BaseAddress = new Uri("https://api.pokemontcg.io"));

builder.Services.AddRefitClient<IYgoproDeck>()
    .ConfigureHttpClient(x => x.BaseAddress = new Uri("https://db.ygoprodeck.com/api"));

await builder.Build().RunAsync();
