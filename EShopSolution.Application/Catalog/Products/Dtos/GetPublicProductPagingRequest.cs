using EShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.Application.Catalog.Products.Dtos
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
