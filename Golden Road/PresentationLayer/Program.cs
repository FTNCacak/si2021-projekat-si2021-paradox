using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var goldenRoad = serviceProvider.GetRequiredService<FormGoldenRoad>();
                Application.Run(goldenRoad);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IGoldenRoadBusiness, GoldenRoadBusiness>();
            services.AddScoped<IGoldenRoadRepository, GoldenRoadRepository>();

            services.AddScoped<FormGoldenRoad>();
            services.AddScoped<FormCheck>();
            
        }
    }
}
