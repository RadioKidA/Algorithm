using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 归并排序
    /// 分组：
    /// 假设集合一共有n个元素，算法将会对集合进行逐层的折半分组。
    /// 第一层分成两个大组，每组n/2个元素
    /// 第二层分成4个小组，每组n/4个元素
    /// 第三层分成8个更小的组，每组n/8个元素
    /// 一直到每组只有一个元素为止。
    /// 
    /// 归并（Merge）：
    /// 归并的时候创建一个大数组用于存放归并结果，在两个小集合和结果数组中各创建一个位置指针，
    /// 两个小数组中的指针位进行比较，比较结果小的放入大数组并且指针向后移动一位
    /// 直到两个小集合都比较完
    /// 如果有一边的指针移动到末尾了，将另一边剩余的元素有序加入结果数组
    /// </summary>
    class MergeSort :IRunAlgorithm
    {
        public void Run()
        {
            Console.WriteLine("归并排序：");
            int[] arr = new int[] { 7, 4, 2, 76, 24, 9, 3, 10 };
            arr.PrintAll();
            Console.WriteLine();
            Console.WriteLine("排序后");
            MergeSortA(arr, 0, arr.Length - 1);
            arr.PrintAll();
        }

        public void MergeSortA(int[] arr, int start,int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSortA(arr, start, mid);
                MergeSortA(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        public void Merge(int[] arr, int start, int mid, int end)
        {
            int[] tempArr = new int[end - start + 1];   //创建大数组
            int p1 = start,
                p2 = mid + 1,
                p = 0;  //大数组指针

            while (p1 <= mid && p2 <= end)
            {
                if (arr[p1] <= arr[p2])
                {
                    tempArr[p++] = arr[p1++];
                }
                else
                {
                    tempArr[p++] = arr[p2++];
                }
            }

            //复制前半部分剩余元素
            while (p1 <= mid)
            {
                tempArr[p++] = arr[p1++];
            }

            //复制后半部分剩余元素
            while (p2 <= end)
            {
                tempArr[p++] = arr[p2++];
            }

            //将大数组元素复制进原数组
            for (int i = 0; i < tempArr.Length; i++)
            {
                arr[i + start] = tempArr[i];
            }


        }

    }
}
