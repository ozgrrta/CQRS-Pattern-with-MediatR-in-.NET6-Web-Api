using ProductWeb.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Command.UpdateProduct
{
	public class UpdateProductCommand : IRequest<DefaultResponse>
	{
		public string Id { get; set; }
		public string? Code { get; set; }
		public string? Name { get; set; }
		public string? Picture { get; set; }
		public decimal? Price { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
