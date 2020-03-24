using EShopSolution.ViewModels.Catalog.Product;
using EShopSolution.ViewModels.Catalog.ProductImage;
using EShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreate request);

        Task<int> Update(ProductUpdate request);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreate request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdate request);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}
