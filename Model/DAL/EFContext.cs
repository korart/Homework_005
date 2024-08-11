using Microsoft.EntityFrameworkCore;
using Model.Domain;

namespace Model.DAL
{
	internal class EFContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }

		public EFContext()
		{
			Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=employees.db");
		}
	}
}
