using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    internal class Problem_733
    {
        static public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int temp = image[sr][sc];   /// 기존의 값 저장
            image[sr][sc] = color;      // 새로운 값 갱신

            if (sr - 1 >= 0 && (image[sr - 1][sc] == temp)) // 왼쪽 
            {
                FloodFill(image, sr - 1, sc, color); /// 왼
            }
            if (sr + 1 < image.Length && (image[sr + 1][sc] == temp))
            {
                FloodFill(image, sr + 1, sc, color); /// 오른
            }
            if (sc - 1 >= 0 && (image[sr][sc - 1] == temp))
            {
                FloodFill(image, sr, sc - 1, color); /// 위
            }
            if (sc + 1 < image[sc].Length && (image[sr][sc + 1] == temp))
            {
                FloodFill(image, sr, sc + 1, color); /// 아래
            }
            return image;
        }
    }
}