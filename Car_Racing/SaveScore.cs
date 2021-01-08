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
    public partial class SaveScore : Form
    {
        DB_Car_RacingDataContext db;

        private int _score;

        public SaveScore()
        {
            InitializeComponent();
            db = new DB_Car_RacingDataContext();
        }

        public SaveScore(int Score) : this()
        {
            _score = Score;
            label1.Text = "Điểm cao: " + _score + ". Nhập tên để lưu";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên của bạn");
            }
            else
            {
                if (textBox1.Text.Length > 50)
                {
                    MessageBox.Show("Tên không được quá 50 ký tự");
                }
                else
                {
                    string _name = textBox1.Text;
                    db.SaveHighScore(_name, _score);
                    HighScore highScore = new HighScore();
                    highScore.Show();
                    this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
