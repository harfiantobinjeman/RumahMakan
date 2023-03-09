using RUmahMakan.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUmahMakan.Contrak.Dto.Product
{
    public class ProductForCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<ProductCategoryDto> Category { get; set; }
    }
}
