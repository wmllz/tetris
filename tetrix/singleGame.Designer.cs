namespace tetrix
{
    partial class singleGame
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
            this.newGame = new System.Windows.Forms.Button();
            this.continueGame = new System.Windows.Forms.Button();
            this.topList = new System.Windows.Forms.Button();
            this.returnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(134, 101);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(92, 36);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "新游戏";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // continueGame
            // 
            this.continueGame.Location = new System.Drawing.Point(134, 155);
            this.continueGame.Name = "continueGame";
            this.continueGame.Size = new System.Drawing.Size(92, 36);
            this.continueGame.TabIndex = 1;
            this.continueGame.Text = "继续游戏";
            this.continueGame.UseVisualStyleBackColor = true;
            this.continueGame.Click += new System.EventHandler(this.continueGame_Click);
            // 
            // topList
            // 
            this.topList.Location = new System.Drawing.Point(134, 209);
            this.topList.Name = "topList";
            this.topList.Size = new System.Drawing.Size(92, 36);
            this.topList.TabIndex = 2;
            this.topList.Text = "排行榜";
            this.topList.UseVisualStyleBackColor = true;
            this.topList.Click += new System.EventHandler(this.topList_Click);
            // 
            // returnMenu
            // 
            this.returnMenu.Location = new System.Drawing.Point(134, 262);
            this.returnMenu.Name = "returnMenu";
            this.returnMenu.Size = new System.Drawing.Size(92, 36);
            this.returnMenu.TabIndex = 3;
            this.returnMenu.Text = "返回菜单";
            this.returnMenu.UseVisualStyleBackColor = true;
            this.returnMenu.Click += new System.EventHandler(this.returnMenu_Click);
            // 
            // singleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 357);
            this.Controls.Add(this.returnMenu);
            this.Controls.Add(this.topList);
            this.Controls.Add(this.continueGame);
            this.Controls.Add(this.newGame);
            this.Name = "singleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "singleGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button continueGame;
        private System.Windows.Forms.Button topList;
        private System.Windows.Forms.Button returnMenu;
    }
}