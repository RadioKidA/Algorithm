using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 插入排序
    /// 将数组分为无序区和有序区
    /// 将第一个元素纳入有序区
    /// 每一轮比较将无序区拿来插入的元素保存起来，如果大于前一个就将比较项向后移动一位
    ///  3  1  7  9  2
    ///  3 [1] 7  9  2 第1轮
    /// [1] 3  7  9  2
    ///  1  3 [7] 9  2 第2轮
    ///  1  3  7 [9] 2 第3轮
    ///  1  3  7  9 [2]第4轮
    ///  1 [2] 3  7  9
    ///  
    /// </summary>
    class InsertionSort :IRunAlgorithm
    {
        public void Run()
        {
            int[] arr = new int[] { 6, 3, 7, 2, 8, -10, 1 };
            Console.WriteLine("插入排序：");
            Console.WriteLine("原始数组：");
            arr.PrintAll();
            Console.WriteLine("排序后：");
            InsertionSortFoo(arr);
            arr.PrintAll();

        }

        public void InsertionSortFoo(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)    //从无序区开始，第一位不比较
            {
                int insertValue = arr[i];
                int j = i - 1;
                for (; j >= 0 && insertValue < arr[j]; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = insertValue;
            }
        }
    }
}
