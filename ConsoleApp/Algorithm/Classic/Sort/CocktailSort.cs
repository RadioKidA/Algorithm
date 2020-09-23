using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 鸡尾酒排序：
    /// 冒泡排序的一种变化，
    /// 元素比较和交换过程是双向的。
    /// 
    /// 适用于大部分元素已经有序的场景。
    /// </summary>
    class CocktailSort : IRunAlgorithm
    {
        public void Run()
        {
            int[] arr = new int[] { 7, -2, 8, 3, 4, 5, 6 };

            Console.WriteLine("鸡尾酒排序：");
            Console.WriteLine("原始数组：");
            arr.PrintAll();

            Console.WriteLine();

            Sort(arr);
            Console.WriteLine("排序后数组：");
            arr.PrintAll();

        }

        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                bool isSorted = true;

                // 奇数轮，从左向右进行比较和交换
                for (int j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // 有交换元素，所以不是有序的
                        arr.Swap(j, j + 1);
                        isSorted = false;
                    }
                }


                if (isSorted == true)
                {
                    break;
                }

                isSorted = true;

                // 偶数轮，从右向左进行比较和交换
                for (int j = arr.Length - i - 1; j > i; j--)
                {
                    if (arr[j]<arr[j-1])
                    {
                        // 有交换元素，所以不是有序的
                        arr.Swap(j, j - 1);
                        isSorted = false;
                    }
                }

                if (isSorted == true)
                {
                    break;
                }
            }
            
        }
    }
}
