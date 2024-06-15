using Microsoft.EntityFrameworkCore;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.DataAccess.Context
{
	public class Context : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-26KIC6Q\\SQLEXPRESS;Database=DbMyAcademyCQRSPattern;integrated security=true;trustServerCertificate=true;");
		}

		public DbSet<Customer> Customers { get; set; }

	}
}
