using System;
using System.Windows.Forms;

namespace To_The_Top
{
    public partial class GamePage : Form
    {
        bool goleft, goright;
        bool jumping = false;
        bool isGameOver = false;
        int playerSpeed = 12;
        int skySpeed;
        int cloudSpeed;
        int jumpSpeed;
        int birdSpeed = 5;
        int force = 20;
        int score;
        int cloudImage;
        Random rand = new Random();
        Random cloudPosition = new Random();
        Random birdPosition = new Random();

        public GamePage()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score :" + score;
            score++;

            player.Top += jumpSpeed;

            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;
            }

            if (goright == true && player.Left < 323)
            {
                player.Left += playerSpeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (player.Top > 445 && jumping == false)
            {
                force = 20;
                player.Top = 445;
            }

            if (jumping == true)
            {
                land.Visible = false;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform land")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {

                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platform left")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platform mid")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platform four")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platform five")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag == "platform right")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 20;
                            player.Top = x.Top - player.Height;
                        }
                        x.BringToFront();
                    }
                }
            }

            if (player.Bounds.IntersectsWith(left_bird.Bounds) || player.Bounds.IntersectsWith(right_bird.Bounds))
            {
                gameOver();
            }

            right_bird.Left -= birdSpeed;
            left_bird.Left += birdSpeed;

            if (right_bird.Left < 0 || right_bird.Left + right_bird.Width > this.ClientSize.Width)
            {
                right_bird.Top = birdPosition.Next(0, 462);
                right_bird.Image = Properties.Resources.bluebirdleft;
                birdSpeed = -birdSpeed;
            }
            if (right_bird.Left > 310 || right_bird.Left + right_bird.Width > this.ClientSize.Width)
            {
                right_bird.Top = birdPosition.Next(0, 462);
                right_bird.Image = Properties.Resources.bluebird;
                birdSpeed = -birdSpeed;
            }

            if (left_bird.Left > 313 || left_bird.Left + left_bird.Width > this.ClientSize.Width)
            {
                left_bird.Top = birdPosition.Next(0, 462);
                left_bird.Image = Properties.Resources.blackbirdright;
                birdSpeed = +birdSpeed;
            }
            if (left_bird.Left < 2 || left_bird.Left + left_bird.Width > this.ClientSize.Width)
            {
                left_bird.Top = birdPosition.Next(0, 462);
                left_bird.Image = Properties.Resources.blackbird;
                birdSpeed = +birdSpeed;
            }


            sky1.Top += skySpeed;
            sky2.Top += skySpeed;

            if (sky2.Top > 515)
            {
                sky2.Top = -515;
            }

            if (sky1.Top > 515)
            {
                sky1.Top = -515;
            }

            cloud_left.Top += cloudSpeed;
            cloud_right.Top += cloudSpeed;
            cloud_mid.Top += cloudSpeed;
            cloud_four.Top += cloudSpeed;
            cloud_five.Top += cloudSpeed;

            if (cloud_left.Top > 516)
            {
                changeCloud(cloud_left);
            }

            if (cloud_right.Top > 516)
            {
                changeCloud(cloud_right);
            }

            if (cloud_mid.Top > 516)
            {
                changeCloud(cloud_mid);
            }

            if (cloud_four.Top > 516)
            {
                changeCloud(cloud_four);
            }

            if (cloud_five.Top > 516)
            {
                changeCloud(cloud_five);
            }

            if (score > 100 && score < 300)
            {
                skySpeed = 15;
                cloudSpeed = 15;
                birdSpeed = 10;
            }

            if (score > 300 && score < 500)
            {
                skySpeed = 20;
                cloudSpeed = 20;
                birdSpeed = 15;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void changeCloud(PictureBox tempCloud)
        {
            cloudImage = rand.Next(1, 3);

            switch (cloudImage)
            {
                case 1:
                    tempCloud.Image = Properties.Resources.cloudA;
                    break;
                case 2:
                    tempCloud.Image = Properties.Resources.cloudB;
                    break;
                case 3:
                    tempCloud.Image = Properties.Resources.cloudC;
                    break;
            }

            tempCloud.Top = cloudPosition.Next(50, 100) * -1;

            if ((string)tempCloud.Tag == "platform left")
            {
                tempCloud.Left = cloudPosition.Next(0, 50);
            }

            if ((string)tempCloud.Tag == "platform mid")
            {
                tempCloud.Left = cloudPosition.Next(50, 100);
            }

            if ((string)tempCloud.Tag == "platform four")
            {
                tempCloud.Left = cloudPosition.Next(100, 170);
            }

            if ((string)tempCloud.Tag == "platform five")
            {
                tempCloud.Left = cloudPosition.Next(150, 200);
            }

            if ((string)tempCloud.Tag == "platform right")
            {
                tempCloud.Left = cloudPosition.Next(170, 225);
            }

        }
        private void gameOver()
        {
            gameTimer.Stop();
            lose.Visible = true;
            lose.BringToFront();
            txtScore.Text += " Press Enter to restart the game";
            isGameOver = true;

        }

        private void ResetGame()
        {
            goleft = false;
            goright = false;
            jumping = false;
            lose.Visible = false;
            isGameOver = false;
            score = 0;
            skySpeed = 12;
            cloudSpeed = 15;
            jumpSpeed = 0;
            birdSpeed = 5;
            force = 20;

            land.Visible = true;
            lose.Image = Properties.Resources.youlose;

            player.Top = 447;

            right_bird.Top = birdPosition.Next(0, 462);
            right_bird.Left = 313;

            left_bird.Top = birdPosition.Next(0, 462);
            left_bird.Left = 0;

            cloud_left.Top = cloudPosition.Next(200, 600) * -1;
            cloud_left.Left = cloudPosition.Next(0, 50);

            cloud_mid.Top = cloudPosition.Next(200, 700) * -1;
            cloud_mid.Left = cloudPosition.Next(50, 100);

            cloud_four.Top = cloudPosition.Next(200, 600) * -1;
            cloud_four.Left = cloudPosition.Next(100, 150);

            cloud_five.Top = cloudPosition.Next(600, 800) * -1;
            cloud_five.Left = cloudPosition.Next(150, 200);

            cloud_right.Top = cloudPosition.Next(200, 700) * -1;
            cloud_right.Left = cloudPosition.Next(200, 225);

            gameTimer.Start();

        }
    }
}
