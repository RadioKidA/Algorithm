using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 选择排序
    /// 每轮比较选出第n小的数字，与数组第n位进行交换
    /// </summary>
    class SelectionSort : IRunAlgorithm
    {
        public void Run()
        {
            int[] arr = new int[] { 6, 3, 8, 2, 9, 1, 5 };
            Console.WriteLine("选择排序：");
            arr.PrintAll();
            Console.WriteLine();
            Sort(arr);
            arr.PrintAll();
        }

        public void Sort(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    minIndex = arr[minIndex] < arr[j] ? minIndex : j;
                }

                arr.Swap(i, minIndex);
            }
        }

    }
}
