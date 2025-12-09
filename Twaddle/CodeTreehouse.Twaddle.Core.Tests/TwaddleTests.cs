using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests;

[TestClass]
public class TwaddleTests
{
    [TestMethod]
    public void WithDefaults_NoArgs_TwaddleReturned()
    {
        ITwaddle twaddle = Twaddle.WithDefaults;

        Assert.IsNotNull(twaddle);
        Assert.IsNotNull(twaddle.Colour);
        Assert.IsNotNull(twaddle.Date);
        Assert.IsNotNull(twaddle.Name);
        Assert.IsNotNull(twaddle.Phone);
        Assert.IsNotNull(twaddle.Profile);
        Assert.IsNotNull(twaddle.Word);
    }

    [TestMethod]
    public void WithConfiguration_NoArgs_TwaddleReturned()
    {
        ITwaddle twaddle = Twaddle.WithConfiguration(
            null,
            null,
            null,
            null,
            null,
            null);

        Assert.IsNotNull(twaddle);
        Assert.IsNotNull(twaddle.Colour);
        Assert.IsNotNull(twaddle.Date);
        Assert.IsNotNull(twaddle.Name);
        Assert.IsNotNull(twaddle.Phone);
        Assert.IsNotNull(twaddle.Profile);
        Assert.IsNotNull(twaddle.Word);
    }
}