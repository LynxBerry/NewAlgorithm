namespace TestNamespace
{
    /// <summary>
    // * Check Whether a string has all unique characters
    /// </summary>
    public class UniqueCharString
    {
        // * Use Dictionary to track the char set
        public static bool IsUniqueCharString(string s)
        {
            Dictionary<char, int> tracker = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                tracker[s[i]] = tracker.GetValueOrDefault(s[i]) + 1;
            }

            return !tracker.Any(kv => kv.Value > 1);
        }

        public static bool IsUniqueCharString2(string s)
        {
            bool isUnique = true;

            HashSet<char> tracker = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (tracker.Contains(s[i]))
                {
                    // * Because the current char has already existed
                    isUnique = false;
                }
                else
                {
                    tracker.Add(s[i]);
                }
            }

            return isUnique;
        }
    }
}