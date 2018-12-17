using System.Collections.Generic;

namespace CodeCoverageCalculation.Common.Utils
{
    public static class DictionaryExtensions
    {
        public static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value)
        {
            if (dictionary.TryGetValue(key, out var obj) && obj is T typedObj)
            {
                value = typedObj;
                return true;
            }
            else
            {
                value = default(T);
                return false;
            }
        }
    }
}
