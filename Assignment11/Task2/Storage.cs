using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Storage<T>
    {
        private T[] storage;
        private int length;
        public Storage()
        {
            storage = new T[1];
            length = 0;
        }

        public int count
        {
            get { return length; }
        }

        public T this[int index]
        {
            get 
            { 
                if (index < 0 || index >= length) { throw new IndexOutOfRangeException("Index out of range."); }
                return storage[index];
            }
            set 
            {
                if (index < 0 || index >= length) { throw new IndexOutOfRangeException("Index out of range."); }
                storage[index] = value;
            }
        }

        public void Add(T item)
        {
            if(length >= storage.Length) 
            {
                ResizeStorage((length + 1) * 2);
            }
            storage[length] = item;
            length++;
        }

        public void UpdateElement(T item, T newItem) 
        {
            int index = Array.IndexOf(storage, item);
            if (index == -1) throw new Exception ("Can't find item '" + item + "' in storage");
            
            if(newItem == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }
            storage[index] = newItem;
        }

        public void Remove(T item) 
        {
            int index = Array.IndexOf(storage, item);
            if (index == -1) throw new Exception("Can't find item '" + item + "' in storage");
            
            if (item == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }

            for (int i = index ; i < length-1; i++)
            {
                storage[i] = storage[i + 1];
            }
            length--;
            storage[length] = item;
        }

        public void Clear()
        {
            ResizeStorage(0);
            length = 0;
        }

        private void ResizeStorage(int size)
        {
            Array.Resize(ref storage, size);
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += storage[i].ToString() + ", ";
            }
            return result;
        }
    }
}
