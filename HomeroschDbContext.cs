using HomeroSCHApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeroSCHApi;

public class HomeroschDbContext : DbContext
{
    public DbSet<Measurement> Measurements { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Location> Locations { get; set; }


    public HomeroschDbContext(DbContextOptions o) : base(o) {}
}