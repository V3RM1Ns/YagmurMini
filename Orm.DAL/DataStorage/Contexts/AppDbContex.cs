using Microsoft.EntityFrameworkCore;
using Orm.Core.Entities;
using Orm.DAL.Configurations;

namespace Orm.DAL.DataStorage.Contexts;

public class AppDbContex : DbContext
{
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Table> Tables { get; set; }

    public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) // Only configure if not already configured via constructor
        {
            string connection="Server=localhost,1433;Database=MiniOrm;User Id=sa;Password=Hebib123!;Encrypt=False;";
            optionsBuilder.UseSqlServer(connection);
        }
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TableConfig).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderConfig).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MenuItemConfig).Assembly); 
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderItemConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}