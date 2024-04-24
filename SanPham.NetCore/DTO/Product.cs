using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.NetCore.DTO
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;  
    }
}
