using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HairSalon.Models
{
  public class HairSalonContextContextFactory : IDesignTimeDbContextFactory<HairSalonContext>
  {
    HairSalonContext IDesignTimeDbContextFactory<HairSalonContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<HairSalonContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");
      builder.UseSqlServer(connectionString);
      return new HairSalonContext(builder.Options);
    }
  }
}