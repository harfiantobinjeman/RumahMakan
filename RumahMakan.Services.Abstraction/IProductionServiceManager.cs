using RumahMakan.Services.Abstraction.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahMakan.Services.Abstraction
{
    public interface IProductionServiceManager
    {
        IProductServices ProductServiceses { get; }
    }
}
