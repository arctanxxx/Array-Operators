using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagPrintMatrix
{
    class Program
    {
        public static void printMatrixZigZag(int[][] matrix)
        {
            // (tR,tC)：右上角坐标 
            // (dR,dC)：左下角坐标
            int tR = 0;
            int tC = 0;
            int dR = 0;
            int dC = 0;
            // 最大行
            int endR = matrix.Length - 1;
            // 最大列
            int endC = matrix[0].Length - 1;
            // 打印方向
            bool fromUp = false;
            // 右上角行大于最大行就结束
            while (tR != endR + 1)
            {
                printLevel(matrix,tR,tC,dR,dC,fromUp);
                tR = tC == endC ? tR + 1 : tR;
                tC = tC == endC ? tC : tC + 1;
                dC = dR == endR ? dC + 1 : dC;
                dR = dR == endR ? dR : dR + 1;
                fromUp = !fromUp;
            }
            Console.WriteLine();
        }

        public static void printLevel(int[][] m,int tR,int tC,int dR,int dC,bool fromUp)
        {
            if(fromUp)
            {
                while(tR!=dR+1)
                    Console.Write(m[tR++][tC--] + " ");
            }else{
                while (dR!=tR - 1)                
                    Console.Write(m[dR--][dC++] + " ");              
            }
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[5] { 1, 2, 3, 4,5 };
            matrix[1] = new int[5] { 6, 7, 8 ,9,10};
            matrix[2] = new int[5] { 11, 12,13,14,15 };
            printMatrixZigZag(matrix);
            Console.ReadKey();
        }
    }
}
