using BusinessLogic.Logics;
using BusinessLogicInterface;
using DataAccess.Context;
using DataAccess.Repositories;
using DataAccessInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories
{
    public class ServiceFactory
    {
        private readonly IServiceCollection services;
        public ServiceFactory(IServiceCollection services)
        {
            this.services = services;
        }
        public void AddCustomServices()
        {
            services.AddScoped<ITouristSpotRepository, TouristSpotRepository>();
            services.AddScoped<ITouristSpotLogic, TouristSpotLogic>();
        }
        public void AddDbContextService(string connectionString)
        {
            services.AddDbContext<DbContext, MyContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
