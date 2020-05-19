﻿using System;
 using System.Drawing;
 using func_rocket;

 namespace Asteroids
 {
     public class UFO
     {
         public Point Position { get; private set; }
         public int CountScore { get; private set; }
         public int CountLife { get; private set; }
         public bool IsDead { get; private set; }

         public UFO(Point position, int score)
         {
             Position = position;
             CountLife = 1;
             CountScore = score;
             IsDead = false;
         }

         public void Move(Map map)
         {
             while (true)
             {
                 if (Position.X == 0)
                     for (var i = 0; i < map.Weight; i++)
                     {
                         Position = new Point(Position.X + 1, Position.Y);
                     }

                 if (Position.X == map.Weight)
                     for (var i = map.Weight; i > 0; i--)
                     {
                         Position = new Point(Position.X - 1, Position.Y);
                     }
             }
         }

         public void Shoot()
         {
             var bullet = new Bullet(Position, 10, 1);
             // Написать, как пуля движется вниз
         }

         public void RemoveLife()
         {
             if (CountLife == 0)
                 throw new Exception("Жизнь уже равна 0");
             CountLife--;
             if (CountLife == 0)
                 IsDead = true;
         }

         public int ReturnScore() => IsDead ? CountScore : 0;
         
     }
 }