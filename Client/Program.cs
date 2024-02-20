using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazored.Modal;
using Blazored.LocalStorage;
using UmotaWebApp.Client.Utils;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using MudBlazor;
using UmotaWebApp.Client.ServiceHelpers;

namespace UmotaWebApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredModal();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<ModalManager>();
            builder.Services.AddScoped<TakvimHelper>();
            builder.Services.AddScoped<YetkiHelper>();
            builder.Services.AddScoped<FaaliyetHelper>();
            builder.Services.AddScoped<TeklifHelper>();
            builder.Services.AddScoped<VazifeHelper>();
            builder.Services.AddScoped<KullaniciHelper>();
            builder.Services.AddScoped<Helper>();
            builder.Services.AddScoped<DownloadHelper>();
            builder.Services.AddScoped<KisiHelper>();
            builder.Services.AddScoped<ServisHelper>();
            builder.Services.AddScoped<UploadHelper>();
            builder.Services.AddScoped<TalepDetayHelper>();
            builder.Services.AddScoped<TalepFisHelper>();
            builder.Services.AddScoped<SabitHelper>();
            builder.Services.AddScoped<ProjeHelper>();
            builder.Services.AddScoped<AktiviteHelper>();
            builder.Services.AddScoped<MahalHelper>();
            builder.Services.AddScoped<KaynakHelper>();
            builder.Services.AddScoped<SiparisHelper>();
            builder.Services.AddScoped<SiparisDetayHelper>();
            builder.Services.AddScoped<FaturaHelper>();

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;

                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });

            await builder.Build().RunAsync();
        }
    }
}
