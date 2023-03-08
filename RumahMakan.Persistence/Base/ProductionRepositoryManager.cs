using Microsoft.EntityFrameworkCore;
using RumahMakan.Persistence.Repositories.Productions;//
using RumahMakan.Persistence.RepositoryContext;
using RUmahMakan.Domain.Base;//
using RUmahMakan.Domain.Repository.Products;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//

namespace RumahMakan.Persistence.Base
{
    public class ProductionRepositoryManager : IProductionRepositoryManager
    {
        private RumahMakanDbContext _rumahMakanDbContext;
        private IProductRepository _productRepository;

        public ProductionRepositoryManager(RumahMakanDbContext rumahMakanDbContext)
        {
            _rumahMakanDbContext = rumahMakanDbContext;
        }
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_rumahMakanDbContext);
                }
                return _productRepository;
            }
        }

        public void Save() => _rumahMakanDbContext.SaveChanges();

        public async Task SaveAsync() => await _rumahMakanDbContext.SaveChangesAsync();
    }
}
