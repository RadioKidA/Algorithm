using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.String
{
    /// <summary>
    /// Boyer-Moore算法
    /// 直接对比主串和模式串的最后一个字符，
    /// 如果不匹配，有以下两种情况：
    ///  1.坏字符
    /// 主串中用来比较的最后一个字符在模式串中不存在，这时可以将模式串直接移到该字符后一位继续匹配。
    /// 后移位数 = 坏字符的位置 - 搜索词中的上一次出现位置(-1)
    /// 如果是坏字符，搜索次的上一次出现位置为 -1
    /// 如主串ABCDEFGHIABCG
    /// 模式串ABCG
    /// 第一次比较：
    /// ABC[D]EFGHIABC
    /// ABC[G]
    /// 后移位数 = 3(主串D的下标) - (-1)(模式串中只出现了一次G) = 4
    /// ABCDEFGHIABC
    ///     ABCG
    ///     
    ///  2.好后缀
    /// 主串中用来比较的最后一个字符在模式串中存在，
    /// 后移位数 = 好后缀的位置 - 搜索词中的上一次出现位置
    /// 如果好后缀在搜索词中只出现一次，那它上一次出现位置为(-1)
    /// 
    /// 
    /// </summary>
    class BM : IRunAlgorithm
    {
        public void Run()
        {
            
        }
    }
}
