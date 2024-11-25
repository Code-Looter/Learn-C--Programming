using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void One_Dimensional_Arrays()
        {
            int[] arr1;
            int[] arr2 = null;
            int[] arr3 = new int[6];
            int[] arr4 = new int[] { 1, 1, 2, 3, 5, 8 };
            int[] arr5 = new int[6] { 1, 1, 2, 3, 5, 8 };
            int[] arr6 = { 1, 1, 2, 3, 5, 8 };

            // Second Example
            for (int i = 0; i < arr6.Length; i++)
                Console.WriteLine(arr6[i]);

            foreach (int element in arr6)
                Console.WriteLine(element);

            // Third example
            for (int i = 0; i < arr6.Length; ++i)
                arr6[i] *= 2;  // OK
            foreach (int element in arr6)
                element *= 2;  // error
        }

        public void Multi_Dimensional_Array()
        {
            // First Example 
            int[,] arr1;
            arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr2 = null;
            int[,] arr3 = new int[2, 3];
            int[,] arr4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr5 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Second Example
            for (int i = 0; i < arr6.GetLength(0); ++i)
            {
                for (int j = 0; j < arr6.GetLength(1); ++j)
                {
                    Console.Write($"{arr6[i, j]} ");
                }
                Console.WriteLine();
            }

            // Third Example
            int[,,] arr7 = new int[4, 3, 2]
                {
                    { { 11, 12}, { 13, 14}, {15, 16 } },
                    { { 21, 22}, { 23, 24}, {25, 26 } },
                    { { 31, 32}, { 33, 34}, {35, 36 } },
                    { { 41, 42}, { 43, 44}, {45, 46 } }
                };
        }

        public void Jagged_Array()
        {
            int[][] arr1;
            int[][] arr2 = null;
            int[][] arr3 = new int[2][];
            arr3[0] = new int[3];
            arr3[1] = new int[] { 1, 1, 2, 3, 5, 8 };
            int[][] arr4 = new int[][]
            {
new int[] { 1, 2, 3 },
new int[] { 1, 1, 2, 3, 5, 8 }
            };
            int[][] arr5 =
            {
new int[] { 1, 2, 3 },
new int[] { 1, 1, 2, 3, 5, 8 }
};
            int[][,] arr6 = new int[][,]
            {
new int[,] { { 1, 2}, { 3, 4 } },
new int[,] { {11, 12, 13}, { 14, 15, 16} }
            };

            // Second example
            for (int i = 0; i < arr5.Length; ++i)
            {
                for (int j = 0; j < arr5[i].Length; ++j)
                {
                    Console.Write($"{arr5[i][j]} ");
                }
                Console.WriteLine();
            }
        } // Jagged_Array method
    }
}
