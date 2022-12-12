namespace To_The_Top
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.left_bird = new Guna.UI2.WinForms.Guna2PictureBox();
            this.right_bird = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cloud_five = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cloud_four = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cloud_mid = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cloud_left = new Guna.UI2.WinForms.Guna2PictureBox();
            this.land = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cloud_right = new Guna.UI2.WinForms.Guna2PictureBox();
            this.player = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sky2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sky1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.land)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::To_The_Top.Properties.Resources.background;
            this.panel1.Controls.Add(this.lose);
            this.panel1.Controls.Add(this.left_bird);
            this.panel1.Controls.Add(this.right_bird);
            this.panel1.Controls.Add(this.cloud_five);
            this.panel1.Controls.Add(this.cloud_four);
            this.panel1.Controls.Add(this.cloud_mid);
            this.panel1.Controls.Add(this.cloud_left);
            this.panel1.Controls.Add(this.land);
            this.panel1.Controls.Add(this.cloud_right);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.sky2);
            this.panel1.Controls.Add(this.sky1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 515);
            this.panel1.TabIndex = 0;
            // 
            // lose
            // 
            this.lose.Image = global::To_The_Top.Properties.Resources.youlose;
            this.lose.ImageRotate = 0F;
            this.lose.Location = new System.Drawing.Point(13, 55);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(336, 319);
            this.lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lose.TabIndex = 3;
            this.lose.TabStop = false;
            this.lose.UseTransparentBackground = true;
            // 
            // left_bird
            // 
            this.left_bird.Image = global::To_The_Top.Properties.Resources.blackbird;
            this.left_bird.ImageRotate = 0F;
            this.left_bird.Location = new System.Drawing.Point(0, 116);
            this.left_bird.Name = "left_bird";
            this.left_bird.Size = new System.Drawing.Size(51, 31);
            this.left_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.left_bird.TabIndex = 2;
            this.left_bird.TabStop = false;
            this.left_bird.Tag = "enemy";
            this.left_bird.UseTransparentBackground = true;
            // 
            // right_bird
            // 
            this.right_bird.Image = global::To_The_Top.Properties.Resources.bluebird;
            this.right_bird.ImageRotate = 0F;
            this.right_bird.Location = new System.Drawing.Point(313, 392);
            this.right_bird.Name = "right_bird";
            this.right_bird.Size = new System.Drawing.Size(52, 33);
            this.right_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.right_bird.TabIndex = 2;
            this.right_bird.TabStop = false;
            this.right_bird.Tag = "enemy";
            this.right_bird.UseTransparentBackground = true;
            // 
            // cloud_five
            // 
            this.cloud_five.BackColor = System.Drawing.Color.Transparent;
            this.cloud_five.Image = global::To_The_Top.Properties.Resources.cloudB;
            this.cloud_five.ImageRotate = 0F;
            this.cloud_five.Location = new System.Drawing.Point(46, 43);
            this.cloud_five.Name = "cloud_five";
            this.cloud_five.Size = new System.Drawing.Size(119, 43);
            this.cloud_five.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_five.TabIndex = 0;
            this.cloud_five.TabStop = false;
            this.cloud_five.Tag = "platform five";
            this.cloud_five.UseTransparentBackground = true;
            // 
            // cloud_four
            // 
            this.cloud_four.BackColor = System.Drawing.Color.Transparent;
            this.cloud_four.Image = global::To_The_Top.Properties.Resources.cloudB;
            this.cloud_four.ImageRotate = 0F;
            this.cloud_four.Location = new System.Drawing.Point(192, 76);
            this.cloud_four.Name = "cloud_four";
            this.cloud_four.Size = new System.Drawing.Size(119, 43);
            this.cloud_four.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_four.TabIndex = 0;
            this.cloud_four.TabStop = false;
            this.cloud_four.Tag = "platform four";
            this.cloud_four.UseTransparentBackground = true;
            // 
            // cloud_mid
            // 
            this.cloud_mid.BackColor = System.Drawing.Color.Transparent;
            this.cloud_mid.Image = global::To_The_Top.Properties.Resources.cloudB;
            this.cloud_mid.ImageRotate = 0F;
            this.cloud_mid.Location = new System.Drawing.Point(111, 190);
            this.cloud_mid.Name = "cloud_mid";
            this.cloud_mid.Size = new System.Drawing.Size(119, 43);
            this.cloud_mid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_mid.TabIndex = 0;
            this.cloud_mid.TabStop = false;
            this.cloud_mid.Tag = "platform mid";
            this.cloud_mid.UseTransparentBackground = true;
            // 
            // cloud_left
            // 
            this.cloud_left.BackColor = System.Drawing.Color.Transparent;
            this.cloud_left.Image = global::To_The_Top.Properties.Resources.cloudB;
            this.cloud_left.ImageRotate = 0F;
            this.cloud_left.Location = new System.Drawing.Point(28, 286);
            this.cloud_left.Name = "cloud_left";
            this.cloud_left.Size = new System.Drawing.Size(119, 43);
            this.cloud_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_left.TabIndex = 0;
            this.cloud_left.TabStop = false;
            this.cloud_left.Tag = "platform left";
            this.cloud_left.UseTransparentBackground = true;
            // 
            // land
            // 
            this.land.BackColor = System.Drawing.Color.Transparent;
            this.land.Image = global::To_The_Top.Properties.Resources.land2;
            this.land.ImageRotate = 0F;
            this.land.Location = new System.Drawing.Point(-8, 491);
            this.land.Name = "land";
            this.land.Size = new System.Drawing.Size(396, 37);
            this.land.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.land.TabIndex = 0;
            this.land.TabStop = false;
            this.land.Tag = "platform land";
            this.land.UseTransparentBackground = true;
            // 
            // cloud_right
            // 
            this.cloud_right.BackColor = System.Drawing.Color.Transparent;
            this.cloud_right.Image = global::To_The_Top.Properties.Resources.cloudA;
            this.cloud_right.ImageRotate = 0F;
            this.cloud_right.Location = new System.Drawing.Point(204, 299);
            this.cloud_right.Name = "cloud_right";
            this.cloud_right.Size = new System.Drawing.Size(134, 43);
            this.cloud_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud_right.TabIndex = 0;
            this.cloud_right.TabStop = false;
            this.cloud_right.Tag = "platform right";
            this.cloud_right.UseTransparentBackground = true;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::To_The_Top.Properties.Resources.player;
            this.player.ImageRotate = 0F;
            this.player.Location = new System.Drawing.Point(93, 447);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(36, 43);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // sky2
            // 
            this.sky2.BackColor = System.Drawing.Color.Transparent;
            this.sky2.BackgroundImage = global::To_The_Top.Properties.Resources.background;
            this.sky2.Image = global::To_The_Top.Properties.Resources.background;
            this.sky2.ImageRotate = 0F;
            this.sky2.Location = new System.Drawing.Point(0, 0);
            this.sky2.Name = "sky2";
            this.sky2.Size = new System.Drawing.Size(365, 515);
            this.sky2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sky2.TabIndex = 1;
            this.sky2.TabStop = false;
            // 
            // sky1
            // 
            this.sky1.BackColor = System.Drawing.Color.Transparent;
            this.sky1.BackgroundImage = global::To_The_Top.Properties.Resources.background;
            this.sky1.Image = global::To_The_Top.Properties.Resources.background;
            this.sky1.ImageRotate = 0F;
            this.sky1.Location = new System.Drawing.Point(0, -515);
            this.sky1.Name = "sky1";
            this.sky1.Size = new System.Drawing.Size(365, 515);
            this.sky1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sky1.TabIndex = 1;
            this.sky1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 528);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 528);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Teal;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(-1, -1);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(390, 35);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score: 0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::To_The_Top.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(389, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To The Top";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.land)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private Guna.UI2.WinForms.Guna2PictureBox sky1;
        private Guna.UI2.WinForms.Guna2PictureBox cloud_left;
        private Guna.UI2.WinForms.Guna2PictureBox cloud_right;
        private Guna.UI2.WinForms.Guna2PictureBox sky2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox cloud_mid;
        private Guna.UI2.WinForms.Guna2PictureBox cloud_four;
        private Guna.UI2.WinForms.Guna2PictureBox cloud_five;
        private Guna.UI2.WinForms.Guna2PictureBox land;
        private Guna.UI2.WinForms.Guna2PictureBox right_bird;
        private Guna.UI2.WinForms.Guna2PictureBox left_bird;
        private Guna.UI2.WinForms.Guna2PictureBox lose;
    }
}