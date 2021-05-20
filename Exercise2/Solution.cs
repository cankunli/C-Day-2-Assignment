using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] a)
        {
            int count = 1, tempCount;
            int popular = a[0];
            int temp = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                temp = a[i];
                tempCount = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    if (temp == a[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    popular = temp;
                    count = tempCount;
                }
            }
            return popular;
        }
    }
}
