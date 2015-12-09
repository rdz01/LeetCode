using System;

namespace LeetCode
{
    public class _064_MinimumPathSum
    {
        public int MinPathSum(int[,] grid)
        {
            var rowLenght = grid.GetLength(0);
            var columnLenght = grid.GetLength(1);

            if (rowLenght <= columnLenght)
            {
                var pathSum = new int[rowLenght];
                for (int i = 0; i < rowLenght; i++)
                    pathSum[i] = int.MaxValue;
                pathSum[0] = 0;

                for (int i = 0; i < columnLenght; i++)
                {
                    pathSum[0] += grid[0, i];
                    for (int j = 1; j < rowLenght; j++)
                        pathSum[j] = Math.Min(pathSum[j - 1], pathSum[j]) + grid[j, i];
                }
                return pathSum[rowLenght - 1];
            }
            else
            {
                var pathSum = new int[columnLenght];
                for (int i = 0; i < columnLenght; i++)
                    pathSum[i] = int.MaxValue;
                pathSum[0] = 0;

                for (int i = 0; i < rowLenght; i++)
                {
                    pathSum[0] += grid[i, 0];
                    for (int j = 1; j < columnLenght; j++)
                        pathSum[j] = Math.Min(pathSum[j - 1], pathSum[j]) + grid[i, j];
                }

                return pathSum[columnLenght - 1];
            }
        }
    }
}
