using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using msaPhase2.Models;

namespace msaPhase2.Data
{
    public class ScoreboardContext : DbContext
    {
        // an empty constructor
        public ScoreboardContext() { }

        // base(options) calls the base class's constructor,
        // in this case, our base class is DbContext
        public ScoreboardContext(DbContextOptions<ScoreboardContext> options) : base(options) { }

        // Use DbSet<Student> to query or read and 
        // write information about A Student
        public DbSet<Scoreboard> Scoreboard { get; set; }
        public static System.Collections.Specialized.NameValueCollection AppSettings { get; }

        // configure the database to be used by this context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            // schoolSIMSConnection is the name of the key that
            // contains the has the connection string as the value
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("schoolSIMSConnection"));
        }
    }
}
