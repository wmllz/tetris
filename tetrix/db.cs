using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace tetrix
{
    class db
    {
        private SqlConnection conn;                 //用于记录数据库资源
        private SqlCommand sqlcom;                  //用来记录数据库命令对象
        private String sql;                         //用来存储数据库命令字符串

        public db() {
            conn = getConn();
        }
        public SqlConnection getConn()
        {
            /*功能：用于连接数据库*/
            string connString = String.Format(@"Data Source = localhost; 
                                                Initial Catalog=Tetrix;
                                                Integrated Security=True");
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public void queryCommand(string sql)
        {
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
        public SqlDataReader readerCommand(string sql)
        {
            /*功能：用于执行sql语句以ExcuteReader方法
                 *针对select方法*/
            conn = this.getConn();
            conn.Open();
            sqlcom = new SqlCommand(sql, conn);
            SqlDataReader reader = sqlcom.ExecuteReader();

            return reader;
        }
        public void closeConn()
        {
            sqlcom.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
}
