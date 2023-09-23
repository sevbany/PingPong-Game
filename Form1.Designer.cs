namespace PingPong_Game
{
    partial class GameForm
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
            this.Pnl_PlayGround = new System.Windows.Forms.Panel();
            this.Ptb_Racket = new System.Windows.Forms.PictureBox();
            this.ball_ptb = new System.Windows.Forms.PictureBox();
            this.score_Lbl = new System.Windows.Forms.Label();
            this.points_Lbl = new System.Windows.Forms.Label();
            this.Gameover_Lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_PlayGround
            // 
            this.Pnl_PlayGround.Controls.Add(this.Gameover_Lbl);
            this.Pnl_PlayGround.Controls.Add(this.points_Lbl);
            this.Pnl_PlayGround.Controls.Add(this.score_Lbl);
            this.Pnl_PlayGround.Controls.Add(this.ball_ptb);
            this.Pnl_PlayGround.Controls.Add(this.Ptb_Racket);
            this.Pnl_PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_PlayGround.Location = new System.Drawing.Point(0, 0);
            this.Pnl_PlayGround.Name = "Pnl_PlayGround";
            this.Pnl_PlayGround.Size = new System.Drawing.Size(800, 450);
            this.Pnl_PlayGround.TabIndex = 0;
            // 
            // Ptb_Racket
            // 
            this.Ptb_Racket.BackColor = System.Drawing.Color.Black;
            this.Ptb_Racket.Location = new System.Drawing.Point(271, 345);
            this.Ptb_Racket.Name = "Ptb_Racket";
            this.Ptb_Racket.Size = new System.Drawing.Size(200, 20);
            this.Ptb_Racket.TabIndex = 0;
            this.Ptb_Racket.TabStop = false;
            // 
            // ball_ptb
            // 
            this.ball_ptb.BackColor = System.Drawing.Color.Red;
            this.ball_ptb.Location = new System.Drawing.Point(337, 265);
            this.ball_ptb.Name = "ball_ptb";
            this.ball_ptb.Size = new System.Drawing.Size(30, 30);
            this.ball_ptb.TabIndex = 1;
            this.ball_ptb.TabStop = false;
            // 
            // score_Lbl
            // 
            this.score_Lbl.AutoSize = true;
            this.score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_Lbl.Location = new System.Drawing.Point(13, 13);
            this.score_Lbl.Name = "score_Lbl";
            this.score_Lbl.Size = new System.Drawing.Size(107, 31);
            this.score_Lbl.TabIndex = 3;
            this.score_Lbl.Text = " Score :";
            // 
            // points_Lbl
            // 
            this.points_Lbl.AutoSize = true;
            this.points_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_Lbl.Location = new System.Drawing.Point(113, 13);
            this.points_Lbl.Name = "points_Lbl";
            this.points_Lbl.Size = new System.Drawing.Size(43, 31);
            this.points_Lbl.TabIndex = 4;
            this.points_Lbl.Text = " 0 ";
            this.points_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gameover_Lbl
            // 
            this.Gameover_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gameover_Lbl.Location = new System.Drawing.Point(288, 102);
            this.Gameover_Lbl.Name = "Gameover_Lbl";
            this.Gameover_Lbl.Size = new System.Drawing.Size(134, 136);
            this.Gameover_Lbl.TabIndex = 5;
            this.Gameover_Lbl.Text = "Game Over!\r\n\r\nF1 - Restart Game\r\n \r\nEsc - Exit\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_PlayGround);
            this.Name = "GameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.Pnl_PlayGround.ResumeLayout(false);
            this.Pnl_PlayGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_PlayGround;
        private System.Windows.Forms.PictureBox ball_ptb;
        private System.Windows.Forms.PictureBox Ptb_Racket;
        private System.Windows.Forms.Label Gameover_Lbl;
        private System.Windows.Forms.Label points_Lbl;
        private System.Windows.Forms.Label score_Lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

