using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class LeetCode
{
    public static int MaxCoins(int[] piles)
    {
        Array.Sort(piles);

        var sum = 0;

        for (var i = piles.Length - 2; i >= piles.Length / 3; i -= 2)
        {
            sum += piles[i];
        }

        return sum;
    }

    private static readonly Dictionary<int, List<TreeNode>> memo = new Dictionary<int, List<TreeNode>>();

    public static IList<TreeNode> AllPossibleFBT(int N)
    {
        if (!memo.ContainsKey(N))
        {
            var result = new List<TreeNode>();
            if (N == 1)
            {
                result.Add(new TreeNode(0));
            }
            else if (N % 2 == 1)
            {
                for (int leftNodes = 0; leftNodes < N; leftNodes++)
                {
                    var rightNodes = N - leftNodes - 1;
                    foreach (var left in AllPossibleFBT(leftNodes))
                    {
                        foreach (var right in AllPossibleFBT(rightNodes))
                        {
                            var root = new TreeNode(0);
                            root.left = left;
                            root.right = right;
                            result.Add(root);
                        }
                    }
                }
            }

            memo[N] = result;
        }

        return memo[N];
    }

    public int MyAtoi(string s)
    {
        int i = 0, result = 0, sign = 1;
        if (s.Length == 0) return 0;

        //Discard whitespaces in the beginning
        while (i < s.Length && s[i] == ' ')
            i++;

        // Check if optional sign if it exists
        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
            sign = (s[i++] == '-') ? -1 : 1;

        // Build the result and check for overflow/underflow condition
        while (i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && ConvertToInt(s[i]) > int.MaxValue % 10))
            {
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }
            result = result * 10 + ConvertToInt(s[i++]);
        }
        return result * sign;
    }

    private int ConvertToInt(char c)
    {
        return c - '0';
    }

    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0 | (dividend == int.MinValue && divisor == -1))
            return int.MaxValue;

        var sign = (dividend > 0) ^ (divisor > 0);
        var positiveDevidend = (uint)(dividend < 0 ? -dividend : dividend);
        var positiveDivisor = (uint)(divisor < 0 ? -divisor : divisor);

        var reminder = 0;

        for (var i = 31; i >= 0; i--)
        {
            // x>>i = x/2^i
            if ((positiveDevidend >> i) >= positiveDivisor)
            {
                reminder = reminder << 1 | 0x01;
                positiveDevidend -= positiveDivisor << i;
            }
            else
            {
                // x << i = x * 2^i
                reminder = reminder << 1;
            }                
        }
        return sign ? -reminder : reminder;
    }

}
