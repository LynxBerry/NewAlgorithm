using System.CodeDom.Compiler;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;

namespace _2024_07_03_PERMUTATION
{
    public class Combination
    {
        private IList<string> _combinations = [];

        public void Generate(int lengthOfPattern)
        {
            HashSet<int> ints = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            _combinations.Clear();
            Combinate(ints, String.Empty, lengthOfPattern);
            Print();

        }

        // * Use ImmutableHashSet to track avaiable digits to be chosen
        public void Generate2(int lengthOfPattern)
        {
            ImmutableHashSet<int> ints = ImmutableHashSet.Create([0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
            _combinations.Clear();
            Combinate2(ints, String.Empty, lengthOfPattern);
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

        // * Use ImmutableHashSet to track avaiable digits to be chosen
        private void Combinate2(ImmutableHashSet<int> availableDigits, string prefix, int countOfRemainDigits)
        {
            if (countOfRemainDigits == 0)
            {
                _combinations.Add(prefix);
                return;
            }

            if (availableDigits.Count < countOfRemainDigits)
            {
                return;
            }

            int selectInt = availableDigits.First();

            // * Count selectInt in
            Combinate2(availableDigits.Remove(selectInt), $"{prefix}{selectInt}", countOfRemainDigits - 1);

            Combinate2(availableDigits.Remove(selectInt), prefix, countOfRemainDigits);
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