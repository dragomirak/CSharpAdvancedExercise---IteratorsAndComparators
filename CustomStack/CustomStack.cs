
using System.Collections;

namespace CustomStack;

public class CustomStack<T> : IEnumerable<T>
{
    private readonly List<T> list;

    public CustomStack(List<T> list)
    {
        this.list = list;
    }

    public void Push(T item)
    {
        list.Add(item);
    }
    public void Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException();
        }
        else
        {
            list.RemoveAt(list.Count - 1);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
