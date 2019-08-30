namespace Picture_Puzzel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OriginalPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.gbPuzzelBox = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPuzzelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalPicture
            // 
            this.OriginalPicture.Image = ((System.Drawing.Image)(resources.GetObject("OriginalPicture.Image")));
            this.OriginalPicture.Location = new System.Drawing.Point(485, 24);
            this.OriginalPicture.Name = "OriginalPicture";
            this.OriginalPicture.Size = new System.Drawing.Size(247, 220);
            this.OriginalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalPicture.TabIndex = 9;
            this.OriginalPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Shuffle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.Location = new System.Drawing.Point(75, 357);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(162, 29);
            this.lblMovesMade.TabIndex = 13;
            this.lblMovesMade.Text = "Move Made :";
            this.lblMovesMade.Click += new System.EventHandler(this.Label1_Click);
            // 
            // gbPuzzelBox
            // 
            this.gbPuzzelBox.Location = new System.Drawing.Point(80, 12);
            this.gbPuzzelBox.Name = "gbPuzzelBox";
            this.gbPuzzelBox.Size = new System.Drawing.Size(335, 301);
            this.gbPuzzelBox.TabIndex = 14;
            this.gbPuzzelBox.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(90, 24);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 89);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 15;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(196, 24);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 89);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 16;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(302, 24);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 89);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 17;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(90, 119);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 89);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 18;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(196, 119);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(100, 89);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 19;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(302, 119);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(100, 89);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 20;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(90, 214);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(100, 89);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 21;
            this.pbx7.TabStop = false;
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(196, 214);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(100, 89);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 22;
            this.pbx8.TabStop = false;
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(302, 214);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(100, 89);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 23;
            this.pbx9.TabStop = false;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(493, 258);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(220, 55);
            this.lblTimeElapsed.TabIndex = 24;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.pbx9);
            this.Controls.Add(this.pbx8);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.gbPuzzelBox);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OriginalPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPuzzelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox OriginalPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.PictureBox gbPuzzelBox;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lblTimeElapsed;
    }
}

