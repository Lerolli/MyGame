﻿﻿using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
  using NUnit.Framework;

  namespace Asteroids
{
    public class Player
    {
        public Point Position;
        public int Score { get; private set; }
        public int CountLife { get; private set; }
        public bool IsDead { get; private set; }
        public Image Image { get; }
        public int Size { get; }
        public double Direction = Math.PI / 2;
        public bool shoot;
        
                
        
        public Player(Point position, int countLife, int score)
        {
            Position = position;
            CountLife = countLife;
            Score = score;
            IsDead = false || countLife == 0;
            Image = new Bitmap("D:\\Учеба\\ЯТП\\Asteroid\\images\\rocket.png");
            Size = 50;
        }

        public void Shot(Keys key, Bullet bullet)
        {
            if (key == Keys.Space)
            {
                bullet.Position = Position;
            }
        }
        public void Move(Keys key, Bullet bullet)
        {
            var dx = 0;
            var dy = 0;

            switch (key)
            {
                case Keys.A:
                    dx = -5;
                    if (Direction != Math.PI)
                    {
                        Image.RotateFlip(GetDirection(Direction, Math.PI));
                        Direction = Math.PI;
                    }
                    break;
                case Keys.D:
                    dx = 5;
                    if (Direction != 0)
                    {
                        Image.RotateFlip(GetDirection(Direction, 0));
                        Direction = 0;
                    }
                    break;
                case Keys.W:
                    dy = -5;
                    if (Direction != Math.PI / 2)
                    {
                        Image.RotateFlip(GetDirection(Direction, Math.PI / 2));
                        Direction = Math.PI / 2;
                    }
                    break;
                case Keys.S:
                    dy = 5;
                    if (Direction != Math.PI / 2 * 3)
                    {
                        Image.RotateFlip(GetDirection(Direction, Math.PI / 2 * 3));
                        Direction = Math.PI / 2 * 3;
                    }
                    break;
            }
            Position = new Point(Position.X + dx, Position.Y + dy);
            bullet.Position = Position;
        }

        private RotateFlipType GetDirection(double oldDirection, double newDirection)
        {
            switch (oldDirection)
            {
                case 0:
                    switch (newDirection)
                    {
                        case Math.PI / 2:
                            return RotateFlipType.Rotate90FlipXY;
                        case Math.PI:
                            return RotateFlipType.Rotate180FlipXY;
                        case Math.PI / 2 * 3:
                            return RotateFlipType.Rotate270FlipXY;
                    }

                    break;
                case Math.PI / 2:
                    switch (newDirection)
                    {
                        case Math.PI:
                            return RotateFlipType.Rotate90FlipXY;
                        case Math.PI / 2 * 3:
                            return RotateFlipType.Rotate180FlipXY;
                        case 0:
                            return RotateFlipType.Rotate270FlipXY;
                    }

                    break;
                case Math.PI:
                    switch (newDirection)
                    {
                        case Math.PI / 2 * 3:
                            return RotateFlipType.Rotate90FlipXY;
                        case 0:
                            return RotateFlipType.Rotate180FlipXY;
                        case Math.PI / 2:
                            return RotateFlipType.Rotate270FlipXY;
                    }

                    break;
                case Math.PI / 2 * 3:
                    switch (newDirection)
                    {
                        case 0:
                            return RotateFlipType.Rotate90FlipXY;
                        case Math.PI / 2:
                            return RotateFlipType.Rotate180FlipXY;
                        case Math.PI:
                            return RotateFlipType.Rotate270FlipXY;
                    }

                    break;
            }

            return RotateFlipType.RotateNoneFlipNone;
        }
        
        public void RemoveLife()
        {
            if (CountLife == 0)
                throw new Exception("Жизнь уже равна 0");
            CountLife--;
            if (CountLife == 0)
                IsDead = true;
        }

        public void AddCountScore(int count)
        {
            if (count > 0)
                Score += count;
            else
                Console.WriteLine("Нельзя добавлять отрицательные очки или 0");
        } 
    }
}