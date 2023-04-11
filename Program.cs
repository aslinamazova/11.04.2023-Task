string Task = "  Hello world.Welcome my Task  ";

    Console.WriteLine(Task.ToString());
    Console.WriteLine(string.Empty);
    Console.WriteLine(Task.StartsWith('h'));
    Console.WriteLine(Task.EndsWith('k'));
    Console.WriteLine(Task.Contains("my"));
    Console.WriteLine(Task.IndexOf('o',10));
    Console.WriteLine(Task.IndexOf('o', Task.IndexOf('o', Task.IndexOf('o') + 1)+1));
    Console.WriteLine(Task.LastIndexOf('o'));
    Console.WriteLine(Task.LastIndexOf("Hello"));
    Console.WriteLine(Task.Replace('o','e'));
    Console.WriteLine(Task.Replace("Hello","Salam"));
    Console.WriteLine(Task.Remove(10));
    Console.WriteLine(Task.Remove(Task.IndexOf('o',10)));
    Console.WriteLine(Task.Substring(10));
    Console.WriteLine(Task.Length);
    Console.WriteLine(Task.Trim());
    Console.WriteLine(Task.Trim().Length);

string[] arr = Task.Split(' ');

foreach (string s in arr)
{
    Console.WriteLine(s);
}

string[] arrs = { "Hello", "world", "Welcome" };
Console.WriteLine(string.Join(',',arrs,0,2));

Console.WriteLine(string.Compare(Task,string.Empty));
Console.WriteLine(string.Compare("e","e"));


string Task2 = string.Empty;
if (string.IsNullOrEmpty(Task2))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}

//string Task3 = string.Empty;
string Task3 = " ";
if (string.IsNullOrWhiteSpace(Task3))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}



string task = "Welcome";
string check = Console.ReadLine();
if (check.ToLower() == task.ToLower())
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
