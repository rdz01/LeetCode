namespace LeetCode
{
    public class _073_SetMatrixZeroes
    {
        public void SetZeroes(int[,] matrix)
        {
            var rowLength = matrix.GetLength(0);
            var columnLenght = matrix.GetLength(1);

            var rowZero = new bool[rowLength];
            var columnZero = new bool[columnLenght];

            int i, j;
            for (i = 0; i < rowLength; i++)
                for (j = 0; j < columnLenght; j++)
                    if (matrix[i, j] == 0)
                    {
                        rowZero[i] = true;
                        columnZero[j] = true;
                    }

            for (i = 0; i < rowLength; i++)
                for (j = 0; j < columnLenght; j++)
                    if (rowZero[i] || columnZero[j])
                        matrix[i, j] = 0;
        }
    }
}
