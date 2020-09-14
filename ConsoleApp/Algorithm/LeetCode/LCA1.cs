using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp.Algorithm.LeetCode
{
    /// <summary>
    /// 1. 两数之和
    /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
    /// 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
    /// 示例:
    /// 给定 nums = [2, 7, 11, 15], target = 9
    /// 因为 nums[0] + nums[1] = 2 + 7 = 9
    /// 所以返回[0, 1]
    /// </summary>
    class LCA1 : IRunAlgorithm
    {
        /// <summary>
        /// 两数之和
        /// </summary>
        /// <param name="nums">目标数组</param>
        /// <param name="target">求得的和</param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                    }
                }
            }

            return output;
        }


        public void Run()
        {
            Console.WriteLine("LeetCode算法1");
            Console.WriteLine("两数之和：");

            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 7;

            Test(arr, target);

            arr = new int[] { 3,2,4 };
            target = 6;
            Test(arr, target);
        }

        public void Test(int[] arr, int target)
        {
            
            int[] rst = TwoSum(arr, target);
            Console.Write($"输入：{arr.ConvertToString()}和目标数字：{target}  输出：");
            rst.PrintAll();

            Console.WriteLine();
        }


    }
}
