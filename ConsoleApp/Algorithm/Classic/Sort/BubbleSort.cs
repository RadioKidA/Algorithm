using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 冒泡排序比较数组中相邻的两个数字，较大的交换到后面，也就是向上冒泡
    /// 每一轮比较都可以找到未排序区最大的数字
    /// </summary>
    class BubbleSort : IRunAlgorithm
    {
        public void Run()
        {
            Console.WriteLine("冒泡排序：");
            int[] arr = new int[] { 48, 13, 65, 84, 15, 3, -39, 21 };
            Console.Write("初始数组为：");
            arr.PrintAll();
            Console.WriteLine();
            Sort(arr);
        }

        public void Sort(int[] arr)
        {
            int length = arr.Length;
            int i = 0, j = arr.Length-1;
            while (j > 1)
            {
                i = 0;
                while (i < length - 1)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr.Swap(i, i + 1);
                    }
                    i++;
                }
                Console.Write($"第{length-j}轮排序结果为：");
                arr.PrintAll();
                Console.WriteLine();
                j -= 1;
            }
        }


    }
}
