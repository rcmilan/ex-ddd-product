using System.Collections;
using System.Collections.ObjectModel;

namespace ProductApi.Models.Prices
{
    public record PricingCollection : Pricing, ICollection<PricingRange>
    {
        public int Count => Values.Count;

        public bool IsReadOnly => Values.IsReadOnly;

        private readonly ICollection<PricingRange> Values = new Collection<PricingRange>();

        public void Add(PricingRange item)
        {
            Values.Add(item);
        }

        public void Clear()
        {
            Values.Clear();
        }

        public bool Contains(PricingRange item) => Values.Contains(item);

        public void CopyTo(PricingRange[] array, int arrayIndex)
        {
            Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<PricingRange> GetEnumerator() => Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Values).GetEnumerator();

        public bool Remove(PricingRange item) => Values.Remove(item);

        public PricingRange? FirstInRange(int value) => Values.FirstOrDefault(v => v.From <= value && value <= v.To);
    }
}