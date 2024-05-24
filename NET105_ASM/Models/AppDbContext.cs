using Microsoft.EntityFrameworkCore;
namespace NET105_ASM.Models
{
	public class AppDbContext :DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet <Combo> Combo { get; set; }
		public DbSet <Fastfood> Fastfood { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderDetail> OrderDetail { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet <ComboFastfood> ComboFastfood { get; set; }
		 protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ComboFastfood>().HasKey(cf => new { cf.ComboId, cf.FastfoodId });

			modelBuilder.Entity<ComboFastfood>()
				.HasOne(cf => cf.Combo)
				.WithMany(c => c.Fastfood)
				.HasForeignKey(cf => cf.ComboId);

			modelBuilder.Entity<ComboFastfood>()
				.HasOne(cf => cf.Fastfood)
				.WithMany(f=> f.Combo)
				.HasForeignKey(cf => cf.FastfoodId);
		}

	}
	
}
