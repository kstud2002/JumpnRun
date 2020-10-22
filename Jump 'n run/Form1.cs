using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jump__n_run
{
    public partial class Form1 : Form
    {
        //double Gravity = 8;
        bool isJumping = false;
        bool airborne = false;
        
        // gravity
        int Gravity = 1;
        int Acceleration = 1;
        string momentum;

        // velocity y
        int vy = 0;
        int vx = 0;
        int x = 150;
        int y = 350;
        bool walkright = false;
        bool walkleft = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrwalkright_Tick(object sender, EventArgs e)
        {
            if (vx < 10)
            {
                vx += Acceleration;
            }
            /*if (pbPlayer.Left >= 400)
            {
                walkright = true;
            }
            if (walkright && pbPlayer.Left > 350)
            {
                //tmrWalk.Start();
            }*/
            //else if (pbPlayer.Left == 350 && walkright)
            //{
                pbBackground1.Left -= (vx / 2);
                pbBackground2.Left -= (vx / 2);            
                pbGround1.Left -= vx;
                pbGround2.Left -= vx;
                if (pbBackground1.Location.X <= -800)
                {
                    pbBackground1.Location = new Point(800, 0);
                }
                if (pbBackground2.Location.X <= -800)
                {
                    pbBackground2.Location = new Point(800, 0);
                }
                if (pbGround1.Location.X <= -800)
                {
                    pbGround1.Location = new Point(800, 400);
                }
                if (pbGround2.Location.X <= -800)
                {
                    pbGround2.Location = new Point(800, 400);
                }
            //}
            //else
            //{
                //walkright = false;                
                pbPlayer.Left += vx;
            //}
        }
        private void tmrwalkleft_Tick(object sender, EventArgs e)
        {
            if (vx <= 10)
            {
                vx += Acceleration;
            }
            /*if (pbPlayer.Left <= 350)
            {
                walkleft = true;
            }
            if (walkleft && pbPlayer.Left < 400)
            {
                //tmrWalk.Start();
            }*/
            //else if (pbPlayer.Left == 400 && walkleft)
            //{
                pbBackground1.Left += (vx / 2);
                pbBackground2.Left += (vx / 2);
                pbGround1.Left += vx;
                pbGround2.Left += vx;
                if (pbBackground1.Location.X == 800)
                {
                    pbBackground1.Left = pbBackground2.Right;
                }
                if (pbBackground2.Location.X == 800)
                {
                    pbBackground2.Left = pbBackground1.Right;
                }
                if (pbGround1.Location.X == 800)
                {
                    pbGround1.Left = pbGround2.Right;
                }
                if (pbGround2.Location.X == 800)
                {
                    pbGround2.Left = pbGround1.Right;
                }
            //}
            //else
            //{
                //walkleft = false;
                pbPlayer.Left -= vx;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                walkleft = false;
                tmrwalkright.Start();
                tmrwalkleft.Stop();
                momentum = "right";
            }
            if (e.KeyCode == Keys.Left)
            {
                walkright = false;
                tmrwalkleft.Start();
                tmrwalkright.Stop();
                momentum = "left";
            }
            if (e.KeyCode == Keys.Space)
            {
                isJumping = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                tmrwalkright.Stop();
                tmrMomentum.Start();
                tmrWalk.Stop();
            }
            if (e.KeyCode == Keys.Left)
            {
                tmrwalkleft.Stop();
                tmrMomentum.Start();
                tmrWalk.Stop();
            }
        }


        private void tmrJump_Tick(object sender, EventArgs e)
        {
            if (pbPlayer.Bounds.IntersectsWith(pbGroundCollision.Bounds))
            {
                vy = 0;
                airborne = false;

                if (isJumping)
                {
                    vy = -20;
                }

            }
            else
            {
                airborne = true;
                isJumping = false;
                vy += Gravity;
            }

            y += vy;
            pbPlayer.Top = y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrUpdate.Start();
            tmrJump.Start();
        }
         

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (pbPlayer.Left <= 0)
            {
                pbPlayer.Left = 0;
            }
            if (pbPlayer.Left >= 750)
            {
                pbPlayer.Left = 750;
            }
        }

        private void tmrWalk_Tick(object sender, EventArgs e)
        {
            if (walkright)
            {
                pbBackground1.Left += 4;
                pbBackground2.Left += 4;
                pbGround1.Left += 10;
                pbGround2.Left += 10;
                pbPlayer.Left -= 10;
                if (pbPlayer.Left == 350)
                {
                    tmrWalk.Stop();
                }
            }
            else if (walkleft)
            {
                pbBackground1.Left -= 4;
                pbBackground2.Left -= 4;
                pbGround1.Left -= 10;
                pbGround2.Left -= 10;
                pbPlayer.Left += 10;
                if (pbPlayer.Left <= 400)
                {
                    tmrWalk.Stop();
                }
            }
        }

        private void tmrMomentum_Tick(object sender, EventArgs e)
        {
            if (momentum == "right")
            {
                if (airborne)
                {
                    vx -= (Acceleration / 3);
                }
                else
                {
                    vx -= Acceleration;
                }
                pbBackground1.Left -= (vx / 2);
                pbBackground2.Left -= (vx / 2);
                pbGround1.Left -= vx;
                pbGround2.Left -= vx;
                if (pbBackground1.Location.X <= -800)
                {
                    pbBackground1.Location = new Point(800, 0);
                }
                if (pbBackground2.Location.X <= -800)
                {
                    pbBackground2.Location = new Point(800, 0);
                }
                if (pbGround1.Location.X <= -800)
                {
                    pbGround1.Location = new Point(800, 400);
                }
                if (pbGround2.Location.X <= -800)
                {
                    pbGround2.Location = new Point(800, 400);
                }
                pbPlayer.Left += vx;
                if (vx <= 0)
                {
                    tmrMomentum.Stop();
                }
            }
            if (momentum == "left")
            {
                if (airborne)
                {
                    vx -= (Acceleration / 3);
                }
                else
                {
                    vx -= Acceleration;
                }
                pbBackground1.Left += (vx / 2);
                pbBackground2.Left += (vx / 2);
                pbGround1.Left += vx;
                pbGround2.Left += vx;
                if (pbBackground1.Location.X == 800)
                {
                    pbBackground1.Left = pbBackground2.Right;
                }
                if (pbBackground2.Location.X == 800)
                {
                    pbBackground2.Left = pbBackground1.Right;
                }
                if (pbGround1.Location.X == 800)
                {
                    pbGround1.Left = pbGround2.Right;
                }
                if (pbGround2.Location.X == 800)
                {
                    pbGround2.Left = pbGround1.Right;
                }
                pbPlayer.Left -= vx;
                if (vx <= 0)
                {
                    tmrMomentum.Stop();
                }
            }
        }
    }
}
