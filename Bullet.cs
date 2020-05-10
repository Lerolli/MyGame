﻿using System.Drawing;

namespace Asteroids
{
    public class Bullet
    {
        public Point Position { get; private set; }
        public double Speed { get; private set; }
        public double Angle { get; private set; }
        public Bullet(Point position, double speed, double angle)
        {
            Position = position;
            Speed = speed;
            Angle = angle;
        }
    }
}