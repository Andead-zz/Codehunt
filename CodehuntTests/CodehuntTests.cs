using NUnit.Framework;

namespace Codehunt.Tests
{
    [TestFixture]
    public class CodehuntTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(7, 91)]
        [Test]
        public void Level_02_05(int n, int result)
        {
            Assert.AreEqual(result, Methods.Level_02_05(n));
        }

        [TestCase("daaaaaaadddd", 'd', 5)]
        [TestCase("paiibdeqqqqb", 'a', 1)]
        [Test]
        public void Level_02_07(string s, char x, int result)
        {
            Assert.AreEqual(result, Methods.Level_02_07(s, x));
        }

        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 7, 128)]
        [TestCase(-11, 9, 1937019605)]
        [Test]
        public void Level_03_01(int number, int power, int result)
        {
            Assert.AreEqual(result, Methods.Level_03_01(number, power));
        }
    }
}