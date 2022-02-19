using ProductWeb.Application.Common;
using ProductWeb.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Command.DeleteProduct
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DefaultResponse>
	{
		private readonly IAssignmentDbContext _context;
		public DeleteProductCommandHandler(IAssignmentDbContext context)
		{
			_context = context;
		}

		public async Task<DefaultResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
		{
			return await DeleteProduct(request, cancellationToken);
		}

		public async Task<DefaultResponse> DeleteProduct(DeleteProductCommand request, CancellationToken cancellationToken)
		{
			var response = new DefaultResponse();
			response.Success = false;

			var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == request.Id);

			if (product == null)
			{
				response.ResultText = "No product found";
				return response;
			}

			_context.Products.Remove(product);
			await _context.SaveChangesAsync(cancellationToken);

			response.Success = true;
			response.ResultText = "Success";
			return response;
		}
	}
}
