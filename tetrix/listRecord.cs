using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tetrix
{
    public partial class listRecord : Form
    {
        public listRecord()
        {
            InitializeComponent();
            
        }
        //定义变量
        private db database = new db();
        private SqlDataReader reader;

        private void listRecord_Load(object sender, EventArgs e)
        {
            dispRecord();
            name.ReadOnly = true;
        }
        private void dispRecord()
        {
            String sql;
            sql = string.Format("select roles.roleName,records.score,records.levels, records.recordtime from records, roles where roles.roleId = records.recordId order by score desc");
            
            reader = database.readerCommand(sql);
            this.listView1.BeginUpdate();
            while (reader.Read())
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader.GetString(0).ToString();
                for (int i = 1; i < 4; i++)
                {
                    Item.SubItems.Add(reader.GetValue(i).ToString());
                }
                listView1.Items.Add(Item);          //显示  
            }
            this.listView1.EndUpdate();
            database.closeConn();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            if (radBtn1.Checked)
            {
                dispRecord();
            }
            else if (radBtn2.Checked){

                if (String.IsNullOrEmpty(name.Text))
                {
                    MessageBox.Show("角色名不为空");
                }
                else {
                    dispRole();
                }
            }
        }
        private void dispRole() {
            String sql;
            sql = string.Format("select roles.roleName,records.score,records.levels, records.recordtime from records, roles where roles.roleId = records.recordId and roles.roleName='{0}' order by score desc", name.Text.Trim());

            reader = database.readerCommand(sql);
            this.listView1.BeginUpdate();
            while (reader.Read())
            {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader.GetString(0).ToString();
                for (int i = 1; i < 4; i++)
                {
                    Item.SubItems.Add(reader.GetValue(i).ToString());
                }
                listView1.Items.Add(Item);          //显示  
            }
            this.listView1.EndUpdate();
            database.closeConn();
        }

        private void radBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn2.Checked)
            {
                name.ReadOnly = false;
            }
            else {
                name.ReadOnly = true;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string saveTime = listView1.SelectedItems[0].SubItems[3].Text;
            string rolename = listView1.SelectedItems[0].SubItems[0].Text;
            string sql;
            sql = string.Format("delete from records where records.recordtime='{0}'", saveTime);
            database.queryCommand(sql);
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBtn.Enabled = true;
        }
    }
}
