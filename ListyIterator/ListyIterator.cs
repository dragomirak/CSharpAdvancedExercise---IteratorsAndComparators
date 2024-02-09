using System.Collections;

namespace ListyIterator;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> list;
    int index = 0;

    public ListyIterator(List<T> list)
    {
        this.list = list;
    }

   

    public bool HasNext()
    {
        return index < list.Count - 1;
    }
    public bool Move()
    {
        if(HasNext())
        {
            index++;
            return true;
        }

        return false;
    }
    public void Print()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(list[index]);
        }
    }

    public void PrintAll()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        else
        {
            foreach(T item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        yield return list[index++];
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
