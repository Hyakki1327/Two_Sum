// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

int[] numbers = { 2, 7, 11, 15 };
int targ = 18;

TwoSum(numbers, targ);

static int[] TwoSum(int[] nums, int target)
{
    int[] resultMassive = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
                if (i == j)
                    break;
            else
                {
                    resultMassive[0] = j;
                    resultMassive[1] = i;
                }
        }
    }
    return resultMassive;
}