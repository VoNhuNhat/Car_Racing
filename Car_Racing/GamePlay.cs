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
    public partial class GamePlay : Form
    {
        DB_Car_RacingDataContext db;

        public GamePlay()
        {
            InitializeComponent();
            db = new DB_Car_RacingDataContext();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LineMove(CarSpeed);
            GameOver();
            TotalScore();
        }

        Random position = new Random();

        void LineMove(int speed)
        {
            if (pictureBox1.Top > 400)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top > 400)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top > 400)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (enemy1.Top > 400)
            {
                Score++;
                enemy1.Left = position.Next(15, 225);
                enemy1.Top = 0;
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top > 400)
            {
                Score++;
                enemy2.Left = position.Next(15, 225);
                enemy2.Top = 0;
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top > 400)
            {
                Score++;
                enemy3.Left = position.Next(225, 400);
                enemy3.Top = 0;
            }
            else
            {
                enemy3.Top += speed;
            }

            if (enemy4.Top > 400)
            {
                Score++;
                enemy4.Left = position.Next(225, 400);
                enemy4.Top = 0;
            }
            else
            {
                enemy4.Top += speed;
            }
        }

        int CarSpeed = 5;

        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && CarSpeed < 15)
            {
                CarSpeed++;
            }

            if (e.KeyCode == Keys.Down && CarSpeed > 5)
            {
                CarSpeed--;
            }

            if (e.KeyCode == Keys.Left && myCar.Left > 15)
            {
                myCar.Left -= (CarSpeed + 5);
            }

            if (e.KeyCode == Keys.Right && myCar.Left < 395)
            {
                myCar.Left += (CarSpeed + 5);
            }
        }

        int Score;

        void TotalScore()
        {
            textBox1.Text = Score.ToString();
        }

        void GameOver()
        {
            if (myCar.Bounds.IntersectsWith(enemy1.Bounds) || myCar.Bounds.IntersectsWith(enemy2.Bounds) || myCar.Bounds.IntersectsWith(enemy3.Bounds) || myCar.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult msg = MessageBox.Show("Bạn có muốn chơi lại không?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch (msg)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        enemy1.Left = 68;
                        enemy1.Top = 29;
                        enemy2.Left = 127;
                        enemy2.Top = 160;
                        enemy3.Left = 263;
                        enemy3.Top = 89;
                        enemy4.Left = 350;
                        enemy4.Top = 219;
                        myCar.Left = 193;
                        CarSpeed = 5;
                        Score = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        if (db.GetLowestScore(Score).ToList().Count() == 0)
                        {
                            SaveScore saveScore = new SaveScore(Score);
                            saveScore.Show();
                            this.Hide();
                        }
                        else
                        {
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                        break;
                }
            }
        }
    }
}
