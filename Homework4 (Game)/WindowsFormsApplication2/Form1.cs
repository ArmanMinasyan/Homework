using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private static object locker = new object();
        Gameobject hero = new Gameobject();
        Enemy enemy = new Enemy();
        Life life = new Life();
        public Form1()
        {
            InitializeComponent();
            hero.locationX = 100;
            hero.locationY = 180;
            enemy.locationX = 10;
            enemy.locationY = 1;
            hero.health = 1;
            enemy.speed = 1;
        }

        public void DrawandMove()
        {
            lock (locker)
            {
                Graphics graphicsObj = pictureBox1.CreateGraphics();
                Rectangle[] enemyRect = new Rectangle[3];
                for (int index = 0; index <= 300; ++index)
                {
                    graphicsObj.Clear(Color.Teal);
                    Rectangle heroRect = new Rectangle(hero.locationX, hero.locationY, 30, 30);
                    enemy.locationY = 2 * index;
                    life.locationY = 2 * index;
                    for (int j = 0; j < 3; j++)
                        enemyRect[j] = new Rectangle(enemy.locationX * j * 10, enemy.locationY * enemy.speed + 1, 30, 30);
                    Rectangle lifeRect = new Rectangle(life.locationX, life.locationY, 20, 20);
                    Brush brush = new SolidBrush(Color.Blue);
                    Brush brush1 = new SolidBrush(Color.Black);
                    Brush brushlife = new SolidBrush(Color.Red);
                    graphicsObj.FillRectangle(brushlife, lifeRect);
                    graphicsObj.FillRectangle(brush, heroRect);
                    for (int i = 0; i < 3; i++)
                        graphicsObj.FillRectangle(brush1, enemyRect[i]);
                    if (index / enemy.speed > 100)
                        index = 0;
                    for (int j = 0; j < 3; j++)
                        if (enemy.locationY > 150 &&
                            (enemy.locationX * j * 10 > hero.locationX - 30 &&
                             enemy.locationX * j * 10 < hero.locationX + 30))
                        {

                            index = 0;
                            if (hero.health > 0)
                            {
                                --hero.health;
                                progressBar1.Value = hero.health;
                            }

                            else MessageBox.Show("lose");
                        }
                    if (life.locationY > 160 && (life.locationX > hero.locationX - 20 &&
                                                 life.locationX < hero.locationX + 20))
                    {
                        index = 0;
                        ++hero.health;
                        progressBar1.Value = hero.health;
                        progressBar1.Step = 10;
                    }
                    if (hero.health > 3)
                        hero.speed = 2;
                    Thread.Sleep(50);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread th1 = new Thread(DrawandMove);
            th1.Start();
          //  MessageBox.Show("1");
            //Thread.Sleep(2000);
            Thread th2 = new Thread(DrawandMove);
            th2.Start();
           // MessageBox.Show("2");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Left)
            {
                hero.locationX = hero.locationX - (hero.speed * 10);

            }
            if (keyData == Keys.Right)
                hero.locationX = hero.locationX + (hero.speed * 10);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

}
