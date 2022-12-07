using DroneController.DA.Contexts;
using DroneController.DA.Models;
using DroneController.DL.Infrastructure.ErrorHandler;
using DroneController.DL.Repositories;
using DroneController.DL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroneController.API.Infrastructure
{
    internal static class Installer
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddTransient<IBaseRepository<Drone>, BaseRepository<Drone>>();
            services.AddTransient<IBaseService<Drone>, BaseService<Drone>>();
            services.AddTransient<IDroneService, DroneService>();
            services.AddTransient<IErrorHandler, ErrorHandler>();
        }

    }
}
