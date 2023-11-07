using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using UmotaWebApp.Server.Services.Extensions;
using UmotaWebApp.Server.Services.Infrastructure;
using UmotaWebApp.Server.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UmotaWebApp.Server.Extensions;
using DinkToPdf.Contracts;
using DinkToPdf;
using System.IO;
using System.Reflection;
using System;
using UmotaWebApp.Shared.Config;
using UmotaWebApp.Server.Services.Email;
using UmotaWebApp.Server.Services;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http;
using Prizma.Core.Repositories;
using Prizma.Services;
using Prizma.Core.Services;
using Prizma.Core;
using Prizma.Data;

namespace UmotaWebApp.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllersWithViews();
            services.AddRazorPages();

            services.ConfigureMapping();

            services.AddDbConnection();

            //services.AddScoped<IEmailSender, EmailSender>();
            //var emailConfig = Configuration
            //        .GetSection("EmailConfiguration")
            //        .Get<EmailConfiguration>();

            //services.AddSingleton(emailConfig);

            services.AddScoped<ISisKullaniciService, SisKullaniciService>();
            services.AddScoped<ISisFirmaService, SisFirmaService>();
            services.AddScoped<ISisMenuService, SisMenuService>();
            services.AddScoped<ICariKartService, CariKartService>();
            services.AddScoped<IRefGenerator, RefGeneratorService>();
            //services.AddScoped<ITeklifService, TeklifService>();
            //services.AddScoped<ITeklifDetayService, TeklifDetayService>();
            //services.AddScoped<IMalzemeKartService, MalzemeKartService>();
            services.AddScoped<IPersonelService, PersonelService>();
            services.AddScoped<ISisFirmaDonemService, SisFirmaDonemService>();
            services.AddScoped<IDovizService, DovizService>();
            //services.AddScoped<IFaaliyetService, FaaliyetService>();
            services.AddScoped<IPdfGenerator, PdfGeneratorService>();
            services.AddScoped<IVCariKartService, VCariKartService>();
            //services.AddScoped<IKisilerService, KisilerService>();
            //services.AddScoped<IVMalzemeKartService, VMalzemeKartService>();
            //services.AddScoped<IDashboardInfo, DashboardInfo>();
            //services.AddScoped<ITeklifReportService, ReportService>();
            //services.AddScoped<ITakvimService, TakvimService>();
            //services.AddScoped<IVazifeService, VazifeService>();
            //services.AddScoped<ICariRaporService, CariRaporService>();
            services.AddScoped<IServisService, ServisService>();
            services.AddScoped<IFileUpload, FileUploadService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ITalepDetayService, TalepDetayService>();
            services.AddTransient<IMahalService, MahalService>();
            services.AddTransient<ITalepFisService, TalepFisService>();
            services.AddTransient<IProjeService, ProjeService>();
            services.AddTransient<ISiparisService, SiparisService>();
            services.AddTransient<ISiparisDetayService, SiparisDetayService>();
            services.AddTransient<IAktiviteService, AktiviteService>();
            services.AddTransient<ITalepOnayService, TalepOnayService>();
            services.AddScoped<ITalepDosyaService, TalepDosyaService>();
            services.AddTransient<IKaynakService, KaynakService>();
            services.AddTransient<ISiparisOnayService, SiparisOnayService>();
            services.AddTransient<ISiparisDosyaService, SiparisDosyaService>();

            var architectureFolder = (IntPtr.Size == 8) ? "64 bit" : "32 bit";
            var wkHtmlToPdfPath = Path.Combine(Environment.CurrentDirectory, $"wkhtmltox\\v0.12.4\\{architectureFolder}\\libwkhtmltox");
            CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(wkHtmlToPdfPath);
            services.AddSingleton(typeof(IConverter), new STASynchronizedConverter(new PdfTools()));

            services.AddDbContext<PrizmaDbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetPrizmeDbConnection());
            });

            services.AddDbContext<MasterDbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetMasterDbConnection());
            });


            services.AddDbContext<UmotaMasterDbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetUmotaConnectionString());
            });


            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(op => {
                op.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["JwtIssuer"],
                    ValidAudience = Configuration["JwtAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
                };
            });

            services.AddHealthChecks();

            services.AddLogging();

            services.AddAutoMapper(typeof(Startup));

             
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/dosyalar")),
                RequestPath = new PathString("/Dosyalar")
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });

            app.UseSwagger(); 
            

        }
    }
}
