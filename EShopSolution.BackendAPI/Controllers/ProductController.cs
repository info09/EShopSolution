using EShopSolution.Application.Catalog.Products;
using EShopSolution.ViewModels.Catalog.Product;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShopSolution.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var product = await _publicProductService.GetAll(languageId);
            return Ok(product);
        }

        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> GetCategoryId([FromQuery]GetPublicProductPagingRequest request)
        {
            var product = await _publicProductService.GetAllByCategoryId(request);
            return Ok(product);
        }

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _manageProductService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreate request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService.Create(request);
            if(result == 0)
            {
                return BadRequest();
            }

            var productId = await _manageProductService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _manageProductService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]ProductUpdate request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _manageProductService.Delete(id);
            if (product == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccess = await _manageProductService.UpdatePrice(productId, newPrice);
            if (!isSuccess)
                return BadRequest();
            return Ok();
        }
    }
}