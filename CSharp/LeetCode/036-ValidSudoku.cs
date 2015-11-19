namespace LeetCode
{
    public class _036_ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            int i, j, value;
            bool[] used = new bool[9];

            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++) { used[j] = false; }
                for (j = 0; j < 9; j++)
                {
                    value = board[i, j] - '0' - 1;
                    if (value > 8 || value < 0) { continue; }
                    if (used[value]) { return false; }
                    used[value] = true;
                }

                for (j = 0; j < 9; j++) { used[j] = false; }
                for (j = 0; j < 9; j++)
                {
                    value = board[j, i] - '0' - 1;
                    if (value > 8 || value < 0) { continue; }
                    if (used[value]) { return false; }
                    used[value] = true;
                }
            }

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (i = 0; i < 9; i++) { used[i] = false; }

                    for (i = r * 3; i < (r + 1) * 3; i++)
                    {
                        for (j = c * 3; j < (c + 1) * 3; j++)
                        {
                            value = board[i, j] - '0' - 1;
                            if (value > 8 || value < 0) { continue; }
                            if (used[value]) { return false; }
                            used[value] = true;
                        }
                    }
                }
            }

            return true;
        }
    }
}
