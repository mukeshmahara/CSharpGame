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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form2()
        {
            InitializeComponent();
            player.SoundLocation = "D:/My Works/VisualStudio work/Games/Road Fighter 1/Level_Up.wav";
            player.Play();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
                
        }
    }
}
