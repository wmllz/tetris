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
    public partial class saveGame : Form
    {
        Tetrix pa3;
        private SqlConnection conn;                 //用于记录数据库资源
        private SqlCommand sqlcom;                  //用来记录数据库命令对象
        private String sql;                         //用来存储数据库命令字符串
        private SqlDataReader reader;
        private db database;
        private Int16 roleId;                       //用来保存角色Id
        private Int16 recordId;                     //用来保存记录Id
        private Int16 gameId;                       //用来保存游戏Id
        private String time;                        //用来保存当前时间
        public String curCoords = "";
        public String nextCoords = "";
        public String bgState = "";

        public saveGame(Tetrix pa, String curCoord, String nextCoord, String bg)
        {
            InitializeComponent();
            pa3 = pa;
            curCoords = curCoord;
            nextCoords = nextCoord;
            bgState = bg;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            //pa3.timer1.Stop();
            if(this.submit.Text == "返回主菜单"){
                pa3.pa2.pa1.Show();
                this.Close();
                return;
            }
            time = DateTime.Now.ToString();
            save();
        }
        private void insertRole() { 
            /*功能：插入角色信息和记录信息*/
            
            String name = this.name.Text;
            
            int score = Convert.ToInt32(this.scoreDisp.Text);
            int levels = Convert.ToInt32(this.rankDisp.Text);
              
            String sql = String.Format("select * from roles where roles.roleName='{0}'", name);
            
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不为空！");
                return ;
            }

            reader = database.readerCommand(sql);

            if (reader.Read())
            {
                roleId = reader.GetInt16(0);
                database.closeConn();
                sql = String.Format("insert into records(roleId, recordtime, score, levels) values('{0}', '{1}','{2}','{3}')", roleId, time, score, levels);
                database.queryCommand(sql);
            }
            else {
                database.closeConn();
                sql = String.Format("insert into roles(roleName, createdtime) values('{0}', '{1}')", name, time);
                database.queryCommand(sql);
                sql = String.Format("select * from roles where roles.roleName='{0}'", name);
                reader = database.readerCommand(sql);
                if (reader.Read())
                {
                    roleId = reader.GetInt16(0);
                    database.closeConn();
                    sql = String.Format("insert into records(roleId, recordtime, score, levels) values('{0}', '{1}','{2}','{3}')", roleId, time, score, levels);
                    database.queryCommand(sql);
                }
            }
          
            this.submit.Text = "返回主菜单";
            this.name.ReadOnly = true;
        }
        private void getRecordId() {
            /*功能：用来得到当前记录的Id*/
            sql = string.Format("select * from records where records.recordtime='{0}'", time);
            reader = database.readerCommand(sql);
            if (reader.Read())
            {
                recordId = reader.GetInt16(0);
                database.closeConn();
            }
        }
        private void getGameId()
        {
            /*功能：用来得到当前游戏的Id*/
            sql = string.Format("select * from games where games.saveTime='{0}'", time);
            reader = database.readerCommand(sql);
            if (reader.Read())
            {
                gameId = reader.GetInt16(0);
                database.closeConn();
            }
        }
        private void insertStorage() { 
            /*功能：插入存储信息*/
            getRecordId();
            getGameId();
            sql = String.Format("insert into storage(recordId, roleId, gameId) values('{0}','{1}','{2}')",
                                recordId, roleId, gameId);
            database.queryCommand(sql);
        }
        private void saveGame_Load(object sender, EventArgs e)
        {
        
        }
        private void save() {
            /*功能：用于保存游戏
                 *主要保存的是游戏的当前方块坐标，
                 *下一个方块的坐标，以固定方块的位置
                 *将坐标转换成字符串，*/

            //连接数据库，然后将游戏当前信息存储
            //插入游戏信息
            database = new db();
            sql = String.Format("insert into games(curCoords,nextCoords,state,saveTime) values('{0}','{1}','{2}','{3}')",
                                curCoords, nextCoords, bgState, time);

            database.queryCommand(sql);

            //插入角色信息和记录信息
            insertRole();

            //插入存储信息
            insertStorage();
        }
    }
}
