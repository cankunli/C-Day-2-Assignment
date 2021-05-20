using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int result = 0;
            // Traverse all numbers
            for (int i = A; i <= B; i++)
                // Check if current number i is perfect square
                for (int j = 1; j * j <= i; j++)
                    if (j * j == i)
                        result++;
            return result;
        }
    }
}
