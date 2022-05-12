using Newtonsoft.Json;
using Npgsql;

namespace DMS.Resources;

public class ResourceBase
{
    protected static string GetExceptionMessage(Exception e)
    {
        switch (e.InnerException)
        {
            case PostgresException pe:
                return pe.MessageText;
            case InvalidCastException:
            case JsonException:
            case IndexOutOfRangeException:
                return e.InnerException.Message;
        }

        return e.Message;
    }
}