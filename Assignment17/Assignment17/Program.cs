using Assignment17;


MyList<int> list = new();

// Add, AddRange, Count
list.Add(1);
list.Add(2);
list.AddRange(new List<int> { 3, 4, 5, 6, 324, 23523, 1, 2342341, 23 });
Console.Write("Count: " + list.Count);

//Enumerator, Remove, Contains
list.Contains(1);
list.Remove(2);
Console.Write("\nAll Items:");
foreach (var item in list)
{
    Console.Write(item + ", ");
}

//Indexer
Console.WriteLine("\nGet with indexer: "+ list[2]);

//RemoveRange, RemoveAt, Find
list.RemoveRange(1, 4);
list.RemoveAt(2);
Console.Write("\nAll Items:");
foreach (var item in list)
{
    Console.Write(item + ", ");
}
Console.WriteLine(list.Find(x=>x > 400));

//Single nad SingleOrDefault
//Console.WriteLine(list.Single(x=> x == 2));
Console.WriteLine(list.SingleOrDefault(x=> x == 2));

//Where
var whereList = list.Where(x=>x > 300);
Console.Write("\nAll Items:");
foreach (var item in whereList)
{
    Console.Write(item+", ");
}
