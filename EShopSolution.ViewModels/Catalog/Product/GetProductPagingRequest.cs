using EShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.ViewModels.Catalog.Product
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
