using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using func_rocket;
using NUnit.Framework;

namespace Asteroids
{
    [TestFixture]
    public class UFO_Tests
    {
        [Test]  
        public void RemoveLife()
        {
            var ufo = new UFO(new Point(1, 1), 10);
            ufo.RemoveLife();
            Assert.AreEqual(0,ufo.CountLife );
        }
        
        [Test]  
        public void CheckIsDead()
        {
            var ufo = new UFO(new Point(1, 1),10);
            Assert.AreEqual(false, ufo.IsDead);
            ufo.RemoveLife();
            Assert.AreEqual(true,ufo.IsDead);
        }
        
        [Test]  
        public void ReturnScoreDeadUFO()
        {
            var ufo = new UFO(new Point(1, 1),10);
            ufo.RemoveLife();
            Assert.AreEqual(10,ufo.ReturnScore());
        }
        
        [Test]
        public void ReturnScoreNotDeadUFO()
        {
            var ufo = new UFO(new Point(1, 1),10);
            Assert.AreEqual(0,ufo.ReturnScore());
        }
    }
}