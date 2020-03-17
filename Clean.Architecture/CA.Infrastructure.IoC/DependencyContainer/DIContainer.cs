using CA.Application.Interfaces;
using CA.Application.Services;
using CA.Domain.Interfaces;
using CA.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Infrastructure.IoC.DependencyContainer
{
    public static class DIContainer
    {
        public static void RegisterServices(IServiceCollection services) {

            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            //

        }
    }
}
