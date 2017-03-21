using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogDAL;
using System.Web.Security;

namespace MyBlogWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //加密
        public static string MD5(string toCryString)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(toCryString, "MD5");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string te1 = TextBox1.Text;
            string te2 = TextBox2.Text;
            if (te1 == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('用户名不能为空');</script>");
                return;
            }
            else if (te2 == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('密码不能为空');</script>");
                return;
            }
            else {
                string md5 = MD5(te2);
                //string md5m = 
                bool reg = new LoginDAO().LoginInsert(te1, md5);
                if (reg)
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('注册成功');</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('注册失败');</script>");
                }
            }

           



        }
    }
}