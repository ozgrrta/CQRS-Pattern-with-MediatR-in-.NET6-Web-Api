using ProductWeb.Application.Api.Product.Command.CreateProduct;
using ProductWeb.Application.Api.Product.Command.DeleteProduct;
using ProductWeb.Application.Api.Product.Command.UpdateProduct;
using ProductWeb.Application.Api.Product.Queries.GetProduct;
using ProductWeb.Application.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductWeb.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ProductController : BaseController
	{
		[HttpPost]
		public async Task<ActionResult<DefaultResponse>> CreateProduct([FromBody] CreateProductCommand command)
		{
			return Ok(await Mediator.Send(command));
		}

		[HttpPost]
		public async Task<ActionResult<DefaultResponse>> UpdateProduct([FromBody] UpdateProductCommand command)
		{
			return Ok(await Mediator.Send(command));
		}

		[HttpPost]
		public async Task<ActionResult<DefaultResponse>> DeleteProduct([FromBody] DeleteProductCommand command)
		{
			return Ok(await Mediator.Send(command));
		}

		[HttpGet]
		public async Task<ActionResult<DefaultResponse>> GetProduct([FromQuery] GetProductQuery query)
		{
			return Ok(await Mediator.Send(query));
		}
	}
}
