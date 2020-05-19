using System.Linq;
using NUnit.Framework;

namespace Asteroids
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void NullScoreboard()
        {
            var game = new Game();
            game.AddScoreInScoreTable(10, "yES");
            Assert.AreEqual("yES", game.ScoreTable[10]);
        }
        
        [Test]
        public void NotNullScoreboard()
        {
            var game = new Game();
            game.AddScoreInScoreTable(10, "Nevill");
            game.AddScoreInScoreTable(1011, "Adam");
            game.AddScoreInScoreTable(101, "Harry");
            game.AddScoreInScoreTable(110, "Hagrid");

            Assert.AreEqual("Nevill", game.ScoreTable[10]);
            Assert.AreEqual("Adam", game.ScoreTable[1011]);
            Assert.AreEqual("Harry", game.ScoreTable[101]);
            Assert.AreEqual("Hagrid", game.ScoreTable[110]);

        }

        [Test]
        public void CheckSort()
        {
            var game = new Game();
            game.AddScoreInScoreTable(10, "Nevill");
            game.AddScoreInScoreTable(1011, "Adam");
            game.AddScoreInScoreTable(101, "Harry");
            game.AddScoreInScoreTable(110, "Hagrid");

            var first = game.ScoreTable.Keys.First();

            Assert.AreEqual(1011, first);


        }
    }
}