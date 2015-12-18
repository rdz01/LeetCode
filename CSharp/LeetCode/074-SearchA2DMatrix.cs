namespace LeetCode
{
    public class _074_SearchA2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int lo = 0, hi = matrix.GetLength(0) - 1, mid = 0;
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                if (matrix[mid, 0] < target) { lo = mid + 1; }
                else if (matrix[mid, 0] > target) { hi = mid - 1; }
                else { return true; }
            }
            if (hi == -1) { return false; }

            int rowId = hi;
            lo = 0;
            hi = matrix.GetLength(1) - 1;
            if (matrix[rowId, 0] > target || matrix[rowId, hi] < target)
            {
                return false;
            }
            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;
                if (matrix[rowId, mid] < target) { lo = mid + 1; }
                else if (matrix[rowId, mid] > target) { hi = mid - 1; }
                else { return true; }
            }
            return false;
        }
    }
}
