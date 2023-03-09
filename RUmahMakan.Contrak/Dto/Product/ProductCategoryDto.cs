using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUmahMakan.Contrak.Dto.Product
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductDto> ProductsDtos { get; set; } 
    }
}
