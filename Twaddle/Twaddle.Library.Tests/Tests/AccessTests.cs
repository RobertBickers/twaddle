using Bickers.Twaddle.Core;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;

namespace Tests.UnitTesting.Color
{
	[TestFixture]
	public class AccessTests
	{
		[Test]
		public void Callers_All_ShoudlNotBeNull()
		{
			using (new AssertionScope())
			{
				Twaddle.Profile.Should().NotBeNull();
				Twaddle.Date.Should().NotBeNull();
				Twaddle.Phone.Should().NotBeNull();
				Twaddle.Colour.Should().NotBeNull();
				Twaddle.Word.Should().NotBeNull();
				Twaddle.Name.Should().NotBeNull();
			}
		}
	}
}
