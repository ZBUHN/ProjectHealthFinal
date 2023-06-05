using health_and_fitness_app.Models;
using Microsoft.EntityFrameworkCore;

namespace health_and_fitness_app.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        /*
               protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
               {
                   base.OnConfiguring(dbContextOptionsBuilder);
                   var builder = new ConfigurationBuilder().AddJsonFile("appsettings.Json", optional: true, reloadOnChange: true);
                   IConfigurationRoot configuration = builder.Build();
                   var conString = configuration.GetConnectionString("MyConnect");
                   dbContextOptionsBuilder.UseSqlServer(conString);
               }
       */
        public DbSet<PedometerEntry> pedometerEntries { get; set; }
    }

   

}
