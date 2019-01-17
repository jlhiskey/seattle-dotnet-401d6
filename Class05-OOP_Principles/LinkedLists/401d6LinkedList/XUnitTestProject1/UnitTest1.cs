using System;
using Xunit;
using _401d6LinkedList.Classes;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            LList list = new LList();

         
            list.Append(15);

            Assert.True(list.Includes(15));

        }
    }
}
