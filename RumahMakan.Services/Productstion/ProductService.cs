using AutoMapper;
using RumahMakan.Services.Abstraction;
using RumahMakan.Services.Abstraction.Product;
using RUmahMakan.Contrak.Dto.Product;
using RUmahMakan.Domain.Base;
using RUmahMakan.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahMakan.Services.Productstion
{
    public class ProductService : IProductServices
    {
        private IProductionRepositoryManager _productionRepositoryManager;
        private readonly IMapper _mapper;

        public ProductService(IProductionRepositoryManager productionRepositoryManager, IMapper mapper)
        {
            _productionRepositoryManager = productionRepositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetProductAll(bool trackChanges)
        {
            //throw new NotImplementedException();
            var productModel = await _productionRepositoryManager.ProductRepository.GetAllProducts(trackChanges);
            var productDto = _mapper.Map<IEnumerable<ProductDto>>(productModel);
            return productDto;
        }

        public async Task<ProductDto> GetByIdProduct(int id, bool trackChange)
        {
            //throw new NotImplementedException();
            var productModel = await _productionRepositoryManager.ProductRepository.GetProductById(id, trackChange);
            var productDto = _mapper.Map<ProductDto>(productModel);
            return productDto;
        }

        public void Insert(ProductForCreateDto productForCreateDto)
        {
            //throw new NotImplementedException();
            var productModel = _mapper.Map<Product>(productForCreateDto);
            _productionRepositoryManager.ProductRepository.Insert(productModel);
            _productionRepositoryManager.Save();
        }

        public void Edit(ProductDto productDto)
        {
            //throw new NotImplementedException();
            var productModel = _mapper.Map<Product>(productDto);
            _productionRepositoryManager.ProductRepository.Edit(productModel);
            _productionRepositoryManager.Save();
        }

        public void Remove(ProductDto productDto)
        {
            //throw new NotImplementedException();
            var productModel = _mapper.Map<Product>(productDto);
            _productionRepositoryManager.ProductRepository.Remove(productModel);
            _productionRepositoryManager.Save();
        }
    }
}
