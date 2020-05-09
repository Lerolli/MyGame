﻿﻿using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Asteroids
{
    class Player
    {
        public Point Position { get; private set; }
        public int Score { get; private set; }
        public int CountLife { get; private set; }
        
        public double Center
        public bool IsDead { get; private set; } 
                
        
        public Player(Point position, int countLife, int score)
        {
            Position = position;
            CountLife = countLife;
            Score = score;
            IsDead = false;
        }

        public void Shot()
        {
            var bullet = new Bullet(Position); 
        }

        public void Move(Keys key)
        {
            var dx = 0;
            var dy = 0;

            switch (key)
            {
                case Keys.Left:
                    dx = -1;
                    break;
                case Keys.Right:
                    dx = 1;
                    break;
                case Keys.Up:
                    dy = -1;
                    break;
                case Keys.Down:
                    dy = 1;
                    break;
            }
            Position = new Point (Position.X +dx, Position.Y + dy);
        }
        

        public void RemoveLife()
        {
            if (CountLife == 0)
                throw new Exception("Жизнь уже равна 0");
            CountLife--;
            if (CountLife == 0)
                IsDead = true;
        }

        public void AddCountScore(int count) => Score += count;
    }
}