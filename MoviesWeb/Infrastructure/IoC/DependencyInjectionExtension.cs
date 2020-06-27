using Microsoft.Extensions.DependencyInjection;
using MoviesWeb.Application.Services;
using MoviesWeb.Application.Services.Interfaces;
using MoviesWeb.Domain.Interfaces.Repositories;
using MoviesWeb.Domain.Interfaces.Services;
using MoviesWeb.Domain.Services;
using MoviesWeb.Infrastructure.Data;
using MoviesWeb.Infrastructure.Data.Repositories;
using MoviesWeb.Infrastructure.Data.UnitOfWork;
using MoviesWeb.Infrastructure.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.IoC
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services
                .AddDbContext<MovieContext>()
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddSingleton<ITypeAdapterFactory, AutoMapperTypeAdapterFactory>()
                .AddSingleton<ITypeAdapter, AutoMapperTypeAdapter>()
                .AddScoped<IMovieAppService, MovieAppService>()
                .AddScoped<IMovieService, MovieService>()
                .AddScoped<IMovieRepository, MovieRepository>();

            var sp = services.BuildServiceProvider();
            TypeAdapterFactory.SetCurrent(sp.GetService<ITypeAdapterFactory>());

            return services;
        }
    }
}
