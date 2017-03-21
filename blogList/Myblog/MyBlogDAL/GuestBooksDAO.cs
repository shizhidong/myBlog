using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class GuestBooksDAO
    {
        private SQLHelper sqlhelper = null;

        public GuestBooksDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 插入留言板内容
        /// </summary>
        /// <param name="guest">实体类</param>
        /// <returns></returns>
        public bool InsertGuestBooks(GuestBooks guest)
        {
            bool falg = false;
            string sql = "insert into sayGuest(sayName,sayPhone,sayCont)values(@sayName,@sayPhone,@sayCont)";
            SqlParameter[] par ={
                               new SqlParameter("@sayName",guest.SayName),
                               new SqlParameter("@sayPhone",guest.SayPhone),
                               new SqlParameter("@sayCont",guest.SayCont)
                               };

            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            if (res > 0)
            {
                falg = true;
            }
            return falg;
        }
        /// <summary>
        /// 查询所有留言
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllGuest()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * from sayGuest ORDER BY sayDateTime DESC";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }

    }
}
