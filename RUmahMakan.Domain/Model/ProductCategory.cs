using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUmahMakan.Domain.Model
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Category { get; set; }
    }
}
