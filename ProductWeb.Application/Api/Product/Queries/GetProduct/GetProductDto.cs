using ProductWeb.Application.Common.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Api.Product.Queries.GetProduct
{
	public  class GetProductDto : IMapFrom<Domain.Entity.Product>
	{
		public string Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string? Picture { get; set; }
		public decimal Price { get; set; }
		public DateTime UpdatedAt { get; set; }
		public void Mapping(MappingProfile profile)
		{
			profile.CreateMap<Domain.Entity.Product, GetProductDto>();
		}
	}
}
