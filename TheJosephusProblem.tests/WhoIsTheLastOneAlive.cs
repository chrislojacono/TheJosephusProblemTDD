using System;
using Xunit;

namespace TheJosephusProblem.tests
{
    public class WhoIsTheLastOneAlive
    {
        [Fact]
        public void Given_10_people_and_an_interval_of_3_the_last_one_should_be_4()
        {
            var killingInterval = 3;
            var numberOfPeople = 10;
            var expectedLastPersonAlive = 4;
        }
    }
}
