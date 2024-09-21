// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start running Two Sums Algorithm....");


int[] nums = [2, 4, 2, 1, 2, 7];

// var result = TwoSum.FindTwoSum(nums, target: 10);

var result = TwoSum.FindTwoSumWithDict(nums, 4);

if (result == (-1, -1))
{
    Console.WriteLine("Cannot find such two numbers");
}
else
{
    Console.WriteLine($"pos_i: {result.pos_i}, value of i: {nums[result.pos_i]}");
    Console.WriteLine($"pos_j: {result.pos_j}, value of j: {nums[result.pos_j]}");
}






