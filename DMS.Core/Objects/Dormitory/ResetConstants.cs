using System.Collections;
using DMS.Core.Exceptions;

namespace DMS.Core.Objects.Dormitory;

public struct ResetConstants : IEnumerable<KeyValuePair<string, int>>
{
    private static readonly Dictionary<string, Predicate<int>>
        Constraints = new()
        {
            { "Floors", x => x is < 10 and > 0 },
            { "RoomsCount", x => x is < 100 and > 0 },
            { "RoomCapacity", x => x > 0 }
        };

    public static readonly string[] ConstantNames =
        new[] { "Floors", "RoomsCount", "RoomCapacity" };

    private readonly Dictionary<string, int> _constants;

    public int Floors { get; }
    public int RoomsCount { get; }
    public int RoomCapacity { get; }

    public ResetConstants(int floors, int roomCount, int roomCapacity)
    {
        _constants = new()
        {
            ["Floors"] = floors,
            ["RoomsCount"] = roomCount,
            ["RoomCapacity"] = roomCapacity
        };

        var badValues = _constants
            .Where(r => !Constraints[r.Key](r.Value))
            .Select(r => r.Key).ToArray();
        if (badValues.Length != 0)
            throw new ConstantException($"Following constants have bad value: {string.Join(" ", badValues)}");
    }

    public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
    {
        foreach (var pair in _constants)
            yield return pair;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}