/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[m] = nums2[i];
            m++;
        }

        Array.Sort(nums1);
    }
}
// @lc code=end

