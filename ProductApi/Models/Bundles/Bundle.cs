using System.Collections;
using System.Collections.ObjectModel;

namespace ProductApi.Models.Bundles;

public abstract record Bundle<T> : ICollection<T> where T : class
{
    private readonly ICollection<T> Contents = new Collection<T>();

    public int Count => Contents.Count;

    public bool IsReadOnly => Contents.IsReadOnly;

    public void Add(T item)
    {
        Contents.Add(item);
    }

    public void Clear()
    {
        Contents.Clear();
    }

    public bool Contains(T item) => Contents.Contains(item);

    public void CopyTo(T[] array, int arrayIndex)
    {
        Contents.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator() => Contents.GetEnumerator();

    public bool Remove(T item) => Contents.Remove(item);

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Contents).GetEnumerator();
}