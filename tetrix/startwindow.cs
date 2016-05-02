using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tetrix
{
    public partial class startWindow : Form
    {
        public startWindow()
        {
            InitializeComponent();
        }

        private void startWindow_Load(object sender, EventArgs e)
        {

        }

        private void singleGame_Click(object sender, EventArgs e)
        {
            singleGame sinGame = new singleGame(this);
            this.Hide();
            sinGame.ShowDialog();
            
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
