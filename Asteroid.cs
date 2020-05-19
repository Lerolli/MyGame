using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Asteroids
{

    public class Form1 : Form
    {
        public Form1()
        {
        }

        /* public class pictureBox1 : PictureBox // Зачем??
        {
            new public int Width => 10;
            new public int Height => 10;

        }

        public Bitmap Draw(int width, int height) // Зачем??
        {
            var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillRectangle(new SolidBrush(Color.White), 10, 10, 100, 100);

            return bitmap;
        }*/

        private void Form1_Paint(object sender, MouseEventArgs e)
        {
            
        }
    }
    public class Asteroid
    {
        // создаешь задание на рисование, потом в конструкторе формы добавляешь его на действие
    }
}