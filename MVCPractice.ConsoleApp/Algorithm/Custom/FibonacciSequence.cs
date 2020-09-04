using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Custom
{
    /// <summary>
    /// 
    /// </summary>
    class FibonacciSequence:IRunAlgorithm
    {
        private readonly List<int> _list;

        public FibonacciSequence()
        {
            _list = new List<int>{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
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
            _list.ForEach((item) => { Console.Write(item.ToString() + "  "); });
            Console.WriteLine($"\n第{n}位为{GetIndexNumber(n)}（从下标0开始计数）");
        }
    }
}
