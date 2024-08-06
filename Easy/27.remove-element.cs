/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var index = 0;
        foreach (var num in nums)
        {
            if (num != val)
            {
                nums[index] = num;
                index++;
            }
        }

        return index;
    }
}
// @lc code=end

