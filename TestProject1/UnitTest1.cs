using TestConsoleApp;
using Xunit;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal(DateTime.Now.ToString("f"), Utility.GetCurrentDate());
		}

        [Fact]
        public void Test2()
        {
			// some comment
            Assert.Equal(DateTime.Now.ToString("f"), Utility.GetCurrentDate());
        }
    }
}