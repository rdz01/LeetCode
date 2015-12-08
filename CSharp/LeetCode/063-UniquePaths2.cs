namespace LeetCode
{
    public class _063_UniquePaths2
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var rowLenght = obstacleGrid.GetLength(0);
            var columnLenght = obstacleGrid.GetLength(1);
            if (obstacleGrid[0, 0] == 1 || obstacleGrid[rowLenght - 1, columnLenght - 1] == 1) { return 0; }

            var possiblePath = new int[rowLenght, columnLenght];
            possiblePath[0, 0] = 1;
            for (int i = 1; i < columnLenght; i++)
            {
                if (obstacleGrid[0, i] == 0 && possiblePath[0, i - 1] == 1)
                    possiblePath[0, i] = 1;
            }
            for (int i = 1; i < rowLenght; i++)
            {
                if (obstacleGrid[i, 0] == 0 && possiblePath[i - 1, 0] == 1)
                    possiblePath[i, 0] = 1;
            }
            for (int i = 1; i < rowLenght; i++)
            {
                for (int j = 1; j < columnLenght; j++)
                {
                    if (obstacleGrid[i, j] == 0)
                        possiblePath[i, j] = possiblePath[i - 1, j] + possiblePath[i, j - 1];
                }
            }

            return possiblePath[rowLenght - 1, columnLenght - 1];
        }
    }
}
