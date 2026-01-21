using CustomExceptionAndGenericList.Models;
using CustomExceptionAndGenericList.Collections;

try
{
    Human h = new Human
    {
        Name = "july",
        Surname = "test",
        Age = -2
    };
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

CustomList<int> list = new CustomList<int>();
list.Add(10);
list.Add(20);

Console.WriteLine(list.Contains(10));
Console.WriteLine(list.Count());      
