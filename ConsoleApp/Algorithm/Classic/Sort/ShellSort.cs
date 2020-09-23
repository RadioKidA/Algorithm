using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.Sort
{
    /// <summary>
    /// 希尔排序
    /// 插入排序的优化
    /// </summary>
    class ShellSort : IRunAlgorithm
    {
            

        public void Run()
        {
            Console.WriteLine("希尔排序：");
        }

        public void Shell(int[] arr)
        {
            int offset = arr.Length;

            while (offset > 1)
            {
                offset = offset / 2;
                for (int i = 0; i < offset; i++)
                {

                }

            }

        }
    }
}
