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
    public partial class BlogRight : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AboutSiteDAO abdao = new AboutSiteDAO();
                aboutMy abmy = abdao.AboutSiteSelect();
                lblMy.Text = abmy.AboutSite;
                lblMyName.Text = abmy.MyName;
                lblOccupation.Text = abmy.Occupation;
                lblIntroduction.Text = abmy.Introduction;

                RepJs.DataSource = new codeContentCssDAO().CodeContentCssSelectCaNamehaha("js");
                RepJs.DataBind();

                RepCss.DataSource = new codeContentCssDAO().CodeContentCssSelectCaNamehaha("css");
                RepCss.DataBind();

                RepHtml.DataSource = new codeContentCssDAO().CodeContentCssSelectCaNamehaha("html");
                RepHtml.DataBind();

                RepAsp.DataSource = new codeContentCssDAO().CodeContentCssSelectCaNamehaha("asp");
                RepAsp.DataBind();

                RepOne.DataSource = new codeContentCssDAO().CodeContentCssSelectCaNamehaha("其它");
                RepOne.DataBind();

                RepNewsCont.DataSource = new codeContentCssDAO().codeContentCssSelectTop();
                RepNewsCont.DataBind();

                RepNewsTop.DataSource = new RecmdDAO().recmdSelecTop();
                RepNewsTop.DataBind();

            }
        }
        ///   <summary> 
        ///   将指定字符串按指定长度进行剪切， 
        ///   </summary> 
        ///   <param   name= "oldStr "> 需要截断的字符串 </param> 
        ///   <param   name= "maxLength "> 字符串的最大长度 </param> 
        ///   <param   name= "endWith "> 超过长度的后缀 </param> 
        ///   <returns> 如果超过长度，返回截断后的新字符串加上后缀，否则，返回原字符串 </returns> 
        public static string StringTruncat(string oldStr, int maxLength, string endWith)
        {
            if (string.IsNullOrEmpty(oldStr))
                //   throw   new   NullReferenceException( "原字符串不能为空 "); 
                return oldStr + endWith;
            if (maxLength < 1)
                throw new Exception("返回的字符串长度必须大于[0] ");
            if (oldStr.Length > maxLength)
            {
                string strTmp = oldStr.Substring(0, maxLength);
                if (string.IsNullOrEmpty(endWith))
                    return strTmp;
                else
                    return strTmp + endWith;
            }
            return oldStr;
        }
    }

}