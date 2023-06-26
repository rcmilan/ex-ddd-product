using ProductApi.Models.Products;
using System.Collections;

namespace ProductApi.Models.Offers
{
    public class ProductBundle : IEnumerable<Product>
    {
        private IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

        public IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Products.GetEnumerator();
    }
}