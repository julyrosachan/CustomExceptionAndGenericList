namespace CustomExceptionAndGenericList.Exceptions;

public class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}