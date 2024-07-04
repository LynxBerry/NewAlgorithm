namespace TestNamespace
{
    /// <summary>
    // * Check Whether a string has all unique characters
    /// </summary>
    public class UniqueCharString
    {
        public static bool IsUniqueCharString(string s)
        {
            Dictionary<char, int> tracker = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                tracker[s[i]] = tracker.GetValueOrDefault(s[i]) + 1;
            }

            return !tracker.Any(kv => kv.Value > 1);
        }
    }
}