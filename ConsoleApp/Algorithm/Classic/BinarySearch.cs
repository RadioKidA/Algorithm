using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic
{
    class BinarySearch : IRunAlgorithm
    {
        public void Run()
        {
            Test1();
            Test2();
        }

        #region 递归实现
        public void Test1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 15, 68, 73, 92 };
            int target = 15;
            int rst = binarySearch1(arr, 0, arr.Length - 1, target);

            Console.WriteLine("递归实现");
            Console.WriteLine($"有序数组为{arr.ConvertToString()}");
            Console.WriteLine($"目标数字为{target}");
            Console.WriteLine($"查找结果为{rst}");
        }

        public int binarySearch1(int[] arr, int start,int end, int target)
        {
            if (start > end)
            {
                return -1;
            }

            int mid = start + (end - start) / 2;


            if (arr[mid] == target) //等于中位数直接返回
            {
                return mid;
            }
            else if (arr[mid] < target) //大于中位数，将最小搜索范围改为中位数 + 1
            {
                start = mid + 1;
            }
            else    // 小于中位数，将最小搜索范围改为中位数 - 1
            {
                end = mid - 1;
            }


            return binarySearch1(arr, start, end, target);
        }
        #endregion

        #region 非递归实现
        public void Test2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 15, 68, 73, 92 };
            int target = 15;
            int rst = binarySearch2(arr, target);

            Console.WriteLine("非递归实现");
            Console.WriteLine($"有序数组为{arr.ConvertToString()}");
            Console.WriteLine($"目标数字为{target}");
            Console.WriteLine($"查找结果为{rst}");
        }

        public int binarySearch2(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] == target) //等于中位数直接返回
                {
                    return mid;
                }
                else if (arr[mid] < target) //大于中位数，将最小搜索范围改为中位数 + 1
                {
                    start = mid + 1;
                }
                else    // 小于中位数，将最小搜索范围改为中位数 - 1
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
        #endregion
    }
}
