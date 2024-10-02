using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalesSystem.GUI.Forms;
using SalesSystem.Repository;
using SalesSystem.Services;

namespace SalesSystem.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var formService = host.Services.GetRequiredService<frmCatgory>();
            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder().ConfigureAppConfiguration(
            (context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.RegisterRepositoryDependencies();
                services.RegisterServicesDependencies();

                //services.AddTransient<Form1>();
                services.AddSingleton<frmCatgory>();
            });
    }
}