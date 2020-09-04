using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic
{
    /// <summary>
    /// 斐波那契数列中的每一项都等于它的前两项的和。
    /// </summary>
    class FibonacciSequence:IRunAlgorithm
    {
        private readonly int[] _list;

        public FibonacciSequence()
        {
            _list = new int[]{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        }
        
        public int GetIndexNumber(int index)
        {
            if (index<=3)
            {
                return _list[index];
            }
            return GetIndexNumber(index-1) + GetIndexNumber(index - 2);
        }

        public void Run()
        {
            int n = 7;

            Console.WriteLine("初始数组：");
            _list.PrintAll();
            Console.WriteLine($"\n第{n}位为{GetIndexNumber(n)}（从下标0开始计数）");
        }
    }
}
