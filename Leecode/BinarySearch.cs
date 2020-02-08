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

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int first = 0;
            int last = arr.Count() - 1;
            int m = 0;
            while (first < last)
            {
                m = first + (last - first) / 2;
                if (arr[m] > x)
                {
                    last = m;
                }
                else if (arr[m] == x)
                {
                    first = m;
                    break;
                }
                else
                {
                    first = m + 1;
                }
            }
            IList<int> ret = new List<int>();

            int f = Math.Max(0, first - k );
            int l = Math.Min(arr.Count() - 1, first + k - 1);
            while(l-f+1>k)
            {
                if (Math.Abs(arr[f] - x) > Math.Abs(arr[l] - x))
                {
                    f++;
                }
                else l--;
            }
            return arr.Skip(f).Take(k).ToArray();
        }

        public bool IsPerfectSquare(int num)
        {
            int first = 1;
            int last = num;
            float fnum = num;
            int m = 0;
            if (num == 0) return false;
            while (first < last)
            {
                m = first + (last - first) / 2;
                if ( m > fnum / m)
                {
                    last = m;
                }
                else if ( m == fnum / m) return true;
                else first = m + 1;
            }
            if (first * first == fnum) return true;
            
            return false;
        }
    }
}
