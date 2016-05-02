namespace tetrix
{
    partial class Tetrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetrix));
            this.mainWindow = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.nextWindow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.num5 = new tetrix.Num();
            this.num6 = new tetrix.Num();
            this.num7 = new tetrix.Num();
            this.num8 = new tetrix.Num();
            this.num4 = new tetrix.Num();
            this.num3 = new tetrix.Num();
            this.num2 = new tetrix.Num();
            this.num1 = new tetrix.Num();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWindow
            // 
            this.mainWindow.BackColor = System.Drawing.Color.Transparent;
            this.mainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainWindow.Location = new System.Drawing.Point(14, 43);
            this.mainWindow.Name = "mainWindow";
            this.mainWindow.Size = new System.Drawing.Size(420, 600);
            this.mainWindow.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.Location = new System.Drawing.Point(476, 598);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(130, 40);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "开始游戏";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // nextWindow
            // 
            this.nextWindow.BackColor = System.Drawing.Color.Transparent;
            this.nextWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextWindow.Location = new System.Drawing.Point(471, 160);
            this.nextWindow.Name = "nextWindow";
            this.nextWindow.Size = new System.Drawing.Size(140, 140);
            this.nextWindow.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(459, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(459, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(459, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(459, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "级";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(606, 632);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Location = new System.Drawing.Point(478, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 40);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "保存游戏";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(476, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "退出游戏";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Transparent;
            this.num5.Location = new System.Drawing.Point(587, 329);
            this.num5.Name = "num5";
            this.num5.Number = 1;
            this.num5.Size = new System.Drawing.Size(25, 50);
            this.num5.TabIndex = 12;
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.Transparent;
            this.num6.Location = new System.Drawing.Point(556, 329);
            this.num6.Name = "num6";
            this.num6.Number = 0;
            this.num6.Size = new System.Drawing.Size(25, 50);
            this.num6.TabIndex = 11;
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.Transparent;
            this.num7.Location = new System.Drawing.Point(525, 329);
            this.num7.Name = "num7";
            this.num7.Number = 0;
            this.num7.Size = new System.Drawing.Size(25, 50);
            this.num7.TabIndex = 10;
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.Transparent;
            this.num8.Location = new System.Drawing.Point(494, 329);
            this.num8.Name = "num8";
            this.num8.Number = 0;
            this.num8.Size = new System.Drawing.Size(25, 50);
            this.num8.TabIndex = 9;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Transparent;
            this.num4.Location = new System.Drawing.Point(494, 83);
            this.num4.Name = "num4";
            this.num4.Number = 0;
            this.num4.Size = new System.Drawing.Size(25, 50);
            this.num4.TabIndex = 5;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.Location = new System.Drawing.Point(525, 83);
            this.num3.Name = "num3";
            this.num3.Number = 0;
            this.num3.Size = new System.Drawing.Size(25, 50);
            this.num3.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Location = new System.Drawing.Point(556, 83);
            this.num2.Name = "num2";
            this.num2.Number = 0;
            this.num2.Size = new System.Drawing.Size(25, 50);
            this.num2.TabIndex = 3;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Location = new System.Drawing.Point(587, 83);
            this.num1.Name = "num1";
            this.num1.Number = 0;
            this.num1.Size = new System.Drawing.Size(25, 50);
            this.num1.TabIndex = 2;
            // 
            // Tetrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tetrix.Properties.Resources.tetrix;
            this.ClientSize = new System.Drawing.Size(624, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextWindow);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.mainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tetrix";
            this.Text = "Tetrix";
            this.Load += new System.EventHandler(this.Tetrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainWindow;
        private System.Windows.Forms.Button startBtn;
        private Num num1;
        private Num num2;
        private Num num3;
        private Num num4;
        private System.Windows.Forms.Panel nextWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Num num5;
        private Num num6;
        private Num num7;
        private Num num8;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
    }
}