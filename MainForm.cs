using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Asteroids;

namespace func_rocket
{
    public partial class MainForm : Form
    {
        
        private Player player;
        private Boss boss;
        private Bullet bullet;
        private Bullet bossBullet;
        private bool bulletExist = false;
        public MainForm()
        {
            Height = 500;
            Width = 500;
            InitializeComponent();
            Init();
            Invalidate();
        }

        private void Init()
        {
            DoubleBuffered = true;
            player = new Player(new Point(100, 100), 10, 10);
            player.Position = new Point(player.Position.X  - player.Size / 2, player.Position.Y  - player.Size / 2);
            boss = new Boss(new Point(Width / 4, Height / 8),3, 1, 100);
            bullet = new Bullet(player.Position, 10, player.Direction);
            bossBullet = new Bullet(new Point(boss.Position.X + 40, boss.Position.Y + 40),10, Math.PI / 2 * 3);
            
            KeyDown += MovePlayer;
            KeyDown += ShootPlayer;
            
            var timer = new Timer {Interval = 10};
            timer.Tick += TimerTick;
            timer.Start();
        }

        
        private void TimerTick(object sender, EventArgs e)
        {
            
            boss.Move();
            BossShot();
            BulletShot();
            Invalidate();
            Update();

        }
        
        private void MovePlayer(object sender, KeyEventArgs e)
        {
            player.Move(e.KeyCode, bullet);
        }

        private void BossShot()
        {
            bossBullet.Go(Math.PI / 2 * 3, boss.Position);
            if (bossBullet.BulletAlreadyShot & bossBullet.hitTarget(player.Position, player.Size))
            {
                player.Position = new Point(1000, 1000);
                player.RemoveLife();
            }
        }
        private void ShootPlayer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                bulletExist = true;
        }

        private void BulletShot()
        {
            if (bulletExist)
            {
                if (bullet.isDead)
                    bulletExist = false;
                bullet.Go(player.Direction, player.Position);
                
                if (bullet.hitTarget(boss.Position, player.Size))
                {
                    
                    boss.RemoveLife();
                }

                if (boss.IsDead)
                {
                    boss.Position = new Point(1000, 1000);
                    bossBullet.Position = new Point(1000, 1000);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(bullet.Image, bullet.Position.X + player.Size / 2, bullet.Position.Y  + player.Size / 2, 10, 10);
            e.Graphics.DrawImage(bossBullet.Image, bossBullet.Position.X + 100, bossBullet.Position.Y  + 100, 10, 10);
            e.Graphics.DrawImage(boss.Image, boss.Position.X, boss.Position.Y, 200, 200);
            e.Graphics.DrawImage(player.Image, player.Position.X, player.Position.Y, player.Size, player.Size);
        }
    }
}