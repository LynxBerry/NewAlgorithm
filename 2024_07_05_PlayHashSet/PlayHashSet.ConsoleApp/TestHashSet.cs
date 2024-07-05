using System.Collections.Immutable;
using System;

namespace PlayHashSet.ConsoleApp
{
    public class TestHashSet
    {
        public void Test()
        {
            ImmutableHashSet<int> hashSet = ImmutableHashSet.Create([0, 1, 2, 3, 4, 5, 6, 7, 8, 9]);
            var newHashSet = hashSet.Add(10);
            var newHashSet2 = hashSet.Remove(3);

            Print(hashSet, "hashSet:");
            Print(newHashSet, "newHashSet:");
            Print(newHashSet2, "newHashSet2:");

        }

        private void Print(ImmutableHashSet<int> hashSet, string title)
        {
            Console.WriteLine(title);
            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

        }
    }
}
