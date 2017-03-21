using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MyBlogModal;

namespace MyBlogDAL
{
    public class codeContentCssDAO
    {
        private SQLHelper sqlhelper = null;

        public codeContentCssDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 查询所有内容
        /// </summary>
        /// <returns></returns>
        public DataTable selectAll() {

            DataTable dt = new DataTable();
            string sql = "SELECT * FROM codeContentCss";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }


        /// <summary>
        /// 查询最新10条内容
        /// </summary>
        /// <returns></returns>
        public DataTable codeContentCssSelectTop()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT top 5 * FROM codeContentCss ORDER BY createTime DESC";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
        /// <summary>
        /// 查询类别名用于标题
        /// </summary>
        /// <param name="CaName"></param>
        /// <returns></returns>
        public CodeContentCss CodeContentCssSelectCaNameTitle(string CaName)
        {
            DataTable dt = new DataTable();
            CodeContentCss css = new CodeContentCss();
            string sql = " SELECT top 1 caName FROM codeContentCss WHERE caName=@caName";
            SqlParameter[] par = { 
                                 new SqlParameter("@CaName",CaName)
                                 };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            css.CaName = dt.Rows[0]["caName"].ToString();
            return css;

        }


       

        public DataTable CodeContentCssSelectCaNamehaha(string CaName)
        {
            DataTable dt = new DataTable();
            string sql = " SELECT top 1 caName FROM codeContentCss WHERE caName=@caName";
            SqlParameter[] par = { 
                                 new SqlParameter("@CaName",CaName)
                                 };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            return dt;

        }


        /// <summary>
        /// 根据类别查询所有内容
        /// </summary>
        /// <param name="Categroy"></param>
        /// <returns></returns>
        public DataTable CodeContentCssSelectCaName(string CaName)
        {
            DataTable dt = new DataTable();
           string sql = " SELECT * from codeContentCss WHERE caName=@CaName ORDER BY createTime DESC";


           SqlParameter[] par = { 
                                 new SqlParameter("@CaName",CaName)
                                };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
           return dt;

        }



       


        /// <summary>
        /// 查询内容
        /// </summary>
        /// <returns></returns>
        public DataTable CodeContentCssSelect(string CaName)
        {
            DataTable dt = new DataTable();
            //string sql = "select * from codeContentCss where CaName=@CaName";
            string sql = " SELECT TOP 10* FROM [dbo].[codeContentCss] WHERE caName = @caName ORDER BY createTime DESC;";


            SqlParameter[] par = { 
                                 new SqlParameter("@CaName",CaName)
                                 };
            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            return dt;

        }
        /// <summary>
        /// 根据id查找内容
        /// </summary>
        /// <param name="id">内容id</param>
        /// <returns></returns>
        public CodeContentCss CodeContentCssSelectId(string id)
        {
            CodeContentCss css = new CodeContentCss();
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM codeContentCss WHERE id=@id";
            SqlParameter[] par = { 
                                 new SqlParameter("@id",id)
                                 };

            dt = sqlhelper.GetDataTable(sql, CommandType.Text, par);
            css.Id = id;
            css.Title = dt.Rows[0]["title"].ToString();
            css.NewsContent = dt.Rows[0]["newsContent"].ToString();
            css.CreateTime = dt.Rows[0]["createTime"].ToString();
            css.CaName = dt.Rows[0]["caName"].ToString();
            css.Explain = dt.Rows[0]["explain"].ToString();
            return css;
        }


        /// <summary>
        /// 插入css栏目内容
        /// </summary>
        /// <param name="codeCss">实体类</param>
        /// <returns></returns>

        public bool CodeContentCssInsert(CodeContentCss codeCss)
        {
            bool falg = false;
            string sql = "insert into codeContentCss(title,newsContent,caName,explain,popName)values(@title,@newsContent,@caName,@explain,@popName)";
            SqlParameter[] par ={
                new SqlParameter("@title",codeCss.Title),
                new SqlParameter("@newsContent",codeCss.NewsContent),
                new SqlParameter("@caName",codeCss.CaName),
                new SqlParameter("@explain",codeCss.Explain),
                new SqlParameter("@popName",codeCss.PopName)
                };
            int res = sqlhelper.ExecuteNonQuery(sql, CommandType.Text, par);
            if (res > 0)
            {
                falg = true;
            }
            return falg;
        }
        /// <summary>
        /// 删除内容
        /// </summary>
        /// <param name="id">内容ID</param>
        /// <returns></returns>
        public bool CodeContentCssDelete(string id)
        {
            bool falg = false;
            string sql = "DELETE  codeContentCss WHERE id=@id";
            int res = sqlhelper.ExecuteNonQuery(sql);
            if (res > 0)
            {
                falg = true;
            }
            return falg;
        }


    }
}
