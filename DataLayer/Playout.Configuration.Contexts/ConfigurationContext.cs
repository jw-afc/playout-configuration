using Microsoft.EntityFrameworkCore;
using Playout.Configuration.Model;

namespace Playout.Configuration.Contexts
{
	public class ConfigurationContext : DbContext
	{
		public ConfigurationContext(DbContextOptions<ConfigurationContext> options) : base(options)
		{
		}

		public DbSet<Workstation> Workstations { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Workstation>().Property(x => x.Id).UseSqlServerIdentityColumn();
			modelBuilder.Entity<Workstation>().HasKey(x => x.Id);
			modelBuilder.Entity<Workstation>().Property(x => x.Version).IsRowVersion();
			modelBuilder.Entity<Workstation>().Property(x => x.Loaded).HasColumnType("datetime2");
			modelBuilder.Entity<Workstation>().Property(x => x.LastAccessed).HasColumnType("datetime2");
		}
	}
}
