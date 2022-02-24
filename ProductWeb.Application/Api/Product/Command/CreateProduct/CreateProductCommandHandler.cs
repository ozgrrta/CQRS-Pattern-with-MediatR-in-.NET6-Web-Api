using ProductWeb.Application.Common;
using ProductWeb.Application.Common.Validator;
using ProductWeb.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Command.CreateProduct
{
	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, DefaultResponse>
	{
		private readonly IProductWebDbContext _context;
		private IProductValidate _checker;
		public CreateProductCommandHandler(IProductWebDbContext context, IProductValidate checker)
		{
			_context = context;
			_checker = checker;
		}
		public async Task<DefaultResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
		{
			return await CreateProduct(request, cancellationToken);
		}

		public async Task<DefaultResponse> CreateProduct(CreateProductCommand request, CancellationToken cancellationToken)
		{
			var response = new DefaultResponse();
			response.Success = false;

			var isValid = _checker.Validate(request.Price);
			if (!isValid)
			{
				response.ResultText = "Price for a product must have value between 0-999";
				return response;
			}

			Domain.Entity.Product product = new Domain.Entity.Product()
			{
				Price = request.Price,
				Code = request.Code,
				Name = request.Name,
				Picture = request.Picture,
			};

			_context.Products.Add(product);
			await _context.SaveChangesAsync(cancellationToken);

			response.Success = true;
			response.ResultText = "Success";

			return response;
		}
	}
}
