class TwoSum
{
    // * Try to find two numbers from the given array, so that 
    // * the sum of those two numbers equals target.
    // * Then return the positions of those two numbers as tuple.
    // * Return (-1, -1) if we cannot find such two numbers.
    // * This function just returns first occurrence of tuple stasifying the conditions.
    // * Time Complexicity is n^2
    public static (int pos_i, int pos_j) FindTwoSum(int[] nums, int target)
    {
        // * Iterate the nums to fix the first number
        for (int i = 0; i != nums.Length; i++)
        {
            // * Iterate to fix the second number
            // * Please note we need to avoid duplicate enumerations
            for (int j = i + 1; j != nums.Length; j++)
            {
                if ( nums[i] + nums[j] == target )
                {
                    return (i, j);
                }
            }
        }

        return (-1, -1);

    }

    // * Use Dictionary to optimize the performance
    public static (int pos_i, int pos_j) FindTwoSumWithDict(int[] nums, int target)
    {
        // * Create a dictionary to store {key: valueofNum, value: position}
        Dictionary<int, int> dictValuePositions = new Dictionary<int, int>();
        for (int i = 0; i != nums.Length; i++)
        {
            // * Don't use the following Add since it will throw exception for duplicate key addition
            // * dictValuePositions.Add(key: nums[i],value: i);
            dictValuePositions[nums[i]] = i;
        }

        for (int i = 0; i != nums.Length; i++)
        {
            int remainValue = target - nums[i];
            if ( dictValuePositions.ContainsKey(remainValue) 
            && (dictValuePositions[remainValue] != i)) // * ensure nums[remainValue] is not the nums[i]
            {
                return (i, dictValuePositions[remainValue]);
            }
        }

        return (-1, -1);

    }

}