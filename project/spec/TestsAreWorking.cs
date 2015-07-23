using FluentAssertions;
using NUnit.Framework;

namespace project.spec
{
	[TestFixture]
	public class TestsAreWorking
	{

		[Test]
		public void TestShouldRun()
		{
			1.Should().Be(1);
		}
	}
}