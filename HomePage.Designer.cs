namespace To_The_Top
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btn_quit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.Animated = true;
            this.btn_quit.AutoRoundedCorners = true;
            this.btn_quit.BackgroundImage = global::To_The_Top.Properties.Resources.background_blue;
            this.btn_quit.BorderRadius = 21;
            this.btn_quit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_quit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_quit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_quit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_quit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.HoverState.BorderColor = System.Drawing.Color.Teal;
            this.btn_quit.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btn_quit.HoverState.FillColor = System.Drawing.Color.Teal;
            this.btn_quit.Image = global::To_The_Top.Properties.Resources.cloud_icon;
            this.btn_quit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_quit.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_quit.Location = new System.Drawing.Point(122, 382);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(131, 45);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.Text = "Quit";
            this.btn_quit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_play
            // 
            this.btn_play.Animated = true;
            this.btn_play.AutoRoundedCorners = true;
            this.btn_play.BackgroundImage = global::To_The_Top.Properties.Resources.background_blue;
            this.btn_play.BorderRadius = 21;
            this.btn_play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.HoverState.BorderColor = System.Drawing.Color.Teal;
            this.btn_play.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btn_play.HoverState.FillColor = System.Drawing.Color.Teal;
            this.btn_play.Image = global::To_The_Top.Properties.Resources.cloud_icon;
            this.btn_play.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_play.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_play.Location = new System.Drawing.Point(122, 316);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(131, 45);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::To_The_Top.Properties.Resources.To_the_Top;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-37, -4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(455, 326);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_The_Top.Properties.Resources.HomeBackground;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 563);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 561);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To The Top";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private Guna.UI2.WinForms.Guna2Button btn_quit;
    }
}

