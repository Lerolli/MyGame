﻿ using System;
  using System.Drawing;
  
  namespace Asteroids
 {
    public class Bullet
    {
        public bool BulletAlreadyShot;
        public Point Position;
        public Point StartPosition;
        private double Direction;
        public Image Image;
        public bool isDead  = false;
        public Bullet(Point position, double speed, double direction)
        {
            Position = position;
            Direction = direction;
            Image = new Bitmap("D:\\Учеба\\ЯТП\\Asteroid\\images\\bullet.png");
            StartPosition = position;
        }

        public void Go(double direction, Point position )
        {
            Direction = direction;
            if (Position == StartPosition)
            {
                Position = position;
                isDead = false;
            }
            if (Position.X < 500 && Position.X > 0 && Position.Y > 0 && Position.Y < 500 && !isDead)
                switch (Direction)
                {
                    case 0:
                        Position = new Point(Position.X + 10, Position.Y);
                        break;
                    case Math.PI / 2:
                        Position = new Point(Position.X, Position.Y - 10);
                        break;
                    case Math.PI:
                        Position = new Point(Position.X - 10, Position.Y);
                        break;
                    case Math.PI / 2 * 3:
                        Position = new Point(Position.X, Position.Y + 10);
                        break;
                }
            else
            {
                isDead = true;
                Position = StartPosition;
            }
        }

        public bool hitTarget(Point positionEnemy, int size )
        {
            for (var x = 0; x < positionEnemy.X + size; x++)
                for (int y = 0; y < positionEnemy.X + size; y++)
                {
                    var temp = new Point(x, y);
                    var temp2 = new Point(Position.X + 5, Position.Y + 5);
                    if (temp == temp2)
                        return true;
                }

            return false;
        }
    }
}