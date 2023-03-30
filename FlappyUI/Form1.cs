using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyUI
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pboxKafa.Top += gravity;
            pboxAsagi.Left -= pipeSpeed;
            pboxYukari.Left -= pipeSpeed;
            txtScore.Text = "Skor: " + score;

            if (pboxAsagi.Left < -150)
            {
                pboxAsagi.Left = 800;
                score++;
            }
            if (pboxYukari.Left < -150)
            {
                pboxYukari.Left = 950;
                score++;
            }

            if (pboxKafa.Bounds.IntersectsWith(pboxAsagi.Bounds) ||
                (pboxKafa.Bounds.IntersectsWith(pboxYukari.Bounds) ||
                (pboxKafa.Bounds.IntersectsWith(pboxAlt.Bounds) ||
                (pboxKafa.Top < -25))))

            {
                Endgame();
            }

        }
        public void Endgame()
        { 
        timerControl.Stop();
            txtScore.Text = "Oyun Bitti";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }

        
    }
}
