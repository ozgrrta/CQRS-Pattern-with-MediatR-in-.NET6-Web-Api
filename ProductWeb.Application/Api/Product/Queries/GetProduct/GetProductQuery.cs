using ProductWeb.Application.Common;
using MediatR;

namespace ProductWeb.Application.Api.Product.Queries.GetProduct
{
	public class GetProductQuery : IRequest<DefaultResponse<GetProductDto>>
	{
		public string Id { get; set; }
	}
}
