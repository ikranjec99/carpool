using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Application.Common.Models
{
    public class QueryOptions
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public QueryOptions()
        {
            PageSize = PageSize > 0 ? PageSize : 10;
            PageNumber = PageNumber > 0 ? PageNumber : 1;
        }
    }
}
