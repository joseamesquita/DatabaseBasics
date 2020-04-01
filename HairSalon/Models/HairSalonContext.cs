using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual DbSet<Client> Client { get; set; }
    public DbSet<Stylist> Stylist { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}