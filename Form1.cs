using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_Game
{
    public partial class GameForm : Form
    {
        public int Sppeed_Left = 4;
        public int Sppeed_Top = 4;
        public int Points = 0;
        public GameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            Ptb_Racket.Top = Pnl_PlayGround.Bottom - (Pnl_PlayGround.Bottom / 10);
            Gameover_Lbl.Left = (Pnl_PlayGround.Width / 2) - (Gameover_Lbl.Width / 2);
            Gameover_Lbl.Top = (Pnl_PlayGround.Height / 2) - (Gameover_Lbl.Height / 2);
            Gameover_Lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ptb_Racket.Left = Cursor.Position.X - (Ptb_Racket.Width / 2);
            ball_ptb.Left += Sppeed_Left;
            ball_ptb.Top += Sppeed_Top;



            if (ball_ptb.Left<=Pnl_PlayGround.Left)
            {
                Sppeed_Left = -Sppeed_Left;
            }
            if (ball_ptb.Right >= Pnl_PlayGround.Right)
            {
                Sppeed_Left = -Sppeed_Left;
            }
            if (ball_ptb.Top <= Pnl_PlayGround.Top)
            {
                Sppeed_Top = -Sppeed_Top;  
            }
            if (ball_ptb.Bottom >= Pnl_PlayGround.Bottom)
            {
                Gameover_Lbl.Visible = true;
                timer1.Enabled = false;
            }
            if (ball_ptb.Bottom >= Ptb_Racket.Top && ball_ptb.Bottom <= Ptb_Racket.Bottom && ball_ptb.Left >= Ptb_Racket.Left && ball_ptb.Right <= Ptb_Racket.Right)
            {
                Sppeed_Top += 2;
                Sppeed_Left += 2;
                Sppeed_Top = -Sppeed_Top;
                Points += 1;
                points_Lbl.Text = Points.ToString();


                Random r = new Random();
                Pnl_PlayGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));

            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.F1)
            {
                ball_ptb.Top = 50;
                ball_ptb.Left = 50;
                Sppeed_Left = 50;
                points_Lbl.Text = "0";
                timer1.Enabled = true;
                Gameover_Lbl.Visible = false;
                Pnl_PlayGround.BackColor = Color.White;
            }
        }
    }
}
