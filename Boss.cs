﻿﻿using System;
 using System.Drawing;

 namespace Asteroids
{
    public class Boss
    {
        public int Hp;
        public int BulletDamage;
        public Point Position;

        public bool IsDead = false;

        public Boss(int hp, int bulletDamage, Point position, bool isDead)
        {
            Hp = hp;
            BulletDamage = bulletDamage;
            Position = position;
            IsDead = isDead;
        }

        public void DoDamage()
        {
            if (Hp == 0)
                throw new Exception("У босса нет здоровья");
            Hp--;
            if (Hp == 0)
            {
                IsDead = true;
            }
        }
        
        
    }
}