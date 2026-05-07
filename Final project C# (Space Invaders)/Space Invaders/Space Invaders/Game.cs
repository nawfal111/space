using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;

namespace Space_Invaders
{
    public partial class Game : Form
    {
        PictureBox[] pics = new PictureBox[31];
        const int step = 10;
        const int up = 20;
        bool clicked = false;
        SoundPlayer shoot = new SoundPlayer("Shoot.wav");
        SoundPlayer hit = new SoundPlayer("Hit.wav");
        Random rand = new Random();
        int enemyDir = 1;
        int lives = 3;
        Label lblLives;

        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            pics[0] = pb1;
            pics[1] = pb2;
            pics[2] = pb3;
            pics[3] = pb4;
            pics[4] = pb5;
            pics[5] = pb6;
            pics[6] = pb7;
            pics[7] = pb8;
            pics[8] = pb9;
            pics[9] = pb10;
            pics[10] = pb11;
            pics[11] = pb12;
            pics[12] = pb13;
            pics[13] = pb14;
            pics[14] = pb15;
            pics[15] = pb16;
            pics[16] = pb17;
            pics[17] = pb18;
            pics[18] = pb19;
            pics[19] = pb20;
            pics[20] = pb21;
            pics[21] = pb22;
            pics[22] = pb23;
            pics[23] = pb24;
            pics[24] = pb25;
            pics[25] = pb26;
            pics[26] = pb27;
            pics[27] = pb28;
            pics[28] = pb29;
            pics[29] = pb30;
            pics[30] = pb31;

            pbBullet.Visible = false;
            pbBulletEnemy.Visible = false;
            lblScore.Text = "0";

            lblLives = new Label();
            lblLives.ForeColor = Color.White;
            lblLives.Font = new Font("Consolas", 10f);
            lblLives.AutoSize = true;
            lblLives.Location = new Point(580, 19);
            lblLives.Text = "Lives: 3";
            Controls.Add(lblLives);

            Text = "Space Invaders - " + GameSettings.Nickname;

            // Apply saved volume (sets the Windows wave output device volume)
            int vol = GameSettings.Volume;
            uint volVal = (uint)((65535 * vol / 100) | ((65535 * vol / 100) << 16));
            waveOutSetVolume(IntPtr.Zero, volVal);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            int minX = int.MaxValue, maxX = int.MinValue;
            bool anyVisible = false;

            for (int i = 0; i < pics.Length; i++)
            {
                if (pics[i].Visible)
                {
                    anyVisible = true;
                    if (pics[i].Location.X < minX) minX = pics[i].Location.X;
                    if (pics[i].Location.X + pics[i].Width > maxX) maxX = pics[i].Location.X + pics[i].Width;
                }
            }

            if (!anyVisible) return;

            bool reverse = (enemyDir == 1 && maxX + step >= ClientSize.Width - 10)
                        || (enemyDir == -1 && minX - step <= 10);

            if (reverse)
            {
                enemyDir = -enemyDir;
                for (int i = 0; i < pics.Length; i++)
                {
                    if (pics[i].Visible)
                        pics[i].Location = new Point(pics[i].Location.X, pics[i].Location.Y + 20);
                }

                // Game over if enemies reach the player
                for (int i = 0; i < pics.Length; i++)
                {
                    if (pics[i].Visible && pics[i].Location.Y + pics[i].Height >= pbShooter.Location.Y)
                    {
                        GameOver();
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < pics.Length; i++)
                {
                    if (pics[i].Visible)
                        pics[i].Location = new Point(pics[i].Location.X + enemyDir * step, pics[i].Location.Y);
                }
            }
        }

        private void timerBullet_Tick(object sender, EventArgs e)
        {
            // Move player bullet
            if (clicked)
            {
                pbBullet.Location = new Point(pbBullet.Location.X, pbBullet.Location.Y - up);

                for (int i = 0; i < pics.Length; i++)
                {
                    if (pics[i].Visible && pbBullet.Bounds.IntersectsWith(pics[i].Bounds))
                    {
                        pics[i].Visible = false;
                        pbBullet.Visible = false;
                        clicked = false;
                        hit.Play();

                        int score = int.Parse(lblScore.Text);
                        if (i >= 14 && i <= 22)
                            score += 10;
                        else if (i >= 23 && i <= 30)
                            score += 15;
                        else
                            score += 5;
                        lblScore.Text = score.ToString();

                        if (pics.All(p => !p.Visible))
                        {
                            YouWin();
                            return;
                        }
                        break;
                    }
                }

                if (pbBullet.Location.Y < 0)
                {
                    pbBullet.Visible = false;
                    clicked = false;
                }
            }

            // Move enemy bullet
            if (pbBulletEnemy.Visible)
            {
                pbBulletEnemy.Location = new Point(pbBulletEnemy.Location.X, pbBulletEnemy.Location.Y + 10);

                if (pbBulletEnemy.Bounds.IntersectsWith(pbShooter.Bounds))
                {
                    pbBulletEnemy.Visible = false;
                    lives--;
                    lblLives.Text = "Lives: " + lives;
                    hit.Play();
                    if (lives <= 0)
                    {
                        GameOver();
                        return;
                    }
                }
                else if (pbBulletEnemy.Location.Y > ClientSize.Height)
                {
                    pbBulletEnemy.Visible = false;
                }
            }
        }

        private void Shoot(object sender, MouseEventArgs e)
        {
            if (!clicked)
            {
                pbBullet.Location = new Point(
                    pbShooter.Left + pbShooter.Width / 2 - pbBullet.Width / 2,
                    pbShooter.Top - pbBullet.Height);
                pbBullet.Visible = true;
                clicked = true;
                shoot.Play();
            }
        }

        private void pbBullet_Click(object sender, EventArgs e)
        {
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
                pbShooter.Left = Math.Max(0, pbShooter.Left - 15);

            if (keyData == Keys.Right)
                pbShooter.Left = Math.Min(ClientSize.Width - pbShooter.Width, pbShooter.Left + 15);

            if (keyData == Keys.Space && !clicked)
            {
                pbBullet.Location = new Point(
                    pbShooter.Left + pbShooter.Width / 2 - pbBullet.Width / 2,
                    pbShooter.Top - pbBullet.Height);
                pbBullet.Visible = true;
                clicked = true;
                shoot.Play();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Enemytimer_Tick(object sender, EventArgs e)
        {
            if (pbBulletEnemy.Visible) return;

            var visible = Enumerable.Range(0, pics.Length)
                                    .Where(i => pics[i].Visible)
                                    .ToList();
            if (visible.Count == 0) return;

            int idx = visible[rand.Next(visible.Count)];
            pbBulletEnemy.Location = new Point(
                pics[idx].Location.X + pics[idx].Width / 2 - pbBulletEnemy.Width / 2,
                pics[idx].Location.Y + pics[idx].Height);
            pbBulletEnemy.Visible = true;
        }

        private void pbBulletEnemy_Click(object sender, EventArgs e)
        {
        }

        private void GameOver()
        {
            timerGame.Stop();
            timerBullet.Stop();
            Enemytimer.Stop();
            MessageBox.Show("Game Over!\nScore: " + lblScore.Text, "Game Over");
            Close();
        }

        private void YouWin()
        {
            timerGame.Stop();
            timerBullet.Stop();
            Enemytimer.Stop();
            MessageBox.Show("You Win!\nScore: " + lblScore.Text, "Congratulations!");
            Close();
        }
    }
}
