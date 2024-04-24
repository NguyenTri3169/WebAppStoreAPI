using SanPham.NetCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.NetCore.DAO
{
    public  interface IProductRepository
    {
        Product AddProduct(Product product);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
