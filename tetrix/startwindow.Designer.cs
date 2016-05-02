namespace tetrix
{
    partial class startWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.singleGame = new System.Windows.Forms.Button();
            this.onlineGame = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleGame
            // 
            this.singleGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.singleGame.Location = new System.Drawing.Point(133, 145);
            this.singleGame.Name = "singleGame";
            this.singleGame.Size = new System.Drawing.Size(132, 52);
            this.singleGame.TabIndex = 0;
            this.singleGame.Text = "单机游戏";
            this.singleGame.UseVisualStyleBackColor = false;
            this.singleGame.Click += new System.EventHandler(this.singleGame_Click);
            // 
            // onlineGame
            // 
            this.onlineGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.onlineGame.Location = new System.Drawing.Point(133, 222);
            this.onlineGame.Name = "onlineGame";
            this.onlineGame.Size = new System.Drawing.Size(132, 51);
            this.onlineGame.TabIndex = 1;
            this.onlineGame.UseVisualStyleBackColor = false;
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.quit.Location = new System.Drawing.Point(133, 294);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(132, 53);
            this.quit.TabIndex = 2;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // startWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tetrix.Properties.Resources.startgame;
            this.ClientSize = new System.Drawing.Size(402, 401);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.onlineGame);
            this.Controls.Add(this.singleGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块";
            this.Load += new System.EventHandler(this.startWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleGame;
        private System.Windows.Forms.Button onlineGame;
        private System.Windows.Forms.Button quit;
    }
}

