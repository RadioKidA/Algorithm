using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 希尔排序
    /// 插入排序的优化
    /// 每次比较下标的一定增量分组，对每组使用插入排序算法
    /// 每轮比较完将增量缩减，直到增量减至1
    /// </summary>
    class ShellSort : IRunAlgorithm
    {
        public void Run()
        {
            Console.WriteLine("希尔排序：");

            int[] arr = new[] { 6, 4, 2, 5, 9, 1, 3, 7 };
            Console.WriteLine("原始数组：");
            arr.PrintAll();
            Console.WriteLine();
            Console.WriteLine("排序后：");
            Shell(arr);
            arr.PrintAll();
        }

        public void Shell(int[] arr)
        {
            int offset = arr.Length;

            while (offset >= 1)
            {
                for (int i = offset; i < arr.Length; i++)
                {
                    int j = 0;
                    int temp = arr[i];

                    for (j = i - offset; j >= 0 && temp < arr[j]; j -= offset)
                    {
                        arr[j + offset] = arr[j];
                    }
                    arr[j + offset] = temp;
                }
                offset /= 2;
            }

        }
    }
}
