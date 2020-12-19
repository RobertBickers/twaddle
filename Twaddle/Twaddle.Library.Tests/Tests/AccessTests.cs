using Codetreehouse.Twaddle.Configuration;
using Codetreehouse.Twaddle.Core;
using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;

namespace Tests.UnitTesting.Color
{
    [TestFixture]
    public class AccessTests
    {
        [Test]
        public void Instance_WithDefaults_HasDefaultTypes()
        {
            Twaddle.WithDefaults.Should().BeOfType(typeof(Twaddle));

            var instance = Twaddle.WithDefaults;

            if (instance is Twaddle twaddle)
                twaddle.Configuration.Should().BeOfType(typeof(TwaddleConfiguration));
            else
                Assert.Fail();
        }

        [Test]
        public void Instance_WithConfiguration_HasDefaultTypes()
        {
            Twaddle.WithConfiguration(null, null, null, null, null, null)
                .Should()
                .BeOfType(typeof(Twaddle));

            var instance = Twaddle.WithDefaults;

            if (instance is Twaddle twaddle)
                twaddle.Configuration.Should().BeOfType(typeof(TwaddleConfiguration));
            else
                Assert.Fail();
        }

        [Test]
        public void Instance_WithConfiguration_TypeSetAsExpected()
        {
            var configuration = A.Dummy<ITwaddleConfiguration>();

            var instance = Twaddle.WithConfiguration(configuration);

            if (instance is Twaddle twaddle)
                twaddle.Configuration.Should().BeSameAs(configuration);
            else
                Assert.Fail();

            Twaddle.WithDefaults.Name.FirstName();
        }

        [Test]
        public void AccessPoints_WithDefaults_ShoudlNotBeNull()
        {
            using (new AssertionScope())
            {
                Twaddle.WithDefaults.
                    Profile.Should().NotBeNull();
                Twaddle.WithDefaults.
                    Date.Should().NotBeNull();
                Twaddle.WithDefaults.
                    Phone.Should().NotBeNull();
                Twaddle.WithDefaults.
                    Colour.Should().NotBeNull();
                Twaddle.WithDefaults.
                    Word.Should().NotBeNull();
                Twaddle.WithDefaults.
                    Name.Should().NotBeNull();
            }
        }
    }
}