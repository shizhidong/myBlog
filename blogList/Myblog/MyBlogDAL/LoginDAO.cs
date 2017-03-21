using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyBlogDAL
{
    public class LoginDAO
    {
        private SQLHelper sqlhelper = null;

        public LoginDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="LoginName">登录名</param>
        /// <param name="LoginPassword">登录密码</param>
        /// <returns></returns>
        public DataTable LoginAll(string LoginName, string LoginPassword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM userAdmin WHERE userName=@userName AND userPwd=@userPwd";
            SqlParameter[] par = { 
                                 new SqlParameter("@userName",LoginName),
                                 new SqlParameter("@userPwd",LoginPassword)
                                 };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            return dt;

        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public bool LoginInsert(string userName, string UserPwd)
        {
            bool falg = false;
            string sql = "INSERT INTO userAdmin(userName,userPwd) VALUES(@userName,@UserPwd)";
            SqlParameter[] par = { 
                                 
                                 new SqlParameter("@userName",userName),
                                 new SqlParameter("@UserPwd",UserPwd)
                                 };

            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            if (res > 0)
            {
                falg = true;
            }

            return falg;
        }


    }
}
