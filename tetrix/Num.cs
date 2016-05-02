using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tetrix
{
    public partial class Num : UserControl
    {
        public Num()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
            this.Size = new Size(25, 50);
        }
        
        private int number = 0;
        public int Number 
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0 || value > 9) {
                    number = 0; 
                } else {
                    number = value;
                }
                this.Invalidate(); 
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            switch (number)
            {
                case 0: g.DrawImage(global::tetrix.Properties.Resources.number_0, rec); break;
                case 1: g.DrawImage(global::tetrix.Properties.Resources.number_1, rec); break;
                case 2: g.DrawImage(global::tetrix.Properties.Resources.number_2, rec); break;
                case 3: g.DrawImage(global::tetrix.Properties.Resources.number_3, rec); break;
                case 4: g.DrawImage(global::tetrix.Properties.Resources.number_4, rec); break;
                case 5: g.DrawImage(global::tetrix.Properties.Resources.number_5, rec); break;
                case 6: g.DrawImage(global::tetrix.Properties.Resources.number_6, rec); break;
                case 7: g.DrawImage(global::tetrix.Properties.Resources.number_7, rec); break;
                case 8: g.DrawImage(global::tetrix.Properties.Resources.number_8, rec); break;
                case 9: g.DrawImage(global::tetrix.Properties.Resources.number_9, rec); break;
            }
        }
        private void Num_Load(object sender, EventArgs e)
        {

        }
    }
}
