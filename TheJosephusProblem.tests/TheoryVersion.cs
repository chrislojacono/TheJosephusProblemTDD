using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheJosephusProblemTDD;

namespace TheJosephusProblem.tests
{
    public class TheoryVersion
    {
        [Theory]
        [InlineData(7, 2, 7)]
        [InlineData(10, 3, 4)]
        public void Find_the_last_man_standing(int numberOfPeople, int killingInterval, int expectedResult)
        {
            var lastPersonStanding = new LastPersonStanding();

            var lastOneAliveResult = lastPersonStanding.JosephusCalculator(numberOfPeople, killingInterval);

            Assert.Equal(expectedResult, lastOneAliveResult);
        }
    }
}
