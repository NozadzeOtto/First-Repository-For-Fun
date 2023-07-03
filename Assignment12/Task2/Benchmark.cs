using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Benchmark
    {
        Person oto = new("Oto", "Nozadze", 20);

        Stack<Person> stack = new();
        Person[] arr = new Person[1];
        List<Person> list = new();
        ArrayList arrList = new ArrayList();
        Dictionary<string, object> dictionary = new();
        SortedList<string, Person> listSorted = new();
        HashSet<Person> hashSet = new();
        Hashtable hashTable = new();
        Queue<Person> queue = new();

        // Array 
        [Benchmark]
        public void array()
        {
            arr[0] = oto;

            //Array.IndexOf(arr, oto);

            //_ = arr[0];
        }


        //List 
        [Benchmark]
        public void List()
        {
            list.Add(oto);

            //list.Contains(oto);

            //var index = list.IndexOf(oto);

            //var value = list[index];

            //list.Remove(oto);

        }


        //ArrayList
        [Benchmark]
        public void arrayList()
        {
            arrList.Add(oto);

            //arrList.Contains(oto);

            //var index = arrList.IndexOf(oto);

            //_ = arrList[index];

            //arrList.Remove(oto);
        }


        //Dictionary
        [Benchmark]
        public void Dictionary()
        {
            dictionary.Add("oto", oto);

            //_ = dictionary["oto"];

            //dictionary.Remove("oto");
        }


        //SortedList
        [Benchmark]
        public void sortedList()
        {
            listSorted.Add("oto", oto);

            //_ = listSorted["oto"];

            //listSorted.Remove("oto");
        }

        //HashSet
        [Benchmark]
        public void HashSet()
        {
            hashSet.Add(oto);

            //hashSet.Contains(oto);

            //hashSet.Remove(oto);
        }

        //HashTable
        [Benchmark]
        public void HashTable()
        {
            hashTable.Add("oto", oto);

            //hashTable.Contains(oto);

            //_ = hashTable["oto"];

            //hashTable.Remove(oto);
        }

        //Stack
        [Benchmark]
        public void Stack()
        {
            stack.Push(oto);

            //stack.Contains(oto);

            //stack.Peek();
                
            //stack.Pop();

        }

        //Queue
        [Benchmark]
        public void Queue()
        {
            queue.Enqueue(oto);

            //queue.Contains(oto);
            
            //queue.Append(oto);
            
            //queue.Peek();

            //queue.Dequeue();
        }
    }
}

