using Task2;

Storage<int> storage = new Storage<int>();

storage.Add(1);
storage.Add(2);
storage.Add(3);
storage.Add(4);
Console.WriteLine(storage.ToString());
storage.Remove(1);

Console.WriteLine(storage.ToString());

storage.UpdateElement(3, 6);

Console.WriteLine(storage.ToString());


Storage<string> storage2 = new Storage<string>();
storage2.Add("Oto");
storage2.Add("nozadze");
storage2.Add("2003");
storage2.Add("UX");
Console.WriteLine(storage2.ToString());

storage2.Remove("2003");
Console.WriteLine(storage2.ToString());

storage2.UpdateElement("UX","Developer");
Console.WriteLine(storage2.ToString());

//storage2.UpdateElement("X", "Developer");
//Console.WriteLine(storage2.ToString());

storage.Clear();
Console.WriteLine(storage.ToString());

