using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp.Algorithm.Classic
{
    /// <summary>
    /// LRU内存淘汰算法
    /// </summary>
    class LRU : IRunAlgorithm
    {
        private LinkedList<KeyValuePair<int, int>> linkedList = new LinkedList<KeyValuePair<int, int>>();



        public void Run()
        {
            Test();
        }

        public void Test()
        {
            LinkedHashList list = new LinkedHashList(5);
            list.Put("111", "aaa");
            list.Put("222", "bbb");
            list.Put("333", "ccc");
            list.Put("444", "ddd");
            list.Put("555", "eee");

            list.Put("333", "333");
            list.Put("444", "444");

        }
    }

    /// <summary>
    /// 在普通哈希表的基础上用双向链表的方式连接，
    /// 可以访问前后节点
    /// </summary>
    class LinkedHashList
    {
        private LinkedHashListNode _head;
        private LinkedHashListNode _last;
        private int _capacity;
        private Dictionary<string, LinkedHashListNode> dict;

        public LinkedHashList(int capacity)
        {
            this._capacity = capacity;
            dict = new Dictionary<string, LinkedHashListNode>();

        }

        /// <summary>
        /// 获取值，刷新表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            if (!dict.TryGetValue(key,out LinkedHashListNode node))
            {
                return null;
            }

            RefreshNode(node);
            return node.value;
        }

        public void Put(string key, string value)
        {
            if (!dict.TryGetValue(key,out LinkedHashListNode node))
            {
                if (dict.Count >= _capacity)    //判断是否还有空余容量，如果没有就删除第一个节点
                {
                    string oldKey = RemoveNode(_head);
                    dict.Remove(oldKey);
                }

                node = new LinkedHashListNode(key, value);  //加入新节点
                AddNode(node);
                dict.Add(key, node);

            }
            else
            {
                node.value = value;
                RefreshNode(node);
            }
        }

        public void Remove(string key)
        {
            if (!dict.TryGetValue(key,out LinkedHashListNode node))
            {
                RemoveNode(node);
                dict.Remove(key);
            }
        }

        private void RefreshNode(LinkedHashListNode node)
        {
            if (node==_last)
            {
                return;
            }

            RemoveNode(node);
            AddNode(node);
        }

        private void AddNode(LinkedHashListNode node)
        {
            if (_last != null)
            {
                _last.next = node;
                node.pre = node;
                node.next = null;
            }

            _last = node;

            if (_head == null)
            {
                _head = node;
            }
        }

        private string RemoveNode(LinkedHashListNode node)
        {
            if (node == _head && node == _last) //空表，没有节点可以移除
            {
                _head = null;
                _last = null;
            }
            else if (node == _last) //移除最后一个节点
            {
                _last = _last.pre;
                _last.next = null;
            }
            else if (node == _head) //移除第一个节点
            {
                _head = _head.next;
                _head.pre = null;
            }
            else
            {
                node.pre.next = node.next;
                node.next.pre = node.pre;
            }

            return node.key;
        }

    }

    /// <summary>
    /// 节点
    /// </summary>
    class LinkedHashListNode
    {
        public string key;
        public string value;
        public LinkedHashListNode pre;
        public LinkedHashListNode next;

        public LinkedHashListNode(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
