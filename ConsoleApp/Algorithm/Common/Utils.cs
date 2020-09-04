using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Common
{
    public static class Utils
    {

        //public static void Swap(int[] list, int firstIndex, int secondIndex)
        //{
        //    int temp = list[firstIndex];
        //    list[firstIndex] = list[secondIndex];
        //    list[secondIndex] = temp;
        //}

        public static void Swap(this int[] list,int firstIndex, int secondIndex)
        {
            int temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public static void PrintAll(this int[] list)
        {
            int length = list.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(list[i] + "\t");
            }
        }

    }
}
