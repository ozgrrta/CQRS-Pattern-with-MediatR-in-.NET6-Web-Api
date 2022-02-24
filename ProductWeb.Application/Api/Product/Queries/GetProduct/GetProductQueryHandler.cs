using ProductWeb.Application.Common;
using ProductWeb.Application.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Queries.GetProduct
{
	public class GetProductQueryHandler : IRequestHandler<GetProductQuery, DefaultResponse<GetProductDto>>
	{
		private readonly IProductWebDbContext _context;
		private readonly IMapper _mapper;
		public GetProductQueryHandler(IProductWebDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<DefaultResponse<GetProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
		{
			return await GetProduct(request, cancellationToken);
		}

		private async Task<DefaultResponse<GetProductDto>> GetProduct(GetProductQuery request, CancellationToken cancellationToken)
		{
			var response = new DefaultResponse<GetProductDto>();
			response.Success = false;

			var product = await _context.Products.FirstOrDefaultAsync(i => i.Id == request.Id);

			if (product == null)
			{
				response.ResultText = "No product found";
				return response;
			}

			response.Result = _mapper.Map<GetProductDto>(product);
			response.Success = true;
			response.ResultText = "Success";
			return response;
		}
	}
}
