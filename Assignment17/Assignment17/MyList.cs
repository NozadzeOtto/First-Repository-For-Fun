using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment17
{
    public class MyList<T>
    {
        public T[] List;
        private int length;

        public MyList()
        {
            List = new T[1];
            length = 0;
        }

        public int Count
        {
            get { return length; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > length) { throw new IndexOutOfRangeException(); }
                return List[index];
            }
            set
            {
                if (index < 0 || index > length) { throw new IndexOutOfRangeException(); }
                List[index] = value;
            }
        }

        public void Add(T obj)
        {
            if (length == List.Length)
            {
                ResizeList(length * 2);
            }
            List[length] = obj;
            length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection");
            }

            int collectionCount = collection.Count();

            if (length + collectionCount > List.Length)
            {
                ResizeList(collectionCount + length);
            }

            foreach (T item in collection)
            {
                List[length] = item;
                length++;
            }
        }

        public bool GetElement(int index, out T result)
        {
            if (index < 0 || index > length)
            {
                result = default; return false;
            }

            result = List[index];
            return true;
        }

        public void Remove(T obj)
        {
            int index = Array.IndexOf(List, obj, 0, length);

            for (int i = index; i < length - 1; i++)
            {
                List[i] = List[i + 1];
            }

            length--;
            ResizeList(length);
        }

        public void RemoveRange(int index, int amount)
        {
            if (index >= 0 && index < length && length > 0)
            {
                for (int i = index; i < amount + index && i < length; i++)
                {
                    Remove(List[index]);
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                List[i] = List[i + 1];
            }

            length--;
            ResizeList(length);
        }

        public bool Contains(T item)
        {
            return length != 0 && Array.IndexOf(List, item) != -1;
        }

        public T Find(Predicate <T> condition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException("Invalid Condition");
            }
            foreach (T item in List)
            {
                if (condition(item))
                {
                    return item;
                }
            }
            return default;
        }

        public T Single(Predicate<T> condition)
        {
            T result = default;
            if (condition == null)
            {
                throw new ArgumentNullException("Invalid Condition");
            }
            foreach (T item in List)
            {
                if (condition(item))
                {
                    if(!result.Equals(default(T))) throw new InvalidOperationException("More Than one element found with that confition");
                    result = item;
                }
            }
            if (result.Equals(default(T))) throw new InvalidOperationException("Can't find element with that confition");
            return result;
        }

        public T SingleOrDefault(Predicate<T> condition)
        {
            T result = default;
            if (condition == null)
            {
                throw new ArgumentNullException("Invalid Condition");
            }
            foreach (T item in List)
            {
                if (condition(item))
                {
                    return item;
                }
            }
            return default;
        }

        private void ResizeList(int size)
        {
            Array.Resize(ref List, size);
        }
    }

}