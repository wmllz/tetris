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
    public partial class gameForm : Form
    {
        singleGame pa2;
        public gameForm(singleGame pa)
        {
            InitializeComponent();
            pa2 = pa;
        }
        //定义变量
        private db database;
        private SqlDataReader reader;
        String sql;
        private int sco;
        private int lev;
        private string curCoordsStr = "";
        private string nextCoordsStr = "";
        private string backgroundStr = "";

        private void gameForm_Load(object sender, EventArgs e)
        {
            database = new db();
            dispRecord();
        }

        private void dispRecord() {
      
            sql = String.Format("SELECT roles.roleName,records.score,records.levels,recordtime from roles,records where roles.roleId = records.roleId and roles.roleId in (select roleId from storage) and records.recordId in (select recordId from storage)");//sql语句   
            reader = database.readerCommand(sql);
            this.listView1.BeginUpdate(); 
            while (reader.Read()) {
                ListViewItem Item = new ListViewItem();
                Item.SubItems.Clear();
                Item.SubItems[0].Text = reader.GetString(0).ToString();
                for (int i = 1; i < 4; i++) {
                    Item.SubItems.Add(reader.GetValue(i).ToString());  
                }
                listView1.Items.Add(Item);          //显示  
            }
            this.listView1.EndUpdate();
            database.closeConn();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = (ListView)sender;//获取动态创建的listview对象
            String savetime = "";
            if (listview.SelectedItems.Count > 0)
            {
                savetime = listview.SelectedItems[0].SubItems[3].Text;
                sco = Convert.ToInt32(listview.SelectedItems[0].SubItems[1].Text);
                lev = Convert.ToInt32(listview.SelectedItems[0].SubItems[2].Text);
                pa2.sco = sco;
                pa2.lev = lev;
                //绑定产品
            }
            initInfo(savetime);
        }
        private void initInfo(String savetime) { 
            /*功能：初始化游戏信息包括当前方块坐标，下一个方块坐标，背景信息*/
            
            string sql = String.Format("select curCoords,nextCoords,state from games where saveTime='{0}'",
                                        savetime);
            reader = database.readerCommand(sql);
            if (reader.Read()) {
                curCoordsStr = reader.GetString(0);
                nextCoordsStr = reader.GetString(1);
                backgroundStr = reader.GetString(2);
            }
            pa2.curCoordsStr = curCoordsStr;
            pa2.nextCoordsStr = nextCoordsStr;
            pa2.backgroundStr = backgroundStr;
            
            this.Close();
        }
    }
}
