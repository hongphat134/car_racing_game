using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
    public partial class CarRacingForm : Form
    {
        public CarRacingForm()
        {
            InitializeComponent();
            pictureBox5.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            timerLine.Start();
        }

        Random pos = new Random();
        int game_speed = 5;

        private void enemy(int speed)
        {
            if (ptrEnemyCar1.Top > 600)
            {
                int add_score = Convert.ToInt32(lblScore.Text) + 1;
                lblScore.Text = Convert.ToString(add_score);
                ptrEnemyCar1.Top = 0;
                ptrEnemyCar1.Left = pos.Next(205, 775);
            }
            else ptrEnemyCar1.Top += speed;

            if (ptrEnemyCar2.Top > 600)
            {
                ptrEnemyCar2.Top = 0;
                ptrEnemyCar2.Left = pos.Next(205, 775);
            }
            else ptrEnemyCar2.Top += speed;
           

            if (ptrEnemyCar4.Top > 600)
            {
                ptrEnemyCar4.Top = 0;
                ptrEnemyCar4.Left = pos.Next(205, 775);
            }
            else ptrEnemyCar4.Top += speed;
        }
        private void lineMove(int speed)
        {
            if (ptrLine1.Top > 600) ptrLine1.Top = 0;
            else ptrLine1.Top += speed;

            if (ptrLine2.Top > 600) ptrLine2.Top = 0;
            else ptrLine2.Top += speed;

            if (ptrLine3.Top > 600) ptrLine3.Top = 0;
            else ptrLine3.Top += speed;  
        }

        private void coin(int speed)
        {
            if (ptrCoin1.Top > 600)
            {
                ptrCoin1.Top = 0;
                ptrCoin1.Left = pos.Next(205, 775);
            }
            else ptrCoin1.Top += speed;

            if (ptrCoin2.Top > 600)
            {
                ptrCoin2.Top = 0;
                ptrCoin2.Left = pos.Next(205, 775);
            }
            else ptrCoin2.Top += speed;            
        }

        private void collectedCoins()
        {
            int add_coin = Convert.ToInt32(lblCoin.Text) + 1;
            if (ptrMyCar.Bounds.IntersectsWith(ptrCoin1.Bounds))
            {               
                lblCoin.Text = Convert.ToString(add_coin);
                ptrCoin1.Top = 0;
                ptrCoin1.Left = pos.Next(205, 775);
                
            }
            else if (ptrMyCar.Bounds.IntersectsWith(ptrCoin2.Bounds))
            {
                lblCoin.Text = Convert.ToString(add_coin);
                ptrCoin2.Top = 0;
                ptrCoin2.Left = pos.Next(205, 775);
            }
        }

        private void timerLine_Tick(object sender, EventArgs e)
        {
            lineMove(game_speed);
            enemy(game_speed);
            coin(game_speed);
            gameOver();
            collectedCoins();
        }

        private void gameOver()
        {
            if (ptrMyCar.Bounds.IntersectsWith(ptrEnemyCar1.Bounds)
                || ptrMyCar.Bounds.IntersectsWith(ptrEnemyCar2.Bounds)
                || ptrMyCar.Bounds.IntersectsWith(ptrEnemyCar4.Bounds))
            {
                timerLine.Stop();
                DialogResult alert = MessageBox.Show("Do you want to play again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (alert == System.Windows.Forms.DialogResult.Yes)
                {
                    lblScore.Text = "0";
                    lblCoin.Text = "0";
                    ptrEnemyCar1.Top = 50;
                    ptrEnemyCar1.Left = 750;
                    ptrEnemyCar2.Top = 200;
                    ptrEnemyCar2.Left = 610;
                    ptrEnemyCar4.Top = 350;
                    ptrEnemyCar4.Left = 250;
                    ptrMyCar.Left = 530;
                    game_speed = 5;
                    timerLine.Start();
                }
                else this.Close();
            }
        }
        private void CarRacingForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) ptrMyCar.Left += -40;
            else if (e.KeyCode == Keys.Right) ptrMyCar.Left += 40;
            else if (e.KeyCode == Keys.Up)
            {
                if (game_speed < 30) game_speed += 5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (game_speed > 5) game_speed -= 5;
            }
        }
    }
}
