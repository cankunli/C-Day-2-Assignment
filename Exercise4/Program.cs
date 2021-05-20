using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiral s = new Spiral();
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 5, 6, 7 }, { 9, 8, 7 } };
        }

        public IList<int> SpiralOrder(int[,] matrix)
        {
            if (matrix == null)
                return null;

            IList<int> list = new List<int>();
            int rowMin = 0, colMin = 0, rowMax = matrix.GetLength(0) - 1, colMax = matrix.GetLength(1) - 1, currentRow = 0, currentCol = 0;

            while (rowMin <= rowMax && colMin <= colMax)
            {
                currentCol = colMin;
                while (currentCol <= colMax)
                    list.Add(matrix[rowMin, currentCol++]);

                currentRow = rowMin + 1;
                while (currentRow <= rowMax)
                    list.Add(matrix[currentRow++, colMax]);

                if (rowMin != rowMax && colMin != colMax)
                {
                    currentCol = colMax - 1;
                    while (currentCol >= colMin)
                        list.Add(matrix[rowMax, currentCol--]);

                    currentRow = rowMax - 1;
                    while (currentRow > rowMin)
                        list.Add(matrix[currentRow--, colMin]);
                }

                rowMin++;
                colMin++;
                rowMax--;
                colMax--;
            }

            return list;
        }
    }
}
