using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecode
{
    public class Sorting
    {
        public int FindKthLargest(int[] nums, int k)
        {
            //if (nums.Count() == 0) return 0;
            //if (nums.Count() == 1) return nums[0];
            k = nums.Count() - k;
            var l = 0;
            var h = nums.Count() - 1;
            while (l < h)
            {
                var j = position(nums, l, h);
                if (j == k)
                    break;
                else if (j < k)
                    l = j + 1;
                else
                    h = j - 1;
            }
            return nums[k];
        }

        public int position(int[] a, int l, int h)
        {
            var i = l;
            var j = h + 1;
            while (true)
            {
                while (a[++i] < a[l] && i < h) ;
                while (a[--j] > a[l] && l < j) ;
                if (i >= j)
                    break;
                swap(a, i, j);
            }
            swap(a, j, l);
            return j;
        }

        public void swap(int[] a, int i, int j)
        {
            var t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencyForNum = new Dictionary<int, int>();
            
            foreach (int num in nums)
            {
                if (frequencyForNum.ContainsKey(num))
                {
                    frequencyForNum[num] += 1;
                }
                else
                {
                    frequencyForNum[num] = 1;
                }
            }
            List<int>[] buckets = new List<int>[nums.Length + 1];
            foreach (int key in frequencyForNum.Keys)
            {
                int frequency = frequencyForNum[key];
                if (buckets[frequency] == null)
                {
                    buckets[frequency] = new List<int>();
                }
                buckets[frequency].Add(key);
            }
            List<int> topK = new List<int>();
            for (int i = buckets.Length - 1; i >= 0 && topK.Count() < k; i--)
            {
                if (buckets[i] == null)
                {
                    continue;
                }
                if (buckets[i].Count() <= (k - topK.Count()))
                {
                    topK.AddRange(buckets[i]);
                }
                else
                {
                    topK.AddRange(buckets[i].GetRange(0, k - topK.Count()));
                }
            }
            return topK;

            ///Solution 1
            //Dictionary<int, int> dc = new Dictionary<int, int>();
            //foreach (var i in nums)
            //{
            //    if (dc.ContainsKey(i))
            //    {
            //        dc[i] += 1;
            //    }
            //    else
            //        dc[i] = 1;
            //}
            //var myList = dc.ToList();
            //var ret = dc.OrderBy(e => e.Value).TakeLast(k).Select(e => e.Key).ToList();
            ////myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            ////var l = myList.GetRange(myList.Count() - k, k);
            ////List<int> ret = new List<int>();
            ////foreach(var i in l)
            ////{
            ////    ret.Add(i.Key);
            ////}
            //return ret;
        }

        public string FrequencySort(string s)
        {
            Dictionary<char, int> dt = new Dictionary<char, int>();
            foreach (var i in s)
            {
                if (dt.ContainsKey(i))
                {
                    dt[i] += 1;
                }
                else
                    dt[i] = 1;
            }
            var ldt = dt.ToList();
            var l = ldt.OrderByDescending(e => e.Value).ToList();
            char[] ret = new char[s.Length];
            int inum = 0;
            foreach (var i in l)
            {
                for (var j = 0; j < i.Value; j++)
                {
                    ret[inum++]=i.Key;
                }
            }
            return new string(ret);
        }
    }
}
