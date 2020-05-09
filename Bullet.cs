﻿using System.Drawing;

namespace Asteroids
{
    public class Bullet
    {
        public Point Position;
        public double Speed;
        public Bullet(Point position)
        {
            Position = position;
        }
    }
}