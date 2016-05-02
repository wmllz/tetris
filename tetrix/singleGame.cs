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

    public partial class singleGame : Form
    {
        public startWindow pa1;
        public Tetrix tetrix;
        public int sco = -1;
        public int lev = 1;
        public String curCoordsStr = "";
        public String nextCoordsStr = "";
        public String backgroundStr = "";
        private db database;
        public singleGame(startWindow pa)
        {
            InitializeComponent();
            pa1 = pa;
        }
        private void newGame_Click(object sender, EventArgs e)
        {
            tetrix = new Tetrix(this);
            this.Hide();
            tetrix.ShowDialog();
        }
        private void continueGame_Click(object sender, EventArgs e)
        {
            cotinueGame();
        }
        private void cotinueGame() {
            gameForm gameform = new gameForm(this);
            gameform.ShowDialog();
            if (sco == -1){
                return;
            }else{
            this.Hide(); 
            tetrix = new Tetrix(this, sco, lev, curCoordsStr, nextCoordsStr, backgroundStr, false);
            tetrix.ShowDialog();
            }
            
        }
        private void topList_Click(object sender, EventArgs e)
        {
            listRecord listrecord = new listRecord();
            listrecord.ShowDialog();
        }
        private void returnMenu_Click(object sender, EventArgs e)
        {
            pa1.Show();
            this.Close();
        }

    }
}
