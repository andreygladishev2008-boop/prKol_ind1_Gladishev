using System;
using System.Collections.Generic;

namespace zadanie_7._2
{
    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (Count == 0) throw new InvalidOperationException("Очередь пуста");
            T item = items[0];
            items.RemoveAt(0);
            return item;
        }

        public void Clear()
        {
            items.Clear();
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }
}
