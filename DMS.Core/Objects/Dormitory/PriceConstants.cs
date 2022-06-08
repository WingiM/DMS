using System.Collections;

namespace DMS.Core.Objects.Dormitory;

public class PriceConstants : IEnumerable<KeyValuePair<string, int>>
{
    private readonly Dictionary<string, int> _constants;

    public PriceConstants(int commercialCost=0, int nonCommercialCost=0)
    {
        _constants = new()
        {
            ["CommercialCost"] = commercialCost,
            ["NonCommercialCost"] = nonCommercialCost
        };
    }
    
    public int this[string key] => _constants[key];

    public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
    {
        foreach (var pair in _constants)
        {
            yield return pair;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}