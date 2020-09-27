using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic.String
{
    /// <summary>
    /// kmp算法：
    /// 字符串匹配算法
    /// 
    /// 特点：
    /// 1.仅后移模式串
    /// 2.指针不回溯
    /// 
    /// 最长可匹配前缀子串：
    /// 所有不包含最后一个字符的前缀字串
    /// 最长可匹配后缀子串：
    /// 所有不包含第一个字符的前缀字串
    /// 
    /// 公共前后缀最长长度：
    /// 最长可匹配前后字串中 最长的 相同的 子串 的长度
    /// 
    /// 如abaabcab
    /// 最长可匹配前缀子串为a,[ab],aba,abaa,abaab,abaabc,abaabca
    /// 最长可匹配后缀子串为b,[ab],cab,bcab,abcab,aabcab,baabcab
    /// 公共前后缀为ab,长度就为2
    /// 
    /// 写不来
    /// 
    /// </summary>
    class KMP : IRunAlgorithm
    {
        public void KMPfoo(string str, string pattern)
        {

        }


        public void Run()
        {
            

        }
    }
}
