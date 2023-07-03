using BenchmarkDotNet.Attributes;
using System.Collections;

namespace Task2
{
    [MemoryDiagnoser]
    [RankColumn]
    //[Config(typeof(AntiVirusFriendlyConfig))]
    public class Benchmark
    {
        Person oto = new("Oto", "Nozadze", 20);

        Stack<Person> stack = new();
        Queue<Person> queue = new();
        Person[] arr = new Person[] { new Person("Oto", "Nozadze", 20) };
        List<Person> list = new() { new Person("Oto", "Nozadze", 20) };
        ArrayList arrList = new ArrayList() { new Person("Oto", "Nozadze", 20) };
        Dictionary<string, object> dictionary = new() { { "oto", new Person("Oto", "Nozadze", 20) } };
        SortedList<string, Person> listSorted = new() { { "oto", new Person("Oto", "Nozadze", 20) } };
        HashSet<Person> hashSet = new() { new Person("Oto", "Nozadze", 20) };
        Hashtable hashTable = new() { { "oto", new Person("Oto", "Nozadze", 20) } };


        ////Array
        //[Benchmark]
        //public void arrayAdd()
        //{
        //    arr[0] = oto;
        //}
        //[Benchmark]
        //public void arrayIndexOf()
        //{
        //    Array.IndexOf(arr, oto);
        //}
        //[Benchmark]
        //public void arrayValueOnIndex()
        //{
        //    _ = arr[0]
        //}



        ////List 
        //[Benchmark]
        //public void ListAdd()
        //{
        //    list.Add(oto);
        //}
        [Benchmark]
        public void ListContains()
        {
            list.Contains(oto);
        }
        //[Benchmark]
        //public void ListIndexOf()
        //{
        //    var index = list.IndexOf(oto);
        //}
        //[Benchmark]
        //public void ListValueOnIndex()
        //{
        //    var value = list[0];
        //}
        //[Benchmark]
        //public void ListRemove()
        //{
        //    list.Remove(oto);
        //}


        ////ArrayList
        //[Benchmark]
        //public void arrayListAdd()
        //{
        //    arrList.Add(oto);
        //}
        [Benchmark]
        public void arrayListContains()
        {
            arrList.Contains(oto);
        }
        //[Benchmark]
        //public void arrayListIndexOf()
        //{
        //    var index = arrList.IndexOf(oto);
        //}
        //[Benchmark]
        //public void arrayListValueOnIndex()
        //{
        //    _ = arrList[0];
        //}
        //[Benchmark]
        //public void arrayListRemove()
        //{
        //    arrList.Remove(oto);
        //}


        ////Dictionary
        //[Benchmark]
        //public void DictionaryAdd()
        //{
        //    dictionary.Add("oto", oto);
        //}
        [Benchmark]
        public void dictionaryContains()
        {
            dictionary.ContainsValue(oto);
        }
        //[Benchmark]
        //public void DictionaryValueOnKey()
        //{
        //    _ = dictionary["oto"];
        //}
        //[Benchmark]
        //public void DictionaryRemove()
        //{
        //    dictionary.Remove("oto");
        //}


        ////SortedList
        //[Benchmark]
        //public void sortedListAdd()
        //{
        //    listSorted.Add("oto", oto);
        //}
        [Benchmark]
        public void sortedListContains()
        {
            listSorted.ContainsValue(oto);
        }
        //[Benchmark]
        //public void sortedListValueOnKey()
        //{
        //    _ = listSorted["oto"];
        //}
        //[Benchmark]
        //public void sortedListRemove()
        //{
        //    listSorted.Remove("oto");
        //}

        ////HashSet
        //[Benchmark]
        //public void HashSetAdd()
        //{
        //    hashSet.Add(oto);
        //}
        [Benchmark]
        public void HashSetContains()
        {
            hashSet.Contains(oto);
        }
        //[Benchmark]
        //public void HashSetRemove()
        //{
        //    hashSet.Remove(oto);
        //}


        ////HashTable
        //[Benchmark]
        //public void HashTableAdd()
        //{
        //    hashTable.Add("oto", oto);
        //}
        [Benchmark]
        public void HashTableContains()
        {
            hashTable.Contains(oto);
        }
        //[Benchmark]
        //public void HashTableValueOnKey()
        //{
        //    _ = hashTable["oto"];
        //}
        //[Benchmark]
        //public void HashTableRemove()
        //{
        //    hashTable.Remove(oto);
        //}

        ////Stack
        //[Benchmark]
        //public void StackPush()
        //{
        //    stack.Push(oto);
        //}
        [Benchmark]
        public void StackContains()
        {
            stack.Contains(oto);
        }
        //[Benchmark]
        //public void StackPeek()
        //{
        //    stack.Peek();
        //}
        //[Benchmark]
        //public void StackPop()
        //{
        //    stack.Pop();
        //}

        ////Queue
        //[Benchmark]
        //public void QueueAdd()
        //{
        //    queue.Enqueue(oto);
        //}
        [Benchmark]
        public void QueueContains()
        {
            queue.Contains(oto);
        }
        //[Benchmark]
        //public void QueueAppend()
        //{
        //    queue.Append(oto);
        //}
        //[Benchmark]
        //public void QueuePeek()
        //{
        //    queue.Peek();
        //}
        //[Benchmark]
        //public void QueueDequeue()
        //{
        //    queue.Dequeue();
        //}
    }
}

