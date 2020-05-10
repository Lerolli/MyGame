﻿﻿using System;
 using System.Drawing;
  using System.Linq;

  namespace Asteroids
{
    public class Boss
    {
        public int CountLife { get; private set; }
        public int BulletDamage { get; private set; }
        public Point Position { get; private set; }
        public int CountScore { get; private set; }
        public bool IsDead { get; private set; }

        public Boss(int countLife, int bulletDamage, Point position, int countScore)
        {
            CountScore = countScore;
            CountLife = countLife;
            BulletDamage = bulletDamage;
            Position = position;
            IsDead = false || CountLife == 0;
        }

        public void Move()
        {
            for (var dx = 0; dx >= -3; dx--)
                Position = new Point(Position.X + dx, Position.Y);

            var array = new int[7];
            var temp = -3;
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = temp;
                temp++;
            }
            
            while (!IsDead)
            {
                foreach (var dx in array)
                {
                    Position = new Point(Position.X + dx, Position.Y);
                }

                array.Reverse();
            }
            
        }
        public int ReturnScore() => IsDead ? CountScore : 0;

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