using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            //int[] nums = { 0, 1, 0, 3, 2, 3 };
            Console.WriteLine(Problem_300.LengthOfLIS(nums));
            //

            //int[][] image = new int[][] {
            //    new int[] { 1, 1, 1 }, new int[]{ 1, 1, 0 }, new int[] { 1, 0, 1 } };
            //int sr = 1;
            //int sc = 1;
            //int color = 2;
            ////Console.WriteLine(Problem_733.FloodFill(image, 1, 1, 2));
            //int[][] result = Problem_733.FloodFill(image, 1, 1, 2);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    for (int j = 0; j < result[i].Length; j++)
            //    {
            //        Console.Write($"{result[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
