using Codility;
using System;
using Xunit;

namespace CodilityTests
{
    public class SolutionTests
    {
        
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(32, 0)]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(1610612737, 28)]
        [InlineData(1376796946, 5)]
        [InlineData(805306373, 25)]
        [InlineData(74901729, 4)]
        [InlineData(6291457, 20)]
        [InlineData(66561,9 )]
        [InlineData(51712, 2)]
        [InlineData(1162, 3)]
        [InlineData(19, 2)]
        [InlineData(42,1)]
        [InlineData(328,2)]
        public void Solution_shouldReturn_CorrectResults(int n, int result)
            {
                Solution sln = new Solution();
                var j = sln.solution(n);
                Assert.Equal(result, j);
            }
        
    }
}
