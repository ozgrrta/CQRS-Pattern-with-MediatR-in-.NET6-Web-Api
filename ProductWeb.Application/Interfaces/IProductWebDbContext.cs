using ProductWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Interfaces
{
	public  interface IProductWebDbContext
	{
		public DbSet<Product> Products { get;set; }

		Task<int> SaveChangesAsync(CancellationToken cancellationToken);
		int SaveChanges();
		DatabaseFacade Database { get; }

	}
}
