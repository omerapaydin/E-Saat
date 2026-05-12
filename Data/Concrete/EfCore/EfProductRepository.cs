using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESaat.Data.Abstract;
using ESaat.Entity;

namespace ESaat.Data.Concrete.EfCore
{
    public class EfProductRepository : IProductRepository
    {

        private readonly IdentityContex _identityContex;
        public EfProductRepository(IdentityContex identityContex)
        {
            _identityContex = identityContex;
        }
        public IQueryable<Product> Products => _identityContex.Products;

        public void Create(Product product)
        {
            _identityContex.Products.Add(product);
            _identityContex.SaveChanges();
        }
    }
}