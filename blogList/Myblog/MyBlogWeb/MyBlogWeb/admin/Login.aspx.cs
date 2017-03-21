using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogModal;
using MyBlogDAL;
using System.Data;
using System.Web.Security;

namespace MyBlogWeb.admin
{
    public partial class Login1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int resQuest = Convert.ToInt32(Request.QueryString["userName"]);
           
        }
        //加密
        public static string MD5(string toCryString)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(toCryString, "MD5");
        }
         
        protected void login_Click(object sender, EventArgs e)
        {
          
            string name = userName.Text.Trim();
            string pwd = userPassWord.Text.Trim();
            string MD5J = MD5(pwd);
            DataTable dt = new DataTable();
            dt = new LoginDAO().LoginAll(name, MD5J);
            if (dt.Rows.Count > 0)
            {
                HttpCookie cook;
                string strReturnURL;
                string lv = "admin";
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1, name, DateTime.Now, DateTime.Now.AddMinutes(30), false, lv);
                cook = new HttpCookie("mycook");
                cook.Value = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(cook);
                strReturnURL = Request.Params["ReturnUrl"];
               
                if (strReturnURL != null)
                {                    
                    Response.Redirect(strReturnURL);
                }
                else
                { 
                    
                    Response.Redirect("Default.aspx");
 
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('用户名或者密码错误');</script>");
            }

        }
    }
}