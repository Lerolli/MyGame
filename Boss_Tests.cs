using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using func_rocket;
using NUnit.Framework;

namespace Asteroids
{
    [TestFixture]
    public class BossTest
    {
        [Test]  
        public void RemoveLife()
        {
            var boss = new Boss(new Point(0, 0),1, 10,100);
            boss.RemoveLife();
            Assert.AreEqual(0,boss.CountLife);
        }
        
        [Test]  
        public void CheckIsDead()
        {
            var boss = new Boss(new Point(0, 0),1, 10,100);
            Assert.AreEqual(false, boss.IsDead);
            boss.RemoveLife();
            Assert.AreEqual(true,boss.IsDead);
        }
        
        [Test]  
        public void ReturnScoreDeadBoss()
        {
            var boss = new Boss(new Point(0, 0), 1, 10,100);
            boss.RemoveLife();
            Assert.AreEqual(100,boss.ReturnScore());
        }
        
        [Test]
        public void ReturnScoreNotDeadBoss()
        {
            var boss = new Boss(new Point(0, 0), 1, 10,100);
            Assert.AreEqual(0,boss.ReturnScore());
        }
    }
}