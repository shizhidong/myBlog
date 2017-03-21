using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogModal;
using MyBlogDAL;

namespace MyBlogWeb
{
    public partial class DetailRe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string caid = Request.QueryString["CaIdRe"];
                RecmdDAO redao = new RecmdDAO();
                Recmd recmd = redao.recmdSelectRecmd(caid);
                lblTitle.Text = recmd.Title;
                string str = recmd.CreateTime;
                lblTime.Text = Convert.ToDateTime(str).ToString("yyyy-MM-dd");
                lblMyName.Text = recmd.PopName;
                lblContent.Text = recmd.Cont; 

            }
        }
    }
}