using System;
using System.Drawing;

namespace func_rocket
{
    public class Boss
    {
        public Point Position;
        public int CountLife;
        private int CountScore;
        public bool IsDead;
        public readonly Image Image;
        private Point startPosition;
        private bool isRight = true;
        private double Direction;
        public Boss(Point position, int countLife, int bulletDamage, int countScore)
        {
            startPosition = position;
            Position = position;
            CountScore = countScore;
            CountLife = countLife;
            IsDead = false || CountLife == 0;
            Image = new Bitmap("D:\\Учеба\\ЯТП\\Asteroid\\images\\boss.jpg");
        }
        public void Move()
        {
            if (Position.X <= startPosition.X + 50 && isRight)
                Position = new Point(Position.X + 1, Position.Y);
            else
            {
                Position = new Point(Position.X - 1, Position.Y);
                isRight = false;
            }

            if (Position.X <= startPosition.X - 50)
                isRight = true;
        }
        public  int ReturnScore() => IsDead ? CountScore : 0;

        public void RemoveLife()
        {
            if (CountLife == 0)
                throw new Exception("У босса нет здоровья");
            CountLife--;
            if (CountLife == 0)
            {
                IsDead = true;
            }
        }
    }
}