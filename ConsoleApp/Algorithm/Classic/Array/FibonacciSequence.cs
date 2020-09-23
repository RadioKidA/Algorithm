using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Array
{
    /// <summary>
    /// 斐波那契数列中的每一项都等于它的前两项的和。
    /// </summary>
    class FibonacciSequence:IRunAlgorithm
    {       
        public int GetIndexNumber(int[] arr, int index)
        {
            if (index<=3)
            {
                return arr[index];
            }
            return GetIndexNumber(arr,index - 1) + GetIndexNumber(arr,index - 2);
        }

        public void Run()
        {
            int n = 7;
            int[] arr = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            int rst = GetIndexNumber(arr, n);

            Console.WriteLine("斐波那契数列：");
            Console.WriteLine("初始数组：");
            arr.PrintAll();

            Console.WriteLine($"\n第{n}位为{rst}（从下标0开始计数）");
        }
    }
}
