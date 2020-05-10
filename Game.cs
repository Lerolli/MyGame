using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Asteroids;

namespace Asteroids
{
    public class Game
    {
        public Dictionary<int, string> ScoreTable;

        public void StartGame()
        {
            //var form = new Form();
            var map = new Map(300, 200);
            var player = new Player(new Point(map.Height/2, map.Weight/2),3, 0);
            
            while (player.CountLife != 0)
            {
                var asteroid = new Asteroid();
                Thread.Sleep(30000);
                var boss = new Boss(10, 1, new Point(map.Height / 4, map.Weight/ 2), 100);

            }

            var name = Console.ReadLine();
            AddScoreInScoreTable(player.Score, name);
        }

        public void AddScoreInScoreTable(int score, string name)
        {
            var beatRecord = false;
            if (ScoreTable == null)
            {
                ScoreTable = new Dictionary<int, string>();
                ScoreTable.Add(score, name);
            }
            else
            {
                // foreach (var pair in ScoreTable.Where(pair => pair.Key <= score))
                // {
                //     beatRecord = true;
                //     
                // }
                ScoreTable.Add(score, name);
                ScoreTable = ScoreTable.OrderBy(x => x.Key).Reverse()
                    .ToDictionary(x => x.Key, x => x.Value);
                var lastCount = ScoreTable.Keys.ElementAt(ScoreTable.Count - 1);
                     
            }
        }
    }
}