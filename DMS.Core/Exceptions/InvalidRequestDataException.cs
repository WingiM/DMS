namespace DMS.Core.Exceptions;

public class InvalidRequestDataException : Exception
{
    public InvalidRequestDataException(string? message) : base(message)
    {
    }

    public InvalidRequestDataException(string? message,
        Exception? innerException) : base(message, innerException)
    {
    }
}