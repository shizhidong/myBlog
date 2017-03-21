using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyBlogDAL
{
    public class MyNavlinkDAO
    {
        private SQLHelper sqlhelper = null;

        public MyNavlinkDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 插入导航标题
        /// </summary>
        /// <param name="CaName">标题名字</param>
        /// <returns></returns>
        public bool MyNavLinkInsert(string CaName, string navLinkUrl)
        {
            bool falg = false;
            string sql = "INSERT INTO my_navlink(title,url) VALUES(@title,@url)";
            SqlParameter[] par = { 
                                 new SqlParameter("@title",CaName),
                                 new SqlParameter("@url",navLinkUrl)
                                 };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            if (res > 0)
            {
                falg = true;
            }
            return falg;
        }
        /// <summary>
        /// 删除导航标题
        /// </summary>
        /// <param name="id">标题id</param>
        /// <returns></returns>
        public int MyNavLinkDelete(int id)
        {
            string sql = "delete my_navlink where id=@id";
            SqlParameter[] par = { 
                                 new SqlParameter("@id",id)
                                 };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            return res;
        }
        /// <summary>
        ///  查询所有导航标题
        /// </summary>
        /// <returns>表</returns>
        public DataTable MyNavLinkSelect()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM my_navlink";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }

    }
}
