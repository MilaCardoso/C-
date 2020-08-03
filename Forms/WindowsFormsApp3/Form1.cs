using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // start the variables

        bool goup;
        bool godown;
        bool goleft;
        bool goright;

        int speed = 5;

        // ghost 1 and 2 variables. These guys are sane well sort of
        int ghost1 = 8;
        int ghost2 = 8;

        // ghost 3 crazy variables
        int ghost3x = 8;
        int ghost3y = 8;

        int score = 0;

        // end of listing variables
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            System.Media.SoundPlayer start = new System.Media.SoundPlayer(@"C:\Users\Client 0819\Desktop\Sounds\pacman-beginning\pacman_beginning.wav");
            start.Play();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pacman.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                pacman.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                pacman.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                pacman.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // show the socre on the board
            label1.Text = "Score: " + score;

            // player movement codes start
            if (goleft)
            {
                //moving player to the left
                pacman.Left -= speed; 
            }

            if (goright)
            {
                //moving player to the rigth
                pacman.Left += speed;
            }

            if (goup)
            {
                //moving player to the up
                pacman.Top -= speed;
            }

            if (godown)
            {
                //moving player to the down
                pacman.Top += speed;
            }
            // player moviments code end

            // moving ghosts and bumping with the walls
            redGhost.Left += ghost1;
            yellowGhost.Left += ghost2;

            // if the red ghost hits the picture box 4 then we reverse the speed
            if (redGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                ghost1 = -ghost1;
            // if the red ghost hits the picture box 3 we reverse the speed
            }
            else if (redGhost.Bounds.IntersectsWith(pictureBox3.Bounds)) 
            {
                ghost1 = -ghost1;
            }

            // if the yellow ghost hits the picture box 2 then we reverse the speed
            if (yellowGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ghost2 = -ghost2;
            // if the yellow ghost hits the picture box 1 we reverse the speed
            }
            else if (yellowGhost.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ghost2 = -ghost2;
            }
            // moving ghosts and bumping with the walls end

            // for loop to check walls, ghosts and points
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall" || x.Tag == "ghost") {
                    // checking if the player hits the wall or the ghost, then game is over
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds) || score == 30) 
                    {
                        if (score < 4)
                        {
                            label2.Text = "GAME OVER";
                            label2.Visible = true;
                            timer1.Stop();
                            pacman.Left = 0;
                            pacman.Top = 25;
                            System.Media.SoundPlayer death = new System.Media.SoundPlayer(@"C:\Users\Client 0819\Desktop\Sounds\pacman-death\pacman_death.wav");
                            death.Play();
                        } 
                        else
                        {
                            label3.Text = "Well done!!!";
                            label3.Visible = true;
                            timer1.Stop();
                            System.Media.SoundPlayer won = new System.Media.SoundPlayer(@"C:\Users\Client 0819\Desktop\Sounds\End_of_Game.wav");
                            won.Play();
                        }

             
                    }
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    // checking if the player hits the points picture box then we can add to the score
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        System.Media.SoundPlayer coin = new System.Media.SoundPlayer(@"C:\Users\Client 0819\Desktop\Sounds\pacman-chomp\pacman_chomp.wav");
                        coin.Play();
                        this.Controls.Remove(x); // remove that point
                        score++; // add to the score
                    }
                }
            }
            // end of for loop to check walls, ghosts and points

            // ghost 3 going crazy here
            pinkGhost.Left += ghost3x;
            pinkGhost.Top += ghost3y;

            //ghost 3 bumping against the walls and form borders
            if (pinkGhost.Left < 1 || 
                pinkGhost.Left + pinkGhost.Width > ClientSize.Width - 2 ||
               (pinkGhost.Bounds.IntersectsWith(pictureBox4.Bounds)) ||
               (pinkGhost.Bounds.IntersectsWith(pictureBox3.Bounds)) ||
               (pinkGhost.Bounds.IntersectsWith(pictureBox2.Bounds)) ||
               (pinkGhost.Bounds.IntersectsWith(pictureBox1.Bounds))) 
            {
                ghost3x = -ghost3x;
            }

            if (pinkGhost.Top < 1 || pinkGhost.Top + pinkGhost.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }
            // end of the crazy ghost
        }
    }
}
