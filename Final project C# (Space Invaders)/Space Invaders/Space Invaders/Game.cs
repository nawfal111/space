using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Space_Invaders
{
    public partial class Game : Form
    {
        PictureBox[] pics = new PictureBox[31];
        const int step = 10;
        bool clicked = false;
        const int up = 20;
        SoundPlayer shoot = new SoundPlayer("Shoot.wav");
        SoundPlayer hit = new SoundPlayer("Hit.wav");
        const int width = 32;
        public int vol = 50;
        Random rand = new Random();
        int r;
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




        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            int x;

            for (int i = 0; i < pics.Length; i++)
            {
                if (pics[i].Location.X > 0 && pics[i].Location.X <= 630)
                {
                    x = pics[i].Location.X;
                    pics[i].Location = new Point(x + step, pics[i].Location.Y);
                }
                else
                {
                    pics[i].Location = new Point(200, pics[i].Location.Y);
                    x = pics[i].Location.X;
                    pics[i].Location = new Point(x + step, pics[i].Location.Y);
                }
            }
        }

        private void timerBullet_Tick(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                pbBullet.Location = new Point(pbBullet.Location.X, pbBullet.Location.Y - up);

                for (int i = 0; i < pics.Length; i++)
                {
                    
                        if(pics[i].Visible && pbBullet.Bounds.IntersectsWith(pics[i].Bounds))
                    {
                        pics[i].Visible = false;

                        pbBullet.Visible = false;
                        clicked = false;

                        hit.Play();




                        int score = int.Parse(lblScore.Text);

                        if (i >= 14 && i <= 22)
                        {
                            score += 10;
                        }
                        else if (i >= 23 && i <= 30)
                        {
                            score += 15;
                        }
                        else if (i >= 0 && i <= 13)
                        {
                            score += 5;
                        }

                        lblScore.Text = score.ToString();

                        break;
                    }
                }
            }

            if (pbBullet.Location.Y < 0)
            {
                pbBullet.Visible = false;
                clicked = false;



            }
        }

        private void Shoot(object sender, MouseEventArgs e)
        {
            if (clicked == false)
            {
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
            {
                pbShooter.Left -= 15;
            }


            if (keyData == Keys.Right)
            {
                pbShooter.Left += 15;
            }


            if (keyData == Keys.Space)
            {
                if (clicked == false)
                {
                    pbBullet.Visible = true;

                    pbBullet.Location = new Point( pbShooter.Left,   pbShooter.Top );

                    clicked = true;

                    shoot.Play();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Enemytimer_Tick(object sender, EventArgs e)
        {
           

           
           
        }

        private void pbBulletEnemy_Click(object sender, EventArgs e)
        {
            pbBulletEnemy.Visible = false;

        }
    }
}