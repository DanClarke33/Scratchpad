namespace ExperimentalConsoleApp.Tests
{
    using ExperimentalConsoleApp;

    using NUnit.Framework;

    using Assert = NUnit.Framework.Assert;

    [TestFixture]
    public class Apple_Tests
    {
        private Apple apple;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            this.apple = new Apple();
        }

        [Test]
        public void IsEven_ReturnsTrue_For0()
        {
            Assert.IsTrue(this.apple.IsEven(0));
        }

        [Test]
        public void IsEven_ReturnsTrue_For2()
        {
            Assert.IsTrue(this.apple.IsEven(2));
        }

        [Test]
        public void IsEven_ReturnsTrue_ForNegative2()
        {
            Assert.IsTrue(this.apple.IsEven(-2));
        }

        [Test]
        public void IsEven_ReturnsFalse_For1()
        {
            Assert.IsFalse(this.apple.IsEven(1));
        }

        [Test]
        public void IsEven_ReturnsFalse_ForNegative1()
        {
            Assert.IsFalse(this.apple.IsEven(-1));
        }
    }
}
