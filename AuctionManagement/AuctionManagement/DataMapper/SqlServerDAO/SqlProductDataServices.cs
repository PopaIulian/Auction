

namespace AuctionManagement.DataMapper.SqlServerDAO
{
  using System.Collections.Generic;
    using System.Linq;
    using AuctionManagement.DomainModel;

    class SqlProductDataServices : IProductDataServices
    {
        public void AddObject(Product product)
        {
            using (Context context = new Context())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void DeleteObject(Product product)
        {
            using (Context context = new Context())
            {
                Product toBeDeleted = new Product { IdProduct = product.IdProduct };
                context.Products.Attach(toBeDeleted);
                context.Products.Remove(toBeDeleted);
                context.SaveChanges();
            }
        }

        public Product GetObjectById(int id)
        {
            using (Context context = new Context())
            {
                return context.Products.Where(product => product.IdProduct == id).SingleOrDefault();
            }
        }

        public IList<Product> GettAllObjects()
        {
            using (Context context = new Context())
            {
                return context.Products.Select(product => product).ToList();
            }
        }

        public void UpdateObject(Product product)
        {
            using (Context context = new Context())
            {
                Product toBeUpdated = context.Products.Find(product.IdProduct);

                if (toBeUpdated == null)
                {
                    return;
                }
                context.Entry(toBeUpdated).CurrentValues.SetValues(product);
                context.SaveChanges();
            }
        }
    }
}
