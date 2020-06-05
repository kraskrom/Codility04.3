/*
This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
*/

using System;

namespace Codility04._3
{
    class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int i = 0;
            while (i < A.Length && A[i] <= 0)
                i++;
            if (i == A.Length || A[i] > 1)
                return 1;
            i++;
            for (; i < A.Length; i++)
                if (A[i] - A[i - 1] > 1)
                    return (A[i - 1] + 1);
            return A[i - 1] + 1;
        }
    }

    class Program
    {
        static void Main()
        {
            // int[] A = { 1, 3, 6, 4, 1, 2 };
            // int[] A = { 1, 2, 3 };
            int[] A = { -1, -3 };
            Solution sol = new Solution();
            int s = sol.solution(A);
            Console.WriteLine("Solution: " + s);
        }
    }
}
