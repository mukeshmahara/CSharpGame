namespace Road_Fighter_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.Over = new System.Windows.Forms.Label();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(180, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(180, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 89);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(180, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 89);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(0, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 459);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(373, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 459);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Gainsboro;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(100, 348);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(34, 54);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 5;
            this.Car.TabStop = false;
           // this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(50, 12);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(41, 69);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            
            // 
            // enemy4
            // 
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(280, 94);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(39, 67);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 8;
            this.enemy4.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(143, 202);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(40, 69);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 9;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(240, 318);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(34, 68);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 10;
            this.enemy3.TabStop = false;
            // 
            // Over
            // 
            this.Over.AutoSize = true;
            this.Over.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Over.ForeColor = System.Drawing.Color.Crimson;
            this.Over.Location = new System.Drawing.Point(98, 166);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(176, 33);
            this.Over.TabIndex = 11;
            this.Over.Text = "Game Over";
            this.Over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(294, 202);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coins = 0";
            // 
            // coin4
            // 
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(104, 307);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 15;
            this.coin4.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(120, 94);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 16;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(215, 28);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 17;
            this.coin1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.Over);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Name = "Form1";
            this.Text = "Road Fighter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label Over;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
    }
}

