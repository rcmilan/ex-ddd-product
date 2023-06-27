using System.Collections;
using System.Collections.ObjectModel;

namespace ProductApi.Models.Prices
{
    public record PricingCollection<T> : Pricing, ICollection<T> where T : Pricing
    {
        public int Count => Values.Count;

        public bool IsReadOnly => Values.IsReadOnly;

        private readonly ICollection<T> Values = new Collection<T>();

        public void Add(T item)
        {
            Values.Add(item);
        }

        public void Clear()
        {
            Values.Clear();
        }

        public bool Contains(T item) => Values.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
        {
            Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator() => Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Values).GetEnumerator();

        public bool Remove(T item) => Values.Remove(item);
    }
}