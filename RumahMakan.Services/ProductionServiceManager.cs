using AutoMapper;
using RumahMakan.Services.Abstraction;
using RumahMakan.Services.Abstraction.Product;
using RumahMakan.Services.Productstion;
using RUmahMakan.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahMakan.Services
{
    public class ProductionServiceManager : IProductionServiceManager
    {
        private readonly Lazy<IProductServices> _lazyProductServices;

        public ProductionServiceManager(IProductionRepositoryManager productionRepositoryManager, IMapper mapper)
        {
            _lazyProductServices = new Lazy<IProductServices>(
                () => new ProductService (productionRepositoryManager, mapper));
        }
        public IProductServices ProductServiceses => _lazyProductServices.Value;
    }
}
