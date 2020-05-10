using NUnit.Framework;

namespace Asteroids
{
    [TestFixture]
    public class MapTest
    {
        [Test]
        public void SizeMoreZero()
        {
            var map = new Map(10, 10);
            Assert.AreEqual(10, map.Height);
            Assert.AreEqual(10, map.Weight);
        }
    }
}