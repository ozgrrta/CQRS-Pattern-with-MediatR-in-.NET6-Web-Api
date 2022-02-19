using ProductWeb.Application.Interfaces;
using ProductWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Persistence
{
	public class AssignmentDbContext : DbContext, IAssignmentDbContext
	{
		public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Product> products = new List<Product>();

			for (int i = 1; i < 21; i++)
			{
				Product product = new Product()
				{
					Id = Guid.NewGuid().ToString(),
					Name = "Product_" + i,
					Code = Guid.NewGuid().ToString().Split("-").First(),
					Price = (decimal)System.Math.Round(decimal.Parse((new Random().Next(50, 100) * new Random().NextDouble()).ToString()),2),
					Picture = "http://www.example.com/" + Guid.NewGuid().ToString().Split("-").First(),
					UpdatedAt = DateTime.UtcNow
				};

				products.Add(product);
			}

			modelBuilder.Entity<Product>().HasData(products);

			modelBuilder.Entity<Product>().HasIndex(e => e.Code).IsUnique();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}
