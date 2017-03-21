using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyBlogDAL
{
   public class TextContentDAO
    {
        private SQLHelper sqlhelper = null;

        public TextContentDAO()
        {
            sqlhelper = new SQLHelper();
        }

       /// <summary>
       /// 查询所有内容
       /// </summary>
       /// <returns></returns>
        public DataTable textContentAll() {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM textContent";
            dt = sqlhelper.GetDataTable(sql);
            return dt;
        }
    }
}
