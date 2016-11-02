using System.Collections.Generic;
using Store.Domain.Concrete;

namespace Store.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Products> Products { get; }
    }
}
