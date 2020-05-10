using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using NUnit.Framework;

namespace Asteroids
{
    [TestFixture]
    public class Player_Tests
    {
        [Test]  
        public void RemoveLife()
        {
            var player = new Player(new Point(1, 1),1, 0);
            player.RemoveLife();
            Assert.AreEqual(0,player.CountLife );
        }
        
        [Test]  
        public void CheckIsDead()
        {
            var player = new Player(new Point(1, 1),1, 0);
            Assert.AreEqual(false, player.IsDead);
            player.RemoveLife();
            Assert.AreEqual(true,player.IsDead);
        }
        
        [Test]  
        public void AddScore()
        {
            var player = new Player(new Point(1, 1),1, 10);
            player.AddCountScore(100);
            Assert.AreEqual(110,player.Score);
            player.AddCountScore(-110);
            Assert.AreEqual(110, player.Score);
        }
        
        [Test]  
        public void AddNegativeScore()
        {
            var player = new Player(new Point(1, 1),1, 10);
            player.AddCountScore(-110);
            Assert.AreEqual(10, player.Score);
        }
        
        [Test]  
        public void SingleMove()
        {
            var player = new Player(new Point(0, 0),1, 10);
            player.Move(Keys.Right);
            Assert.AreEqual(new Point(1, 0), player.Position);
            player.Move(Keys.Left);
            Assert.AreEqual(new Point(0, 0), player.Position);
            player.Move(Keys.Up);
            Assert.AreEqual(new Point(0, -1), player.Position);
            player.Move(Keys.Down);
            Assert.AreEqual(new Point(0, 0), player.Position);
        }
        
        [Test] 
        public void IncorrectButton()
        {
            var player = new Player(new Point(0, 0),1, 10);
            player.Move(Keys.K);
            Assert.AreEqual(new Point(0, 0),player.Position);
        }

        [Test]
        public void AddDeadPlayer()
        {
            var player = new Player(new Point(0, 0),0, 10);
            Assert.AreEqual(true,player.IsDead);
            
        }
    }
}