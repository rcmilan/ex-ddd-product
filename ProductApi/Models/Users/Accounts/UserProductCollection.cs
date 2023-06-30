using ProductApi.Models.Products;
using System.Collections;

namespace ProductApi.Models.Users.Accounts
{
    public record UserProductCollection : ICollection<Product>
    {
        private readonly ICollection<Product> Products = new List<Product>();

        public int Count => Products.Count;

        public bool IsReadOnly => Products.IsReadOnly;

        public void Add(Product item)
        {
            Products.Add(item);
        }

        public void Clear()
        {
            Products.Clear();
        }

        public bool Contains(Product item) => Products.Contains(item);

        public void CopyTo(Product[] array, int arrayIndex)
        {
            Products.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        public bool Remove(Product item) => Products.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Products).GetEnumerator();
    }
}