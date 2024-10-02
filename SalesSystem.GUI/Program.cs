using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

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

            Application.Run(new Form1());
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder().ConfigureAppConfiguration(
            (context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            });
    }
}