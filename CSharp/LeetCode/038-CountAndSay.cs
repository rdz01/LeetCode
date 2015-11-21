using System.Text;

namespace LeetCode
{
    public class _038_CountAndSay
    {
        public string CountAndSay(int n)
        {
            var result = "1";
            char currentCh;
            int i, j, count;
            var builder = new StringBuilder();

            for (i = 1; i < n; i++)
            {
                currentCh = result[0];
                count = 1;
                for (j = 1; j < result.Length; j++)
                {
                    if (currentCh != result[j])
                    {
                        builder.Append(count);
                        builder.Append(currentCh);
                        currentCh = result[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                builder.Append(count);
                builder.Append(currentCh);

                result = builder.ToString();
                builder.Clear();
            }

            return result;
        }
    }
}
