using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFdbContext context = new EFdbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
