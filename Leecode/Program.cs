using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution a = new Solution();

            //var i = a.TwoSum(new int[] { -3, 4, 3, 90 }, 0);
            //foreach(int j in i) Console.WriteLine(j);

            //int i = 234;
            //Console.WriteLine(a.SubtractProductAndSum(i));


            //Console.WriteLine(a.NumJewelsInStones("bce", "eea"));
            //Console.WriteLine(a.MinFlips(8, 3, 5));
            //Console.WriteLine(a.BalancedStringSplit("RLRRLLRLRL"));
            //var i = (a.GetNoZeroIntegers(4102));
            //foreach (int j in i) Console.WriteLine(j);
            //var i = (a.SumZero(5));
            //foreach (int j in i) Console.WriteLine(j);
            //int s = -3;
            //s = s >> 1;
            //Console.WriteLine(s);
            //var i = (a.DecompressRLElist(new int[] { 1, 2, 3, 4 }));
            //foreach (int j in i) Console.WriteLine(j);

            //Console.WriteLine(a.FindDifferency(new int[] { 1, 2, 3, 0, 5 }, new int[] { 2, 3, 1, 0, 5 }));

            //var i = new int[] { 18, 9, 27, 6, 15, 24, 30, 3, 12, 21 };
            //BinarySeachTree<int> root = new BinarySeachTree<int>();
            //foreach(int j in i)
            //{
            //    root.Add(j);
            //}

            //Console.WriteLine(a.RangeSumBST(root._root, 18, 24));

            //var i = new int[][]  { new int[]{1, 1}, new int[] { 3, 4}, new int[] { -1, 0 } };
            //Console.WriteLine(a.MinTimeToVisitAllPoints(i));

            //Console.WriteLine(a.OddCells(48, 37, new int[][] { new int[] { 40, 5 } }));
            //Console.WriteLine(a.RemoveOuterParentheses("(()())(())"));
            //Console.WriteLine(a.Maximum69Number(9669));
            //var i = a.PrintVertically("TO BE OR NOT TO BE");
            //foreach (string j in i) Console.WriteLine(j);
            //var i = a.ReplaceElements(new int[] { 19, 18, 5, 4, 19,4,2,6,2,2,5,3,3,5,3,3,1 });
            //foreach (var j in i) Console.WriteLine(j);
            //var i = a.SortArray(new int[] { 19, 18, 20,20,20,20 });
            //foreach (var j in i) Console.WriteLine(j);

            //var i = a.SortArrayByParity(new int[] { 19, 17, 20,20,20,20 });
            //foreach (var j in i) Console.WriteLine(j);

            //Console.WriteLine(a.MySqrt(2147395599)); 
            //Console.WriteLine(GetValue()); 
            //Console.WriteLine(a.FindMin(new int[] { 3, 4, 5, 1, 2 }));
            //Console.WriteLine(a.FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 }));

            //var i = a.KWeakestRows(new int[][] { new int[]{ 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1 } },3);
            //foreach (var j in i) Console.WriteLine(j);

            //var i = a.KWeakestRows(new int[][] { new int[]{ 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1 }, new int[] { 1, 0, 0, 0 }, new int[] { 1, 0, 0, 0 } },2);
            //foreach (var j in i) Console.WriteLine(j);

            var b = new BinarySearch();

        }

        private static async Task<string> GetValue()
        {
            await Task.Delay(10);
            return "this is the value";
        }
    }
}
