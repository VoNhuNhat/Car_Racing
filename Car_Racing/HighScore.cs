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
    public partial class HighScore : Form
    {
        DB_Car_RacingDataContext db;

        public HighScore()
        {
            InitializeComponent();
            db = new DB_Car_RacingDataContext();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            ShowHighScore();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void ShowHighScore()
        {
            dgvHighScore.DataSource = db.GetPlayers();
        }
    }
}
