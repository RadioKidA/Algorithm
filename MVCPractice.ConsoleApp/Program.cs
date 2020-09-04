using ConsoleApp.Algorithm;
using ConsoleApp.Algorithm.Common;
using System;
using System.ComponentModel;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAlgorithm(AlgorithmName.FibonacciSequence);  //选择执行不同算法

            //RunAllAlgorithm();    //执行所有算法
            Console.ReadKey();

        }
        
        //反射执行算法
        static void RunAlgorithm(AlgorithmName algorithmName)
        {
            string className = algorithmName.ToString();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("ConsoleApp.Algorithm.Custom." + className);

            dynamic obj = (IRunAlgorithm)Activator.CreateInstance(type,true);
            obj.Run();

        }




        //执行所有算法
        static void RunAllAlgorithm()
        {
            foreach (var name in Enum.GetNames(typeof(AlgorithmName)))
            {
                Console.WriteLine(name);
                RunAlgorithm((AlgorithmName)Enum.Parse(typeof(AlgorithmName), name));
                Console.WriteLine("\n\n\n");
            }

        }

        public enum AlgorithmName
        {
            FibonacciSequence   //斐波那契数列

        }
    }
}
