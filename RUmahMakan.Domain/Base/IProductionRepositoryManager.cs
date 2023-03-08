using RUmahMakan.Domain.Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUmahMakan.Domain.Base
{
    public interface IProductionRepositoryManager
    {
        IProductRepository ProductRepository { get; }


        void Save();

        Task SaveAsync();
    }
}
