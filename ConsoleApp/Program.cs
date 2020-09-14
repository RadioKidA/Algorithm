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
            //RunAlgorithm(AlgorithmName.BubbleSort);  //选择执行不同算法，调试用

            RunAllAlgorithm();    //执行所有算法
            Console.ReadKey();

        }

        /// <summary>
        /// 已完成的算法，与算法类同名
        /// </summary>
        public enum AlgorithmName
        {
            FibonacciSequence,   //斐波那契数列
            BubbleSort,  //冒泡排序
            QuickSort,	//快速排序
            CocktailSort,   //鸡尾酒排序


        }

        /// <summary>
        /// 根据枚举值反射执行算法
        /// </summary>
        /// <param name="algorithmName">算法名称</param>
        static void RunAlgorithm(AlgorithmName algorithmName)
        {
            string className = algorithmName.ToString();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("ConsoleApp.Algorithm.Classic." + className);



            dynamic obj = (IRunAlgorithm)Activator.CreateInstance(type, true);
            obj.Run();
        }

        /// <summary>
        /// 执行所有算法
        /// </summary>
        static void RunAllAlgorithm()
        {
            //foreach (var name in Enum.GetNames(typeof(AlgorithmName)))
            //{
            //    Console.WriteLine(name);
            //    RunAlgorithm((AlgorithmName)Enum.Parse(typeof(AlgorithmName), name));
            //    Console.WriteLine("\n\n\n");
            //}

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
