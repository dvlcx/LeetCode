public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[i] || nums[i] > target) 
                return i;
            else if (nums[i] < target && i < nums.Length - 1 && nums[i + 1] > target)
                return i + 1;
        }
        return nums.Length;
    }
}
