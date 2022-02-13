using Consultant.Server.Data;
using Consultant.Shared.Entity.Api;

namespace Consultant.Server.Model
{
    public class ProductRepository
    {
        public Product GetById(Guid id)
        {
            return AllData.Products[id];
        }

        public IEnumerable<Product> GetAll()
        {
            return AllData.Products.Values;
        }

        public IEnumerable<Product> GetByKeywords(string keywords)
        {
            var products = GetAll();

            if (!string.IsNullOrEmpty(keywords))
            {
                keywords = keywords.Trim().ToLower();

                products = products
                    .Where(
                        x => x.Name.ToLower().Contains(keywords)
                        || x.Description.ToLower().Contains(keywords)
                    );
            }

            return products;
        }
    }
}
