using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public virtual DbSet<Client> Clients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}