using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public class Solution
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono) 1010010
            var binary = Convert.ToString(N, 2);
            var a = binary.ToCharArray();
            var m = binary.IndexOf('1', 1);
            if (m == -1) return 0;
            var b = binary.IndexOf('0');
            if (b == -1) return 0;
                List<int> sasa = new List<int>();
                var lastOccurence = 0;
                for (int i = 1; i < a.Count(); i++)
                {
                    if (a[i] == '1')
                    {
                        sasa.Add(i - (lastOccurence +1));
                        lastOccurence = i;
                    }
                }
                return sasa.Max();
            
        }
    }
}
