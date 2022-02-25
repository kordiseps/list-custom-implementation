using System;
using Xunit;

namespace CustomList.Lib.Tests
{
    public class CustomListTest
    {
        [Fact]
        public void Should_Add_Item()
        {
            var value = 5;
            var customList = new CustomList<int>();
            customList.Add(value);

            Assert.NotNull(customList);
            Assert.Equal(1, customList.Count);
            Assert.Equal(value, customList[0]);
        }

        [Fact]
        public void Should_Update_Item()
        {
            var value = 5;
            var customList = new CustomList<int>();
            customList.Add(1);

            Assert.Equal(1, customList[0]);

            customList[0] = value;

            Assert.Equal(value, customList[0]);
        }


        [Fact]
        public void Should_Multiple_Item()
        {
            var first = 5;
            var second = 10;
            var third = 15;
            var customList = new CustomList<int>();
            customList.Add(first);
            customList.Add(second);
            customList.Add(third);

            Assert.Equal(3, customList.Count);
            Assert.Equal(first, customList[0]);
            Assert.Equal(second, customList[1]);
            Assert.Equal(third, customList[2]);
        }
    }
}
