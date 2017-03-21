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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AboutSiteDAO abdao = new AboutSiteDAO();
                aboutMy abmy = abdao.AboutSiteSelect();
                lblAboutMy.Text = abmy.AboutMyText;
            }
        }
    }
}