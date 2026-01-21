using CustomExceptionAndGenericList.Exceptions;

namespace CustomExceptionAndGenericList.Models;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }

    private int age;

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new AgeException("age must be greater than zero");

            age = value;
        }
    }
}