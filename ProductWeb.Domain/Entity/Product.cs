using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Domain.Entity
{
	public class Product
	{
		[Key]
		public string Id { get; set; } = Guid.NewGuid().ToString();
		[Required]
		public string Code { get; set; }
		[Required]
		public string Name { get; set; }
		public string? Picture { get; set; }
		[Required]
		[Range(typeof(decimal), "0", "999")]
		public decimal Price { get; set; }
		[Required]
		public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
	}
}
