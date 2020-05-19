using System.Drawing;

namespace Asteroids
{
    public abstract class IEnemy
    {
        public int CountLife;
        public int BulletDamage;
        public Point Position;
        public int CountScore;
        public bool IsDead;
        public abstract void Move();
        public abstract int ReturnScore();
    }
}