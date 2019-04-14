using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findNumberInSortedMatrix
{
    class Program
    {
        public static bool isContains(int[][] matrix,int k)
        {
            int row = 0;
            int col = matrix[0].Length - 1;
            while (row < matrix.Length && col > -1)
            {
                if (matrix[row][col] == k)
                    return true;
                else if(matrix[row][col] > k)
                    col--;
                else
                    row++;                
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[5] { 1, 2, 9,11,22 };
            matrix[1] = new int[5] { 5,7,10,13,28 };
            matrix[2] = new int[5] { 6,9,12,20,100 };

            int k = 12;
            Console.Write(isContains(matrix, k));
            Console.WriteLine();
            int k1 = 3;
            Console.Write(isContains(matrix, k1));
            Console.ReadKey();
        }
    }
}
