using ProductWeb.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Persistence
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configure)
		{
			var currentDb = configure.GetConnectionString("CurrentDb");
			var connectionString = configure.GetConnectionString(currentDb);

			if (currentDb == "postgre")
			{
				services.AddDbContext<AssignmentDbContext>(options =>
					options.UseNpgsql(connectionString, o =>
						o.MigrationsHistoryTable("__MigrationHistoryOfCore")));

				services.AddTransient<IAssignmentDbContext>(provider => provider.GetService<AssignmentDbContext>());
			}

			return services;
		}
	}
}
