using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Interfaces
{
	public interface IProductValidate
	{
		bool Validate(decimal price);
	}
}
