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
            int[] heights = new int[] { 2, 1, 5, 6, 2, 3 };
            Console.WriteLine(Problem_84.FindLargestRect(heights));
        }
    }
}
