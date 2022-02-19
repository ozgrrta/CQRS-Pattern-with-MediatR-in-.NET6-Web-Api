using ProductWeb.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Common.Validator
{
	public class ProductValidate : IProductValidate
	{
		public bool Validate(decimal price)
		{
			if (price > 0.00m && price < 999.00m)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
