using AisWebApp.Services;
using NUnit.Framework;

namespace AisWebApp.Tests
{
    public class SquareServiceTests
    {
        [Test]
        public void Eval_Works()
        {
            var squareService = new SquareService();

            // Arrange

            // Act
            var threeToThePower2 = squareService.Eval(3.0);

            // Asset
            Assert.AreEqual(9.0, threeToThePower2);
        }

    }

}
