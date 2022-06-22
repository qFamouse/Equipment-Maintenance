using EquipmentMaintenance.Core.Interfaces.Repositories;
using EquipmentMaintenance.Core.Interfaces.Services;
using EquipmentMaintenance.Core.Services;
using EquipmentMaintenance.Infrastructure.Data;
using EquipmentMaintenance.Infrastructure.Data.Repositories;
using EquipmentMaintenance.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EquipmentMaintenance.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // DbContext //
            services.AddSingleton<EquipmentMaintenanceContext>();

            // Repositories //
            services.AddSingleton<IEquipmentRepository, EquipmentRepository>();

            // Services //
            services.AddSingleton<IEquipmentService, EquipmentService>();

            // Model-View-ViewModel //
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();

            DISource.Resolver = (type) => _host.Services.GetRequiredService(type);

            _host.Services.GetRequiredService<MainWindow>().Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using (_host)
            {
                await _host.StopAsync();
            }

            base.OnExit(e);
        }
    }
}
