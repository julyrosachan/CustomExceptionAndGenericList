namespace CustomExceptionAndGenericList.Collections;

public class CustomList<T>
{
    private T[] items;
    private int count;

    public CustomList()
    {
        items = new T[0];
        count = 0;
    }

    public void Add(T item)
    {
        T[] newArr = new T[count + 1];

        for (int i = 0; i < count; i++)
            newArr[i] = items[i];

        newArr[count] = item;
        items = newArr;
        count++;
    }

    public void Remove(T item)
    {
        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (items[i].Equals(item))
            {
                index = i;
                break;
            }
        }

        if (index == -1)
            throw new Exception("element not found");

        T[] newArr = new T[count - 1];
        int j = 0;

        for (int i = 0; i < count; i++)
        {
            if (i == index) continue;
            newArr[j++] = items[i];
        }

        items = newArr;
        count--;
    }

    public void Clear()
    {
        items = new T[0];
        count = 0;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < count; i++)
            if (items[i].Equals(item))
                return true;

        return false;
    }

    public int Count()
    {
        return count;
    }
}