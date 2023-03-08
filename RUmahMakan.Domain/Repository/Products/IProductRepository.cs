using RUmahMakan.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUmahMakan.Domain.Repository.Products
{
    public interface IProductRepository
    {
        Task <IEnumerable<Product>> GetAllProducts (bool trackChange);

        Task<Product> GetProductById(int id, bool trackChange);

        void Insert(Product product);

        void Edit(Product product);

        void Remove(Product product);
    }
}
