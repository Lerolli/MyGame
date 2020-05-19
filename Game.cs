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
        public Form form = new Form() {Size =  new Size(1920, 1080)}; 
        
        public Dictionary<int, string> ScoreTable;

        public void StartGame()
        {
            form.Size = new Size(400, 400);
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