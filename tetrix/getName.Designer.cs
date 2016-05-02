namespace tetrix
{
    partial class getName
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.scoreDisp = new System.Windows.Forms.Label();
            this.rankDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入姓名：";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.ForeColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(188, 278);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(125, 21);
            this.name.TabIndex = 2;
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.BackColor = System.Drawing.Color.Transparent;
            this.lable4.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable4.ForeColor = System.Drawing.Color.White;
            this.lable4.Location = new System.Drawing.Point(130, 189);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(69, 20);
            this.lable4.TabIndex = 3;
            this.lable4.Text = "得分：";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.Transparent;
            this.lab.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(256, 189);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(69, 20);
            this.lab.TabIndex = 4;
            this.lab.Text = "级别：";
            // 
            // submit
            // 
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(210, 314);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "确定";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // scoreDisp
            // 
            this.scoreDisp.AutoSize = true;
            this.scoreDisp.BackColor = System.Drawing.Color.Transparent;
            this.scoreDisp.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreDisp.ForeColor = System.Drawing.Color.White;
            this.scoreDisp.Location = new System.Drawing.Point(184, 189);
            this.scoreDisp.Name = "scoreDisp";
            this.scoreDisp.Size = new System.Drawing.Size(59, 20);
            this.scoreDisp.TabIndex = 6;
            this.scoreDisp.Text = "lable";
            // 
            // rankDisp
            // 
            this.rankDisp.AutoSize = true;
            this.rankDisp.BackColor = System.Drawing.Color.Transparent;
            this.rankDisp.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rankDisp.ForeColor = System.Drawing.Color.White;
            this.rankDisp.Location = new System.Drawing.Point(318, 189);
            this.rankDisp.Name = "rankDisp";
            this.rankDisp.Size = new System.Drawing.Size(59, 20);
            this.rankDisp.TabIndex = 7;
            this.rankDisp.Text = "lable";
            // 
            // getName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tetrix.Properties.Resources.gameover;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.rankDisp);
            this.Controls.Add(this.scoreDisp);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "getName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "getName";
            this.Load += new System.EventHandler(this.getName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.Label scoreDisp;
        public System.Windows.Forms.Label rankDisp;
    }
}