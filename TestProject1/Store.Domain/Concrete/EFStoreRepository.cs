using System;
using System.Collections.Generic;
using Store.Domain.Abstract;

namespace Store.Domain.Concrete
{
    public class EFStoreRepository : IProductRepository
    {
        ShopDatabaseEntities1 context = new ShopDatabaseEntities1();

        public IEnumerable<Products> Products
        {
            get { return context.Products; }
        }
    }
}
