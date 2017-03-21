using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class RiJiDAO
    {
        private SQLHelper sqlhelper = null;

        public RiJiDAO()
        {
            sqlhelper = new SQLHelper();
        }
        /// <summary>
        /// 查询所有的日记
        /// </summary>
        /// <returns></returns>
        public DataTable RiJiSelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Top 30 * from RiJiDB ORDER BY riJiDateTime Desc";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 插入日记内容
        /// </summary>
        /// <param name="riji"></param>
        /// <returns></returns>
        public bool RiJiInsert(RiJiModal riji)
        {
            bool flag = false;
            string sql = "INSERT into RiJiDB(riJiText,riJiImgUrl) VALUES(@riJiText,@riJiImgUrl)";
            SqlParameter[] par = { 
                                 new SqlParameter("@riJiText",riji.RiJiText),
                                 new SqlParameter("@riJiImgUrl",riji.RiJiImgUrl)
                                 };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);

            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        /// <summary>
        /// 修改日记内容
        /// </summary>
        /// <param name="riji"></param>
        /// <returns></returns>
        public bool RiJiUpdate(RiJiModal riji)
        {
            bool flag = false;
            string sql = "UPDATE RiJiDB set riJiText=@riJiText,riJiImgUrl=@riJiImgUrl WHERE id=@id";
            SqlParameter[] par = { 
                                 new SqlParameter("@id",riji.Id),
                                 new SqlParameter("@riJiText",riji.RiJiText),
                                 new SqlParameter("@riJiImgUrl",riji.RiJiImgUrl)
                                 };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);

            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

       /// <summary>
        /// 删除日记内容
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public bool RiJiDel(int id)
        {
            bool flag = false;
            string sql = "DELETE RiJiDB where id=@id";
            SqlParameter[] par ={
                                new SqlParameter("@id",id)
                                };
            int res = sqlhelper.ExecuteNonQuery(sql,CommandType.Text,par);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        

    }
}
