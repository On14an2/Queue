using System;
using System.Collections.Generic;

public class Queue<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Enqueue(T item)
    {
        list.AddLast(item);
    }

    public T Dequeue()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return list.First.Value;
    }
    public void PrintQueue()
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public int Count
    {
        get { return list.Count; }
    }

    public bool IsEmpty
    {
        get { return list.Count == 0; }
    }
}