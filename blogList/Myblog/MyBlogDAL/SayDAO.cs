using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class SayDAO
    {
        private SQLHelper sqlhelper = null;

        public SayDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 查询所有岁言碎语
        /// </summary>
        /// <returns></returns>
        public DataTable SayAll()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT top 30 * FROM say ORDER BY createTime DESC";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 插入岁言碎语
        /// </summary>
        /// <param name="says"></param>
        /// <returns></returns>
        public bool SayInsertrt(SayModal says) {

            bool flag = false;
            string sql = "insert INTO say(sayCont) VALUES(@sayCont)";

            SqlParameter[] par = { 
                                 new SqlParameter("@sayCont",says.SayCont)
                                 };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            if (res > 0)
            {
                flag = true;
            }

            return flag;
        }

    }
}
