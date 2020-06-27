using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoviesWeb.Domain.Entities;
using MoviesWeb.Infrastructure.Data.EntityConfig;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        private DbConnection connection;
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var cnn = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(cnn);

            this.connection = new MySqlConnection(cnn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MovieConfiguration());
        }
    }
}
