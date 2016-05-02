namespace tetrix
{
    partial class gameForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.roleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roleName,
            this.score,
            this.level,
            this.saveTime});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 24);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 258);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // roleName
            // 
            this.roleName.Text = "角色名称";
            this.roleName.Width = 61;
            // 
            // score
            // 
            this.score.Text = "分数";
            this.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.score.Width = 98;
            // 
            // level
            // 
            this.level.Text = "级别";
            this.level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.level.Width = 126;
            // 
            // saveTime
            // 
            this.saveTime.Text = "保存时间";
            this.saveTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveTime.Width = 120;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 294);
            this.Controls.Add(this.listView1);
            this.Name = "gameForm";
            this.Text = "gameForm";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader roleName;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader saveTime;
    }
}