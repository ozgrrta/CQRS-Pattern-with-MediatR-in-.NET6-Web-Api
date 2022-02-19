using ProductWeb.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Command.DeleteProduct
{
	public class DeleteProductCommand : IRequest<DefaultResponse>
	{
		public string Id { get; set; }
	}
}
