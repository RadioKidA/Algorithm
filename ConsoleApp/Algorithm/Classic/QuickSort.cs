using ConsoleApp.Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Algorithm.Classic
{
    /// <summary>
    /// 
    /// </summary>
    class QuickSort:IRunAlgorithm
    {
        public QuickSort()
        {
            
        }

        /// <summary>
        /// 挖坑交换法
        /// </summary>
        public void SortA(int[] arr, int startIndex,int endIndex)
        {
            if (startIndex>=endIndex)
            {
                return;
            }

            int pivotIndex =  partitionA(arr,startIndex,endIndex);
            SortA(arr, startIndex, pivotIndex - 1);
            SortA(arr, pivotIndex + 1, endIndex);
        }

        public int partitionA(int[] arr,int startIndex,int endIndex)
        {
            int left = startIndex,   //左指针
                right = endIndex,    //右指针
                pivot = arr[startIndex],  //锚点
                pivotIndex = startIndex; //锚点位置

            //左右指针重叠时结束
            while (left <= right)
            {
                while (left<=right)
                {
                    //锚点值比右指针大
                    if (pivot>arr[right])
                    {
                        arr[left] = arr[right];
                        pivotIndex = right;
                        left++;
                        break;
                    }
                    right--;    //右指针左移一位
                }

                while (left<=right)
                {
                    //左指针比锚点值大
                    if (arr[left]>pivot)
                    {
                        arr[right] = arr[left];
                        pivotIndex = left;
                        right--;
                        break;
                    }
                    left++;     //左指针右移一位
                }

            }
            arr[pivotIndex] = pivot;
            return pivotIndex;
        }

        /// <summary>
        /// 指针法
        /// </summary>
        public void SortB(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int pivotIndex = partitionB(arr, startIndex, endIndex);
            SortB(arr, startIndex, pivotIndex - 1);
            SortB(arr, pivotIndex + 1, endIndex);
        }

        public int partitionB(int[] arr, int startIndex, int endIndex)
        {
            int left = startIndex+1,   //左指针
                right = endIndex,    //右指针
                pivot = arr[startIndex],  //锚点
                pivotIndex = startIndex; //锚点位置

            //while (left < right)
            //{
            //    while (arr[left]<=pivot)
            //    {
            //        left++;
            //    }


            //    while (arr[right]>pivot)
            //    {
            //        right--;
            //    }

            //    arr.Swap(left, right);
            //}

            while (left!=right)
            {
                while (left < right && arr[right] > pivot)
                {
                    right--;
                }

                while (left < right && arr[left] <= pivot)
                {
                    left++;
                }

                if (left < right)
                {
                    arr.Swap(left, right);
                }

            }


            //需要确保重合点的值也比锚点小，将锚点与指针重合点交换
            arr.Swap(left, startIndex);

            return left;
        }

        public void Run()
        {
            int[] list = new int[] { 48, 13, 65, 84, 15, 3, -39, 21 };
            SortA(list,0,list.Length-1);
            list.PrintAll();

            Console.WriteLine() ;

            list = new int[] { 48, 13, 65, 84, 15, 3, -39, 21 };
            SortB(list, 0, list.Length - 1);
            list.PrintAll();
        }
    }
}
