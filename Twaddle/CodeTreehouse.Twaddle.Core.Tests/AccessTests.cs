using CodeTreehouse.Twaddle.Core.Configuration;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
	[TestClass]
	public class AccessTests
	{
		[TestMethod]
		public void Instance_WithDefaults_HasDefaultTypes()
		{
			Assert.IsInstanceOfType<Twaddle>(Twaddle.WithDefaults);

			var instance = Twaddle.WithDefaults;

			if (instance is Twaddle twaddle)
				Assert.IsInstanceOfType<TwaddleConfiguration>(twaddle.Configuration);
			else
				Assert.Fail();
		}

		[TestMethod]
		public void Instance_WithConfiguration_HasDefaultTypes()
		{
			Assert.IsInstanceOfType<Twaddle>(Twaddle.WithConfiguration(null, null, null, null, null, null));

			var instance = Twaddle.WithDefaults;

			if (instance is Twaddle twaddle)
				Assert.IsInstanceOfType<TwaddleConfiguration>(twaddle.Configuration);
			else
				Assert.Fail();
		}

		[TestMethod]
		public void Instance_WithConfiguration_TypeSetAsExpected()
		{
			var configuration = A.Dummy<ITwaddleConfiguration>();

			var instance = Twaddle.WithConfiguration(configuration);

			if (instance is Twaddle twaddle)
				Assert.AreSame(configuration, twaddle.Configuration);
			else
				Assert.Fail();

			Twaddle.WithDefaults.Name.GenerateFirstName();
		}

		[TestMethod]
		public void AccessPoints_WithDefaults_ShouldNotBeNull()
		{
			Assert.IsNotNull(Twaddle.WithDefaults.Profile);
			Assert.IsNotNull(Twaddle.WithDefaults.Date);
			Assert.IsNotNull(Twaddle.WithDefaults.Phone);
			Assert.IsNotNull(Twaddle.WithDefaults.Colour);
			Assert.IsNotNull(Twaddle.WithDefaults.Word);
			Assert.IsNotNull(Twaddle.WithDefaults.Name);
		}
	}
}