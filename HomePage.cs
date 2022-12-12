using System;
using System.Windows.Forms;

namespace To_The_Top
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            var GamePage = new GamePage();
            GamePage.Show();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
