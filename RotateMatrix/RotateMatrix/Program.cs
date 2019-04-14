using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        public static void rotate(int[][] matrix)
        {
            int tR = 0;
            int tC = 0;
            int dR = matrix.Length - 1;
            int dC = matrix[0].Length - 1;
            while (tR < dR)
            {
                rotateEdge(matrix, tR++, tC++, dR--, dC--);
            }
        }

        public static void rotateEdge(int[][] m,int tR,int tC,int dR,int dC)
        {
            int times = dC - tC;
            int tmp = 0;
            for (int i = 0; i != times; i++)
            {
                tmp = m[tR][tC + i];
                m[tR][tC + i] = m[dR - i][tC];
                m[dR - i][tC] = m[dR][dC - i];
                m[dR][dC - i] = m[tR + i][dC];
                m[tR+i][dC] = tmp;
            }
        }

        public static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i != matrix.Length; i++)
            {
                for (int j = 0; j != matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine("\n\n");
            }
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[4] { 5, 6, 7, 8 };
            matrix[2] = new int[4] { 9, 10, 11, 12 };
            matrix[3] = new int[4] { 13, 14, 15, 16 };
            printMatrix(matrix);
            rotate(matrix);
            printMatrix(matrix);
            Console.ReadKey();

        }
    }
}
