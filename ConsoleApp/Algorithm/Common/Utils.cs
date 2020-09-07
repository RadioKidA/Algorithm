using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Common
{
    public static class Utils
    {


        #region int数组扩展方法

        /// <summary>
        /// 交换数组中两个数的位置
        /// </summary>
        /// <param name="list">交换的数组</param>
        /// <param name="firstIndex">第一个项的索引</param>
        /// <param name="secondIndex">另一个项的索引</param>
        public static void Swap(this int[] list, int firstIndex, int secondIndex)
        {
            int temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        /// <summary>
        /// 输出数组中所有项
        /// </summary>
        /// <param name="list"></param>
        public static void PrintAll(this int[] list)
        {
            int length = list.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(list[i] + "\t");
            }
        }

        #endregion

        #region 常用方法

        public static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        #endregion

    }
}
