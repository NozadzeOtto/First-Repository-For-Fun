using Assignment17;
var test = new List<int>();
MyList<int> list = new();
list.Add(1);
list.Add(2);
list.AddRange(new List<int> { 3, 4, 5, 6, 324, 23523, 1, 2342341, 23 });
Console.WriteLine(list.Count);

list.Contains(1);
list.Remove(2);
Console.WriteLine(list.Count);
foreach (var item in list.List)
{
    Console.Write(item + ", ");
}
Console.WriteLine();


list.RemoveRange(1, 4);
foreach (var item in list.List)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
Console.WriteLine(list.Count);
Console.WriteLine(list.Find(x=>x > 400));
Console.WriteLine(list.Single(x=> x == 2));