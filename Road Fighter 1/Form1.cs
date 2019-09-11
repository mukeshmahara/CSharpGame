using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Road_Fighter_1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Vehicle_Speeding.wav";
            player.Play();
            Over.Visible = false;
        }


   

        

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
;
            moveline(gameSpeed );
            enemy(gameSpeed);
            GameOver();
            Coins(gameSpeed);
            CoinCollection();
        }

        int collectedCoins = 0;

        void CoinCollection()
        {
            if (Car.Bounds.IntersectsWith(coin1.Bounds))
            {
                
                collectedCoins++;
                label1.Text = "Coins =" + collectedCoins.ToString();
                x = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin2.Bounds))
            {
                
                collectedCoins++;
                label1.Text = "Coins =" + collectedCoins.ToString();
                x = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin3.Bounds))
            {
               
                collectedCoins++;
                label1.Text = "Coins =" + collectedCoins.ToString();
                x = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }

            if (Car.Bounds.IntersectsWith(coin4.Bounds))
            {
                
                collectedCoins++;
                label1.Text = "Coins =" + collectedCoins.ToString();
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);

            }
        }
        Random r = new Random();
        int x;
        void enemy(
            int speed)
        {
            //enemy 1
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            //enemy2
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            //enemy 3
            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
            //enemy 4
            if (enemy4.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy4.Location = new Point(x, 0);
            }
            else
            {
                enemy4.Top += speed;
            }

        }
        void Coins(int speed)
        {
            //enemy 1
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            //enemy2
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            //enemy 3
            if (coin3.Top >= 500)
            {
                x = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            //enemy 4
            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }

        }

        void GameOver()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Crash.wav";
                player.Play();
                MessageBox.Show("You Crashed");

                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2.Close();

            }
            if (Car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Crash.wav";
                player.Play();
                MessageBox.Show("You Crashed");

                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2.Close();

            }
            if (Car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Crash.wav";
                player.Play();
                MessageBox.Show("You Crashed");

                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2.Close();

                

            }
            if (Car.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
                player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Crash.wav";
                player.Play();

                MessageBox.Show("You Crashed");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2.Close();


            }
        }
        void moveline(int speed)
        {
            
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
           
        }

        int gameSpeed = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                if (Car.Left > 15)
                {

                    Car.Left += -25;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Car.Right < 370)
                {
                    Car.Left += 25;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }

        

       
    }
}
