using ProductWeb.Application.Common;
using ProductWeb.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Command.UpdateProduct
{
	public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, DefaultResponse>
	{
		private readonly IProductWebDbContext _context;
		private IProductValidate _checker;
		public UpdateProductCommandHandler(IProductWebDbContext context, IProductValidate checker)
		{
			_context = context;
			_checker = checker;
		}
		public async Task<DefaultResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
		{
			return await UpdateProduct(request, cancellationToken);
		}

		public async Task<DefaultResponse> UpdateProduct(UpdateProductCommand request, CancellationToken cancellationToken)
		{
			var response = new DefaultResponse();
			response.Success = false;
			bool isValid = false;

			var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == request.Id);

			if (product == null)
			{
				response.ResultText = "No product found";
				return response;
			}

			if (request.Price != null)
			{
				isValid = _checker.Validate((decimal)request.Price);

				if (!isValid)
				{
					response.ResultText = "Price for a product must have value between 0-999";
					return response;
				}
			}

			product.Code = request.Code ?? product.Code;
			product.Name = request.Name ?? product.Name;
			product.Picture = request.Picture ?? product.Picture;
			product.Price = request.Price ?? product.Price;
			product.UpdatedAt = request.UpdatedAt != null ? (DateTime)request.UpdatedAt : product.UpdatedAt;

			_context.Products.Update(product);
			await _context.SaveChangesAsync(cancellationToken);

			response.Success = true;
			response.ResultText = "Success";
			return response;
		}
	}
}
