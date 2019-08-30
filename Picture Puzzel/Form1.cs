using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Puzzel
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2,
                Properties.Resources._3, Properties.Resources._4, Properties.Resources._5,
                Properties.Resources._6, Properties.Resources._7, Properties.Resources._8,
                Properties.Resources._9, Properties.Resources._null });
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shuffle();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        void shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzelBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j==9)
                    {
                        inNullSliceIndex = i; //Store Empty Box index
                    }
                }
            }
            while (CheckWin());
        }


       private void SwitchPictureBox(object sender ,EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
            {
                timer.Start();
            }
            int inPictureBoxIndex = gbPuzzelBox.Controls.IndexOf( sender as Control);
            if (inNullSliceIndex!=inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int> ( new int[]{inPictureBoxIndex - 1, inPictureBoxIndex - 3, inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzelBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzelBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzelBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Moves Made : " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzelBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulation....\nYou have completed the mission \nTime Elapsed :" + timer.Elapsed.ToString().Remove(8) + "\nTotal Move Made :" + inmoves, "Picture Puzzle");
                        inmoves = 0;
                        lblMovesMade.Text = "Move Made :0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        shuffle();
                    }
                }
            }
        }

        bool CheckWin()
        {
            int i;
            for ( i = 0; i < 8; i++)
            {
                if ((gbPuzzelBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) 
                {
                    break;
                }
            }
            if ( i == 8)
                return true;
            else
                return false;
        }
    }
}
