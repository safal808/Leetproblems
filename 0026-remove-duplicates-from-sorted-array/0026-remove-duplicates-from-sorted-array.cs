public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
            return 0;

        int newIndex = 0; 

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[newIndex])
            {
                newIndex++;
                nums[newIndex] = nums[i];
            }
        }

        return newIndex + 1; 
    }
    }
