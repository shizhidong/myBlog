using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class RecmdDAO
    {
        private SQLHelper sqlhelper = null;

        public RecmdDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 查询所有推荐内容
        /// </summary>
        /// <returns></returns>

        public DataTable recmdSelecAll()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Recmd";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 根据id查询内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Recmd recmdSelectRecmd(string id)
        {
            Recmd recmd = new Recmd();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Recmd WHERE id=@id";
            SqlParameter[] par = { 
                                 new SqlParameter("@id",id)
                                 };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            recmd.Id = id;
            recmd.Title = dt.Rows[0]["title"].ToString();
            recmd.Cont = dt.Rows[0]["cont"].ToString();
            recmd.CreateTime = dt.Rows[0]["createTime"].ToString();
            recmd.PopName = dt.Rows[0]["popName"].ToString();
            return recmd;
        }

        /// <summary>
        /// 查询最新前5条内容
        /// </summary>
        /// <returns></returns>
        public DataTable recmdSelecTop()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Top 5 * FROM Recmd ORDER BY createTime DESC";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 插入内容
        /// </summary>
        /// <param name="recmd">实体类</param>
        /// <returns></returns>
        public bool insertRecmd(Recmd recmd)
        {
            bool falg = false;
            string sql = "INSERT INTO Recmd(title,cont,popName) VALUES(@title,@cont,@popName)";
            SqlParameter[] par ={
                new SqlParameter("@title",recmd.Title),
                new SqlParameter("@cont",recmd.Cont),
                new SqlParameter("@popName",recmd.PopName),
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
