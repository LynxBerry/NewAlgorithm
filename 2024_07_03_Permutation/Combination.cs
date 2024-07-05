using System.CodeDom.Compiler;
using System.Diagnostics.Contracts;

namespace _2024_07_03_PERMUTATION
{
    public class Combination
    {
        private IList<string> _combinations = [];

        public void Generate(int lengthOfPattern)
        {
            HashSet<int> ints = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            Combinate(ints, String.Empty, lengthOfPattern);
            Print();

        }

        private void Combinate(HashSet<int> remainInts, string prefix, int countOfDigitsLeft)
        {
            if (countOfDigitsLeft == 0)
            {
                _combinations.Add(prefix);
                return;
            }

            if (remainInts.Count < countOfDigitsLeft)
            {
                return;
            }

            int someInt = remainInts.First();
            remainInts.Remove(someInt);
            
            // * Generate combinations including someInt
            Combinate(remainInts, $"{prefix}{someInt}", countOfDigitsLeft - 1);

            // * Generate combinations excluding someInt
            Combinate(remainInts, prefix, countOfDigitsLeft);

            remainInts.Add(someInt);
        }

        private void Print()
        {
            foreach (var c in _combinations)
            {
                Console.WriteLine(c);
            }
        }
    }
}