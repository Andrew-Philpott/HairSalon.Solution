using Microsoft.EntityFrameworkCore;


namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    // public virtual DbSet<Appointment> Appointments { get; set; }
    public virtual DbSet<Stylist> Stylists { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options)
    {
    }

    // protected override void OnModelCreating(DbModelBuilder modelBuilder)
    // {
    //   modelBuilder.Entity<Appointment>()
    //       .HasOptional<Client>(c => c.Client)
    //       .WithMany()
    //       .WillCascadeOnDelete(false);

    //   modelBuilder.Entity<Appointment>()
    //   .HasOptional<Stylist>(s => s.Stylist)
    //   .WithMany()
    //   .WillCascadeOnDelete(false);
    // }
  }
}