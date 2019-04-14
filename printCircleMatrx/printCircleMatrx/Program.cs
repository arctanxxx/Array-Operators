using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printCircleMatrx
{
    class Program
    {
        public static void spiralOrderPrint(int[][] matrix)
        {
            int tr = 0;
            int tc = 0;
            int dr = matrix.Length - 1;
            int dc = matrix[0].Length - 1;
            while (tr <= dr && tc <= dc)
            {
                printEdge(matrix,tr++,tc++,dr--,dc--);
            }
        }

        public static void printEdge(int[][] m,int tr,int tc,int dr,int dc)
        {
            if (tr == dr)                           // 同一行中
            {
                for (int i = tc; i <= dc; i++)      // 从左往右打印数字
                {
                    Console.Write(m[tr][i] + " ");
                }
            }
            else if(tc == dc)                      // 同一列中
            {
                for(int i = tr;i <= dr;i++)        // 从上往下打印
                {
                    Console.Write(m[i][tc] + " ");
                }
            }
            else
            {
                int curC = tc;
                int curR = tr;
                while (curC != dc)
                {
                    Console.Write(m[tr][curC] + " ");
                    curC++;
                }
                while (curR != dr)
                {
                    Console.Write(m[curR][dc] + " ");
                    curR++;
                }
                while (curC!=tc)
                {
                    Console.Write(m[dr][curC] + " ");
                    curC--;
                }
                while (curR!=tr)
                {
                    Console.Write(m[curR][tc] + " ");
                    curR--;
                }
            }

        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[4] { 5, 6, 7, 8 };
            matrix[2] = new int[4] { 9, 10, 11, 12 };
            matrix[3] = new int[4] { 13, 14, 15, 16 };
            // {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            spiralOrderPrint(matrix);
            Console.ReadKey();

        }
    }
}
