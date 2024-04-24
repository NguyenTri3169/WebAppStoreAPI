using SanPham.NetCore.DAO;
using SanPham.NetCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.NetCore.DAOImpl
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();
        public Product AddProduct(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return product;
        }

        public void DeleteProduct(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    products.Add(new Product
                    {
                        Id = i,
                        ProductName = "ProductName" + i,
                        Price = i,
                        Image = "Image" + i
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return products;
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
