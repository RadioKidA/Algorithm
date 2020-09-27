using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.String
{
    /// <summary>
    /// 字符串匹配BF暴力算法
    /// 主串和模式串的第一个元素进行对比，
    /// 如果相等就各向后移动一位，直到模式串结束。
    /// 如果不相等，主串指针向后移动一位，模式串重置，由主串后一位与模式串第一位进行对比，重复以上步骤。
    /// </summary>
    class BF : IRunAlgorithm
    {
        public void Run()
        {
            Test1();

            Test2();

        }

        public void Test1()
        {
            string rawStr = "wswswe";
            string patternStr = "we";

            Console.WriteLine($"主串为{rawStr}");
            Console.WriteLine($"模式串为{patternStr}");
            int rst = GetPos(rawStr, patternStr);

            Console.WriteLine($"匹配字符串的起始位置(0开始)为{rst}");
        }

        public void Test2()
        {
            string rawStr = "abcacdcabcde";
            string patternStr = "cab";

            Console.WriteLine($"主串为{rawStr}");
            Console.WriteLine($"模式串为{patternStr}");
            int rst = GetPos(rawStr, patternStr);

            Console.WriteLine($"匹配字符串的起始位置(0开始)为{rst}");
        }


        public int GetPos(string raw, string pattern)
        {
            int rawLength = raw.Length;
            int patternLength = pattern.Length;

            int i = 0;  //原字符串中用来比对的指针
            int j = 0;  //模式串中用来比对的指针
            int p = 0;  //原字符串中记录当前位置的指针

            while (i < rawLength && j < patternLength) 
            {
                if (raw[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    p++;
                    i = p;
                    j = 0;
                }
            }

            return p;
        }
    }
}
