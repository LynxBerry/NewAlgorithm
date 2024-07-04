namespace _2024_07_03_PERMUTATION
{
    public class Permutation
    {
        private IList<string> _permutations = [];
        public void Generate(int lengthOfPattern)
        {
            HashSet<int> ints = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            Permutate(ints, string.Empty, lengthOfPattern);
            Print();

        }

        private void Permutate(HashSet<int> remainInts, string prefix, int countOfDigitsLeft)
        {
            if (countOfDigitsLeft == 0)
            {
                _permutations.Add(prefix);
                return;
            }

            HashSet<int> remain = new HashSet<int>(remainInts);

            foreach (int i in remain)
            {
                remainInts.Remove(i);
                Permutate(remainInts, $"{prefix}{i}", countOfDigitsLeft - 1);
                remainInts.Add(i);
            }
        }

        private void Print()
        {
            foreach (var p in _permutations)
            {
                Console.WriteLine(p);
            }
        }
    }
}