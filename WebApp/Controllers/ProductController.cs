using Microsoft.AspNetCore.Mvc;
using SanPham.NetCore.DAO;
using SanPham.NetCore.DTO;

namespace WebApp.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpPost("GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        [HttpPost("AddProduct")]
        public Product AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return Ok();
        }

    }
}
