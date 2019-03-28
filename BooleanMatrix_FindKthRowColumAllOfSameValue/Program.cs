using System;

namespace BooleanMatrix_FindKthRowColumAllOfSameValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Matrix - Find the Kth row whose " +
                "elements are all one and Kth column whose elements are all zero!");
            Console.WriteLine();

            int[,] matrxix = GetMatrixFromInput();
            int Rows = matrxix.GetLength(0);
            int Cols = matrxix.GetLength(1);

            Console.WriteLine();
            Console.WriteLine("The Kth row is ");
            Console.WriteLine("---------------");
            Console.WriteLine(PrintK(matrxix,Rows, Cols));

            Console.ReadLine();
        }

        private static int[,] GetMatrixFromInput() {
            int[,] result = null;

            Console.WriteLine("Enter the number of rows in the matrix");
            try
            {
                int numberRows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of columns in the matrix");
                int numberColumns = int.Parse(Console.ReadLine());
                result = new int[numberRows, numberColumns];
                for (int i = 0; i < numberRows; i++) {
                    Console.WriteLine("Enter the elements of" +
                        " row "+i+" separated by space");
                    String[] elements = Console.ReadLine().Split(' ');
                    for (int j = 0; j < numberColumns; j++) {
                        result[i, j] = int.Parse(elements[j]);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            
            return result;
        }

        private static int PrintK(int[,] matrix, int nRows, int nCols) {
            int K = -1;

            for (int i = 0; i < nRows; i++) {
                if (isK(i, matrix, nRows, nCols)) {
                    return i;
                }
            }

            return K;
        }

        private static bool isK(int i, int[,] matrix, int nRows, int nCols) {
            bool result = true;

            for (int index = 0; index < nCols; index++) {
                if (i != index) {
                    if (matrix[i, index] != 0) {
                        return false;
                    }
                 }
            }

            for (int index = 0; index < nCols; index++)
            {
                if (i != index)
                {
                    if (matrix[index, i] != 1)
                    {
                        return false;
                    }
                }
            }

            return result;

        }
    }
}
