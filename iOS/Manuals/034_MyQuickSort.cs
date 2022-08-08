using System;
using static System.Console;
public class Program
{
    static public void Main ()
    {

int[] nums = {4, 5, 7, 3, 2, 1, 9, 8, 6};

WriteLine(String.Join(" ", nums));

void SortNums(int[] nums, int left, int right)
{
	if (left == right) return;
	
	int middle = left;
	
	for (int i = left; i < right; i++)
	{
		if (nums[i] <= nums[right - 1])
		{
			int temp = nums[i];
			nums[i] = nums[middle];
			nums[middle] = temp;
			
			middle++;
	
	SortNums(nums, left, middle - 1);
	SortNums(nums, middle, right);
		}
	}
}

SortNums(nums, 0, nums.Length);

WriteLine(String.Join(" ", nums));

    }
}
