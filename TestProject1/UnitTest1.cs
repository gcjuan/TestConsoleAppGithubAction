using TestConsoleApp;
using Xunit;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			//some change
			Assert.Equal(DateTime.Now.ToString("f"), Utility.GetCurrentDate());

		}
	}
}