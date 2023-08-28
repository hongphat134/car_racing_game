
namespace Car_Racing
{
    partial class CarRacingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacingForm));
            this.timerLine = new System.Windows.Forms.Timer(this.components);
            this.ptrLine1 = new System.Windows.Forms.PictureBox();
            this.ptrLine2 = new System.Windows.Forms.PictureBox();
            this.ptrLine3 = new System.Windows.Forms.PictureBox();
            this.ptrMyCar = new System.Windows.Forms.PictureBox();
            this.ptrEnemyCar4 = new System.Windows.Forms.PictureBox();
            this.ptrEnemyCar2 = new System.Windows.Forms.PictureBox();
            this.ptrEnemyCar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ptrCoin1 = new System.Windows.Forms.PictureBox();
            this.ptrCoin2 = new System.Windows.Forms.PictureBox();
            this.lblCoin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLine
            // 
            this.timerLine.Interval = 25;
            this.timerLine.Tick += new System.EventHandler(this.timerLine_Tick);
            // 
            // ptrLine1
            // 
            this.ptrLine1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptrLine1.Location = new System.Drawing.Point(521, 1);
            this.ptrLine1.Name = "ptrLine1";
            this.ptrLine1.Size = new System.Drawing.Size(10, 180);
            this.ptrLine1.TabIndex = 6;
            this.ptrLine1.TabStop = false;
            // 
            // ptrLine2
            // 
            this.ptrLine2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptrLine2.Location = new System.Drawing.Point(521, 223);
            this.ptrLine2.Name = "ptrLine2";
            this.ptrLine2.Size = new System.Drawing.Size(10, 180);
            this.ptrLine2.TabIndex = 7;
            this.ptrLine2.TabStop = false;
            // 
            // ptrLine3
            // 
            this.ptrLine3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptrLine3.Location = new System.Drawing.Point(521, 430);
            this.ptrLine3.Name = "ptrLine3";
            this.ptrLine3.Size = new System.Drawing.Size(10, 180);
            this.ptrLine3.TabIndex = 8;
            this.ptrLine3.TabStop = false;
            // 
            // ptrMyCar
            // 
            this.ptrMyCar.Image = ((System.Drawing.Image)(resources.GetObject("ptrMyCar.Image")));
            this.ptrMyCar.Location = new System.Drawing.Point(510, 520);
            this.ptrMyCar.Name = "ptrMyCar";
            this.ptrMyCar.Size = new System.Drawing.Size(40, 90);
            this.ptrMyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrMyCar.TabIndex = 9;
            this.ptrMyCar.TabStop = false;
            // 
            // ptrEnemyCar4
            // 
            this.ptrEnemyCar4.Image = ((System.Drawing.Image)(resources.GetObject("ptrEnemyCar4.Image")));
            this.ptrEnemyCar4.Location = new System.Drawing.Point(750, 50);
            this.ptrEnemyCar4.Name = "ptrEnemyCar4";
            this.ptrEnemyCar4.Size = new System.Drawing.Size(40, 90);
            this.ptrEnemyCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrEnemyCar4.TabIndex = 10;
            this.ptrEnemyCar4.TabStop = false;
            // 
            // ptrEnemyCar2
            // 
            this.ptrEnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("ptrEnemyCar2.Image")));
            this.ptrEnemyCar2.Location = new System.Drawing.Point(250, 350);
            this.ptrEnemyCar2.Name = "ptrEnemyCar2";
            this.ptrEnemyCar2.Size = new System.Drawing.Size(40, 90);
            this.ptrEnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrEnemyCar2.TabIndex = 12;
            this.ptrEnemyCar2.TabStop = false;
            // 
            // ptrEnemyCar1
            // 
            this.ptrEnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("ptrEnemyCar1.Image")));
            this.ptrEnemyCar1.Location = new System.Drawing.Point(610, 200);
            this.ptrEnemyCar1.Name = "ptrEnemyCar1";
            this.ptrEnemyCar1.Size = new System.Drawing.Size(40, 90);
            this.ptrEnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrEnemyCar1.TabIndex = 13;
            this.ptrEnemyCar1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(186, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 662);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(630, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "YOUR SCORE: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(761, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 21);
            this.lblScore.TabIndex = 17;
            this.lblScore.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 663);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(843, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(190, 661);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // ptrCoin1
            // 
            this.ptrCoin1.Image = ((System.Drawing.Image)(resources.GetObject("ptrCoin1.Image")));
            this.ptrCoin1.Location = new System.Drawing.Point(403, 174);
            this.ptrCoin1.Name = "ptrCoin1";
            this.ptrCoin1.Size = new System.Drawing.Size(40, 40);
            this.ptrCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrCoin1.TabIndex = 20;
            this.ptrCoin1.TabStop = false;
            // 
            // ptrCoin2
            // 
            this.ptrCoin2.Image = ((System.Drawing.Image)(resources.GetObject("ptrCoin2.Image")));
            this.ptrCoin2.Location = new System.Drawing.Point(538, 302);
            this.ptrCoin2.Name = "ptrCoin2";
            this.ptrCoin2.Size = new System.Drawing.Size(40, 40);
            this.ptrCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrCoin2.TabIndex = 21;
            this.ptrCoin2.TabStop = false;
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCoin.ForeColor = System.Drawing.Color.Gold;
            this.lblCoin.Location = new System.Drawing.Point(342, 9);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(19, 21);
            this.lblCoin.TabIndex = 23;
            this.lblCoin.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "YOUR COIN: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(833, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 662);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(682, 328);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // CarRacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptrCoin2);
            this.Controls.Add(this.ptrCoin1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptrEnemyCar1);
            this.Controls.Add(this.ptrEnemyCar2);
            this.Controls.Add(this.ptrEnemyCar4);
            this.Controls.Add(this.ptrMyCar);
            this.Controls.Add(this.ptrLine3);
            this.Controls.Add(this.ptrLine2);
            this.Controls.Add(this.ptrLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarRacingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CarRacingForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrEnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerLine;
        private System.Windows.Forms.PictureBox ptrLine1;
        private System.Windows.Forms.PictureBox ptrLine2;
        private System.Windows.Forms.PictureBox ptrLine3;
        private System.Windows.Forms.PictureBox ptrMyCar;
        private System.Windows.Forms.PictureBox ptrEnemyCar4;
        private System.Windows.Forms.PictureBox ptrEnemyCar2;
        private System.Windows.Forms.PictureBox ptrEnemyCar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox ptrCoin1;
        private System.Windows.Forms.PictureBox ptrCoin2;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

