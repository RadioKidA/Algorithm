using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp.Algorithm.Classic
{
    /// <summary>
    /// 冒泡排序比较数组中相邻的两个数字，较大的交换到后面，也就是向上冒泡
    /// 每一轮比较都可以找到未排序区最大的数字
    /// </summary>
    class BubbleSort : IRunAlgorithm
    {
        int[] _list;
        public BubbleSort()
        {
            _list = new int[] { 48, 13, 65, 84, 15, 3, -39, 21 };
        }
        public void Sort()
        {
            int length = _list.Length;
            int i = 0, j = _list.Length-1;
            while (j > 1)
            {
                i = 0;
                while (i < length - 1)
                {
                    if (_list[i] > _list[i + 1])
                    {
                        _list.Swap(i, i + 1);
                    }
                    i++;
                }
                Console.Write($"第{length-j}轮排序结果为：");
                _list.PrintAll();
                Console.WriteLine();
                j -= 1;
            }
        }

        public void Run()
        {
            Console.Write("初始数组为：");
            _list.PrintAll();
            Console.WriteLine();
            Sort();
        }
    }
}
