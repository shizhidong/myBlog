using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogDAL;
using MyBlogModal;

namespace MyBlogWeb
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AboutSiteDAO abdao = new AboutSiteDAO();
                aboutMy abmy = abdao.AboutSiteSelect();
                lblMyName.Text = abmy.MyName;

                string caid = Request.QueryString["CaId"];

                codeContentCssDAO codecssdao = new codeContentCssDAO();
                CodeContentCss css = codecssdao.CodeContentCssSelectId(caid);
                string strTime = css.CreateTime;
                lblTime.Text = Convert.ToDateTime(strTime).ToString("yyyy-MM-dd");
                lblCaName.Text = css.CaName;
                lblContent.Text = css.NewsContent;
                lblTitle.Text = css.Title;
                lblcate.Text = css.CaName;
                lblExplain.Text = css.Explain;

            }
        }
    }
}