using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogDAL;
using MyBlogModal;
using System.Text.RegularExpressions;

namespace MyBlogWeb
{

    public partial class guestbook : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Regex mo = new Regex("^1[34578][0-9]{9}$");
            string username = TextName.Text;
            string userphone = TextPhone.Text;
            string usersay = TextSay.InnerText;
            GuestBooks guestbook = new GuestBooks();
            guestbook.SayName = username;
            guestbook.SayPhone = userphone;
            guestbook.SayCont = usersay;

            if (mo.IsMatch(TextPhone.Text.Trim()))
            {
                lblVerfInfo.Text = "";
            }
            else
            {
                lblVerfInfo.Text = "手机号码验证失败";
                return;
            }


            if (username == "")
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('您的姓名不能为空');</script>");
                return;
            }

            else if (userphone == "")
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('您的电话不能为空');</script>");
                return;
            }
            else if (usersay == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('内容不能为空');</script>");
                return;
            }


            bool b = new GuestBooksDAO().InsertGuestBooks(guestbook);
            if (b)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('您的留言提交成功,请等待回复');</script>");
                TextName.Text = "";
                TextPhone.Text = "";
                TextSay.InnerText = "";

            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('您的留言提交失败');</script>");
            }


        }
    }
}