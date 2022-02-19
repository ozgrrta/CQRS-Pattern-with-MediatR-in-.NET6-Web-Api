using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.Application.Common
{
    public class DefaultResponse<T>
    {
        public bool Success { get; set; }
        public T Result { get; set; }
        public string ResultText { get; set; }
    }

    public class DefaultResponse
    {
        public bool Success { get; set; }
        public string ResultText { get; set; }
    }
}
