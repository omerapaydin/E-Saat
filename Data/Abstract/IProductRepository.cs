using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESaat.Entity;

namespace ESaat.Data.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void Create(Product product);
    }
}