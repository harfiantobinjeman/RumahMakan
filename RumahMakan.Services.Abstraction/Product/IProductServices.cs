using RUmahMakan.Contrak.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahMakan.Services.Abstraction.Product
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDto>> GetProductAll(bool trackChanges);

        Task<ProductDto> GetByIdProduct(int id, bool trackChange);

        void Insert(ProductForCreateDto productForCreateDto);

        void Edit(ProductDto productDto);

        void Remove(ProductDto productDto);

    }
}
