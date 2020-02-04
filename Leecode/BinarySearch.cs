using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecode
{
    public class BinarySearch
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;
            int right = nums.Count() - 1;
            int m = 0;
            while (left < right)
            {
                m = left + (right - left) / 2;
                if (m > 0 && m < nums.Count() - 1)
                {
                    if (nums[m - 1] < nums[m] && nums[m + 1] < nums[m])
                        return m;
                    if (nums[m + 1] > nums[m])
                        left = m + 1;
                    else right = m;
                }
                else
                {
                    if (m == 0)
                    {
                        if (nums[m] > nums[m + 1]) return 0;
                        else return 1;
                    }
                    else
                    {
                        if (nums[m] > nums[m - 1]) return m;
                        else return --m;
                    }
                }

            }
            return left;
        }
    }
}
