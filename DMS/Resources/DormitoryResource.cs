using System.Globalization;

namespace DMS.Resources;

public class DormitoryResource
{
    private static readonly DateTime DefaultDocumentStartDate =
        DateTime.Now.Month >= 9
            ? new DateTime(DateTime.Now.Year, 9, 1)
            : new DateTime(DateTime.Now.Year - 1, 9, 1);

    internal static DateTime ParseDate(string date)
    {
        DateTime.TryParseExact(date, "d", null, DateTimeStyles.None,
            out var result);
        return (result == DateTime.MinValue ? DefaultDocumentStartDate : result)
            .ToUniversalTime().Date;
    }
}