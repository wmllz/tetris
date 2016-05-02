namespace tetrix
{
    partial class listRecord
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
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.listBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
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
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 258);
            this.listView1.TabIndex = 1;
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
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Checked = true;
            this.radBtn1.Location = new System.Drawing.Point(29, 30);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(71, 16);
            this.radBtn1.TabIndex = 2;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "所有角色";
            this.radBtn1.UseVisualStyleBackColor = true;
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.Location = new System.Drawing.Point(106, 30);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(95, 16);
            this.radBtn2.TabIndex = 3;
            this.radBtn2.Text = "查询某个角色";
            this.radBtn2.UseVisualStyleBackColor = true;
            this.radBtn2.CheckedChanged += new System.EventHandler(this.radBtn2_CheckedChanged);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(348, 12);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(75, 23);
            this.listBtn.TabIndex = 4;
            this.listBtn.Text = "list";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(208, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 5;
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Location = new System.Drawing.Point(348, 43);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // listRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 342);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.radBtn2);
            this.Controls.Add(this.radBtn1);
            this.Controls.Add(this.listView1);
            this.Name = "listRecord";
            this.Text = "listRecord";
            this.Load += new System.EventHandler(this.listRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader roleName;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader saveTime;
        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button delBtn;
    }
}