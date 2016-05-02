using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace tetrix
{
    public partial class getName : Form
    {
        public Tetrix pa3;
        public getName(Tetrix pa)
        {
            InitializeComponent();
            pa3 = pa;
        }


        //定义变量
        private SqlConnection conn;
        private SqlCommand sqlcom;
        private SqlDataReader reader;

        private void getName_Load(object sender, EventArgs e)
        {
            
        }
        private SqlConnection getConn()
        {
            /*功能：用于连接数据库*/
            string connString = String.Format(@"Data Source = localhost; 
                                                Initial Catalog=Tetrix;
                                                Integrated Security=True");
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        private void queryCommand(string sql) { 
            /*功能：用于执行sql语句以ExcuteNonQury方法
             *针对Update、Insert、Delete方法*/
            SqlConnection conn = this.getConn();
            conn.Open();
            SqlCommand sqlcom = new SqlCommand(sql, conn);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            conn.Close();
            conn.Dispose();
        }
        private SqlDataReader readerCommand(string sql) {
            /*功能：用于执行sql语句以ExcuteReader方法
                 *针对select方法*/
            conn = this.getConn();
            conn.Open();
            sqlcom = new SqlCommand(sql, conn);
            SqlDataReader reader= sqlcom.ExecuteReader();
            
            return reader;
        }
        private void closeConn() {
            sqlcom.Dispose();
            conn.Close();
            conn.Dispose();
        }
        private int getRanking(string time) {
            /*功能：用于得到排名*/
            int count = 0;
            string sql = String.Format("select recordtime from records order by score desc");
            SqlDataReader reader = readerCommand(sql);
            while (reader.Read()) {
                count++;
                if (reader.GetString(0) == time) {
                    break;
                }
            }
            return count;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            String name = this.name.Text;
            String time = DateTime.Now.ToString();
            Int16 roleId;
            int score = Convert.ToInt32(this.scoreDisp.Text);
            int levels = Convert.ToInt32(this.rankDisp.Text);

            if (this.submit.Text == "返回主菜单") {
                
                this.submit.Text = "确定";
                pa3.pa2.pa1.Show();
                this.Close();
                return;
            }
            String sql = String.Format("select * from roles where roles.roleName='{0}'", name);
            
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不为空！");
                return ;
            }

            reader = readerCommand(sql);

            if (reader.Read())
            {
                roleId = reader.GetInt16(0);
                closeConn();
                sql = String.Format("insert into records(roleId, recordtime, score, levels) values('{0}', '{1}','{2}','{3}')", roleId, time, score, levels);
                queryCommand(sql);
            }
            else {
                closeConn();
                sql = String.Format("insert into roles(roleName, createdtime) values('{0}', '{1}')", name, time);
                queryCommand(sql);
                sql = String.Format("select * from roles where roles.roleName='{0}'", name);
                reader = readerCommand(sql);
                if (reader.Read())
                {
                    roleId = reader.GetInt16(0);
                    closeConn();
                    sql = String.Format("insert into records(roleId, recordtime, score, levels) values('{0}', '{1}','{2}','{3}')", roleId, time, score, levels);
                    queryCommand(sql);
                }
            }
            //给排名赋值
            int ranking = getRanking(time);
            this.rankDisp.Text = ranking.ToString();
            this.submit.Text = "返回主菜单";
            this.lab.Text = "排名";
            this.name.ReadOnly = true;
        }
    }
}
