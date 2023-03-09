using Microsoft.EntityFrameworkCore;
using RumahMakan.Persistence.Base;
using RumahMakan.Persistence.RepositoryContext;
using RUmahMakan.Domain.Model;
using RUmahMakan.Domain.Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahMakan.Persistence.Repositories.Productions
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RumahMakanDbContext dbContext) : base(dbContext)
        {
        }

        public void Edit(Product product)
        {
            //throw new NotImplementedException();
            Update(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts(bool trackChange)
        {
            //throw new NotImplementedException();
            return await FindAll(trackChange).OrderBy(s => s.CategoryId)
                .Include(p => p.Category)
                .ToListAsync();
            /*var result = await _dbContext.Products.FromSqlRaw("Select * from Products" +
                "join ProductCategories on ProductCategories.Id = Products.CategoryId").ToListAsync();
            return result;*/
        }

        public async Task<Product> GetProductById(int id, bool trackChange)
        {
            //throw new NotImplementedException();
            return await FindByCondition(s=> s.Id.Equals(id), trackChange)
                .Include(p => p.Category)
                .SingleOrDefaultAsync();
        }

        public void Insert(Product product)
        {
            //throw new NotImplementedException();
            Create(product);
        }

        public void Remove(Product product)
        {
            //throw new NotImplementedException();
            Delete(product);
        }
    }
}
