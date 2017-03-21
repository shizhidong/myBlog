using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class AboutSiteDAO
    {
        private SQLHelper sqlhelper = null;

        public AboutSiteDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 查询关于我们
        /// </summary>
        /// <returns></returns>
        public aboutMy AboutSiteSelect()
        {
            DataTable dt = new DataTable();
            aboutMy about = new aboutMy();
            string sql = "SELECT * FROM aboutSiteText";
            dt = sqlhelper.GetDataTable(sql);
            about.Id = dt.Rows[0]["id"].ToString();
            about.AboutSite = dt.Rows[0]["aboutSite"].ToString();
            about.MyName = dt.Rows[0]["myName"].ToString();
            about.Occupation = dt.Rows[0]["occupation"].ToString();
            about.Introduction = dt.Rows[0]["introduction"].ToString();
            about.AboutMyText = dt.Rows[0]["aboutMyText"].ToString();
            return about;

        }

        /// <summary>
        /// 修改关于我们
        /// </summary>
        /// <param name="cont">内容</param>
        /// <param name="id">id</param>
        /// <returns></returns>
        public bool AboutUpdate(aboutMy abmy)
        {
            bool falg = false;
            string sql = "UPDATE aboutSiteText set aboutSite=@aboutSite,myName=@myName,occupation=@occupation,introduction=@introduction,aboutMyText=@aboutMyText ";
            SqlParameter[] par ={
                               new SqlParameter("@aboutSite",abmy.AboutSite),
                               new SqlParameter("@myName",abmy.MyName),
                               new SqlParameter("@occupation",abmy.Occupation),
                               new SqlParameter("@introduction",abmy.Introduction),
                               new SqlParameter("@aboutMyText",abmy.AboutMyText)
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
