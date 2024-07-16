using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using StructureCompany.Configurations;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using StructureCompany.Registory;
using StructureCompany.View;

namespace StructureCompany
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();
                var form1 = serviceProvider.GetRequiredService<frm_Main>();
                Application.Run(form1);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            //Application.Run(new frm_Main());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                    {
                        options.UseSqlServer("Server=WIN-2J6811OHPJK\\SQLEXPRESS;Database=StructureCompanyDB;Trusted_Connection=True;Encrypt=False");
                    });
            services.AddScoped<frm_Main>();

            string logFilePath = Path.Combine(Environment.CurrentDirectory, "Logs", "log-.txt");
            Log.Logger = new LoggerConfiguration()
                  .WriteTo.File(path: logFilePath,
                  outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
                  rollingInterval: RollingInterval.Day,
                  restrictedToMinimumLevel: LogEventLevel.Information
                  ).CreateLogger();

            services.AddLogging();
            services.AddAutoMapper(typeof(MapperInitilizer));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}