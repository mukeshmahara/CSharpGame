using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzelGame
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Form1()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1,Properties.Resources._2,Properties.Resources._3,
                Properties.Resources._4,Properties.Resources._5,Properties.Resources._6,Properties.Resources._7,Properties.Resources._8,Properties.Resources._9,Properties.Resources._null,
            });
            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;


                }
            } while (CheckWin());
        }
        private void AskPermissionBeforeQuit(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNo = MessageBox.Show("Are you Sure to Quit?", "Picture Puzzel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sender as Button != btnQuit && YesOrNo == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNo == DialogResult.Yes) Environment.Exit(0);
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuit(sender, e as FormClosingEventArgs);
        }

        private void SwitchPictureBox(Object sender, EventArgs e)
        {
            
            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { inPictureBoxIndex - 1, inPictureBoxIndex - 3, inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Moves Made :" + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulation...\n Puzzle Solved('_')\nTime Elapsed :" + timer.Elapsed.ToString().Remove(8) +
                            "\nTotal Moves Made :" + inmoves, "Picture Puzzel");
                        inmoves = 0;
                        lblMovesMade.Text = "Moves Made : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are you Sure to RESTART ? ", "Picture Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            if (YesOrNo == DialogResult.Yes||lblTimeElapsed.Text=="00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Moves Made : 0";
            }
        }

        

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString()=="1")
            {
                timer.Reset();
                lblMovesMade.Text = "Moves Made : 0";
                lblTimeElapsed.Text = "00:00:00";

                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("time is up\nTry Again", "Picture Puzzzel");
                Shuffle();



            }
            
        }
        private void PauseOrResume(object sender , EventArgs e)
        {
            
            if (btnPause.Text =="Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";

            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }

       

        private void BtnPause_Click(object sender, EventArgs e)
        {
            
            PauseOrResume(sender, e);
        }

        private void Pbx5_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender,e);
        }

        private void Pbx8_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);

        }

        private void Pbx7_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        private void Pbx6_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        private void Pbx9_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);

        }

        private void Pbx4_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        private void Pbx3_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        private void Pbx2_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        private void Pbx1_Click(object sender, EventArgs e)
        {
            SwitchPictureBox(sender, e);
        }

        

        bool CheckWin()
        {
            int i;
            for ( i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image !=lstOriginalPictureList[i]) break;
                
            }
            if (i == 8) return true;
            else return false;

        }
    } 
}
