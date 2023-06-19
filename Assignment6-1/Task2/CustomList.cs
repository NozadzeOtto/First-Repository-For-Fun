using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Generic Class with <T>
    public class CustomList<T>
    {
        public T[] List;
        private int length;

        public CustomList()
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

        public void AddElement(T elm)
        {
            if (length == List.Length)
            {
                ResizeList(length * 2);
            }
            List[length] = elm;
            length++;
        }

        public void AddList(CustomList<T> newList)
        {
            if (newList == null) 
            { 
                throw new ArgumentNullException("list"); 
            }

            if (length + newList.Count > List.Length)
            {
                ResizeList(newList.Count + length);
            }

            for (int i = 0; i < newList.Count; i++)
            {
                List[length] = newList[i];
                length++;
            }
        }

        public bool InsertElement(int index, T elm)
        {
            if (index < 0 || index > length) 
            { 
                return false; 
            }

            if (length == List.Length)
            {
                ResizeList(length * 2);
            }

            List[index] = elm;
            return true;
        }

        public bool InsertList(int index, CustomList<T> newList)
        {
            if (index < 0 || index >= length || newList == null) 
            { 
                return false; 
            }

            if(length + newList.Count > List.Length) 
            { 
                ResizeList(length + newList.Count);
            }

            for (int i = 0; i < newList.Count; i++)
            {
                List[length] = newList[i];
                length++;
            }
            return true;
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

        public bool GetList(int index, int amount, out CustomList<T> result)
        {
            result = new CustomList<T>();
            if (index < 0 || index > length || length <= 0)
            {
                return false;
            }
            for (int i = index; i < amount + index && i <= length; i++)
            {
                result.AddElement(List[i]);
            }
            return true;
        }

        public void RemoveElement(T element)
        {
            int index = Array.IndexOf(List, element, 0, length);
            
            for (int i = index; i < length-1; i++)
            {
                List[i] = List[i+1];
            }

            length--;
            List[length] = default;
        }
        public void RemoveList (int index, int amount)
        {
            if (index >= 0 && index < length && length > 0)
            {
                for (int i = index; i < amount + index && i < length; i++)
                {
                    RemoveElement(List[i]);
                }
            }
            
        }
        public void Clear() 
        { 
            //Array.Clear(List, 0, length);
            for(int i = 0; i < length; i++)
            {
                List[i] = default;
            }
            length = 0;
        }
        public T Find(T Parammeter) 
        {
            for(int i = 0; i < length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(List[i], Parammeter))
                {
                    return List[i];
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