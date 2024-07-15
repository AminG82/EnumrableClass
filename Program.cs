
// Creat a class with IEnumerable interface

using EnumrableClass;

Console.WriteLine("Hello World!");
Names obj = new Names();

foreach (var item in obj)
{
    Console.WriteLine(item);
}
Console.ReadKey();

