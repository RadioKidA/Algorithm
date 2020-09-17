using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAlgorithm(ClassicAlgorithmName.BubbleSort, AlgorithmType.Classic);  //选择执行不同算法，调试用
            //RunAlgorithm(LeetCodeAlgorithmName.LCA1, AlgorithmType.LeetCode);


            RunAllAlgorithm();    //执行所有算法
            Console.ReadKey();

        }

        /// <summary>
        /// 已完成的算法，与算法类同名
        /// </summary>
        public enum ClassicAlgorithmName
        {
            #region 数组
            FibonacciSequence,   //斐波那契数列

            #endregion

            #region 排序
            BubbleSort,  //冒泡排序
            QuickSort,	//快速排序
            CocktailSort,   //鸡尾酒排序
            #endregion

            #region 查找
            BinarySearch, //二分查找
            #endregion

            #region 字符串
            KMP,    //KMP字符串匹配算法
            BF,     //BF字符串匹配算法
            RK,     //RK字符串匹配算法
            #endregion

            #region 树


            #endregion

            #region 图
            

            #endregion

            #region 其他

            LRU,    //内存淘汰算法

            #endregion





        }

        public enum LeetCodeAlgorithmName
        {
            LCA1,   //LCA1 两数之和

        }

        public enum AlgorithmType
        {
            Classic,
            LeetCode,

        }

        /// <summary>
        /// 根据枚举值反射执行算法
        /// </summary>
        /// <param name="algorithmName">算法名称</param>
        static void RunAlgorithm<T>(T algorithmName, AlgorithmType algoType)
        {
            string className = algorithmName.ToString();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType($"ConsoleApp.Algorithm.{algoType}." + className);

            dynamic obj = (IRunAlgorithm)Activator.CreateInstance(type, true);
            obj.Run();
        }

        /// <summary>
        /// 执行所有算法
        /// </summary>
        static void RunAllAlgorithm()
        {
            Type algoInterface = typeof(IRunAlgorithm);
            List<Type> types = new List<Type>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (algoInterface.IsAssignableFrom(type))
                    {
                        if (type.IsClass && !type.IsAbstract)
                        {
                            types.Add(type);
                        }
                    }
                }
            }

            types.ForEach((t) =>
            {
                Console.WriteLine(t.FullName);

                var algoInstance = (IRunAlgorithm)Activator.CreateInstance(t, true);
                algoInstance.Run();

                Console.WriteLine("\n\n\n");
            });

        }
    }
}
