using System.Collections;
using System.Numerics;
using Task1;

Person oto = new("Oto", "Nozadze", 20);
Person nuca = new("Nuca", "Aphtsiashvili", 19);
Person chad = new("Giga", "Chad", 32);
Person sxva = new("Sxva", "Sxvauri", 100);
Person jumber = new("Jumber", "Mesxi", 199);




// Array - Add, IdexOf, Reverse, Fill, Sort
Console.WriteLine("---------------------- Array");
string[] arr = new string[2];
arr[0] = "Oto";
arr[1] = "Nozadze";
Array.Resize(ref arr, arr.Length * 2);
arr[2] = "Graphics Designer";

arr[Array.IndexOf(arr, "Graphics Designer")] = "Developer";
foreach (string str in arr) if (str != null) Console.Write(str + ", ");
Console.WriteLine(" - IdexOf");

Array.Sort(arr);
foreach (string str in arr) if (str != null) Console.Write(str + ", ");
Console.WriteLine(" - Sort");

Array.Reverse(arr);
foreach (string str in arr) if (str != null) Console.Write(str + ", ");
Console.WriteLine(" - Reverse");

Array.Fill(arr, "none");
foreach (string str in arr) if (str != null) Console.Write(str + ", ");
Console.WriteLine(" - Fill with 'none'");




//List - Sort(IComparer), Contains, InsertRange, Equals, Exists, IndexOf in range
Console.WriteLine("\n---------------------- List ");
List<Person> List = new() { oto, nuca, chad };
List.Sort(new PersonComparer());
foreach (var str in List) if (str != null) Console.Write(str.Name + ", ");
Console.WriteLine(" - Sort with comparer");

var containsListOto = List.Contains(oto);
Console.WriteLine("List Contains Oto? " + containsListOto);

List.InsertRange(1, new List<Person> { sxva, jumber });
foreach (var str in List) if (str != null) Console.Write(str.Name + ", ");
Console.WriteLine(" - InsertRange");

var ListSame = List;
Console.WriteLine("arrList equals arrListSame? " + List.Equals(ListSame));

var ExistsOtoInList = List.Exists(person => oto.Name == "Oto");
Console.WriteLine("name 'Oto' exists in arrList? " + ExistsOtoInList);

var IndexOfThreeParameter = List.IndexOf(nuca, 2, List.Count - 2);
Console.WriteLine("IndexOF 'nuca' in range [2:] - " + IndexOfThreeParameter);




//ArrayList - Count, Capacity, RemoveRange
Console.WriteLine("\n---------------------- ArrayList ");
var arrList = new ArrayList(12) { oto, nuca, "Developers", "TBC", 2, true };
var arrListCount = arrList.Count;
Console.WriteLine("Count - " + arrListCount);
var arrListCapacity = arrList.Capacity;
Console.WriteLine("Capacity - " + arrListCapacity);
foreach (var str in arrList) if (str != null) Console.Write(str + ", ");
Console.WriteLine();

arrList.RemoveRange(3, arrList.Count - 3);
foreach (var str in arrList) if (str != null) Console.Write(str + ", ");
Console.WriteLine();




//Dictionary - TryGetValue, Add, 
Console.WriteLine("\n---------------------- Dictionary ");
var dictionary = new Dictionary<string, object>(50)
{
    { "oto", oto },
    { "nuca", nuca },
    { "chad", chad }
};
Person gotValue;
if (dictionary.TryGetValue("oto", out var value)) { gotValue = (Person)value; Console.WriteLine("TryGetValue with 'oto' : " + gotValue.Name + " " + gotValue.Surname); }

dictionary.Add("sxva", sxva);
foreach (Person dict in dictionary.Values.Cast<Person>())
{
    Console.Write(dict.Name + ", ");
}

Console.WriteLine();

Person getValueWithKey = (Person)dictionary["nuca"];
Console.WriteLine("Get value with Key(nuca) - " + getValueWithKey.Name + " " + getValueWithKey.Surname);




//SortedList
Console.WriteLine("\n---------------------- SortedList");
SortedList<string, Person> listSorted = new()
{
    { "oto", oto },
    { "nuca", nuca },
    { "giga", chad },
    { "sxva", sxva }
};

foreach (Person person in listSorted.Values)
{
    Console.Write(person.Name + ", ");
}
Console.WriteLine();




//HashSet
Console.WriteLine("\n---------------------- HashSet");
HashSet<Person> hashSet = new();
foreach (Person person in listSorted.Values) hashSet.Add(person);
foreach (Person person in hashSet) Console.Write(person.Name + ", ");
Console.WriteLine();




//HashTable
Console.WriteLine("\n---------------------- HashTable");
Hashtable hashTable = new(listSorted)
{
    { "jumber", jumber }
};
foreach (Person person in hashTable.Values) Console.Write(person.Name + ", ");
Console.WriteLine();
hashTable.Remove("oto");
foreach (Person person in hashTable.Values) Console.Write(person.Name + ", ");
Console.WriteLine();




//Stack
Console.WriteLine("\n---------------------- Stack");
Stack<Person> stack = new();
stack.Push(oto); stack.Push(nuca); stack.Push(chad);
foreach (Person person in stack) Console.Write(person.Name + ", ");
Console.WriteLine();
stack.Pop();
foreach (Person person in stack) Console.Write(person.Name + ", ");
Console.WriteLine();
for (int i = 0; i < stack.Count; i++) Console.Write(value: stack.Peek().Name + ", ");
Console.WriteLine();




//Queue
Console.WriteLine("\n---------------------- Queue");
Queue<Person> queue = new();
queue.Enqueue(oto);
queue.Enqueue(nuca);
queue.Enqueue(chad);
foreach (Person person in queue) Console.Write(person.Name + ", ");
Console.WriteLine();
queue.Dequeue();
foreach (Person person in queue) Console.Write(person.Name + ", ");
Console.WriteLine(); 
