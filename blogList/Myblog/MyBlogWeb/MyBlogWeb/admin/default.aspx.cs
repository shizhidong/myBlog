using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogDAL;
using MyBlogModal;

namespace MyBlogWeb.admin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AboutSiteDAO aboutdao = new AboutSiteDAO();
                aboutMy outmy = aboutdao.AboutSiteSelect();
                aboutCode.InnerText = outmy.AboutSite;
                bozhu.Value = outmy.MyName;
                zhiye.Value = outmy.Occupation;
                jianjie.InnerText = outmy.Introduction;
                guanyumy.InnerText = outmy.AboutMyText;

                RepRiJi.DataSource = new RiJiDAO().RiJiSelectAll();
                RepRiJi.DataBind();

                RepGuest.DataSource = new GuestBooksDAO().SelectAllGuest();
                RepGuest.DataBind();
               


            }
        }
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void modify_Click(object sender, EventArgs e)
        {
            aboutMy aboutmy = new aboutMy();
            aboutmy.AboutSite = aboutCode.InnerText;
            aboutmy.MyName = bozhu.Value;
            aboutmy.Occupation = zhiye.Value;
            aboutmy.Introduction = jianjie.InnerText;
            aboutmy.AboutMyText = guanyumy.InnerText;
            bool res = new AboutSiteDAO().AboutUpdate(aboutmy);

            if (res)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('关于我们修改成功');</script>");

            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('关于我们修改失败');</script>");
            }

        }
        /// <summary>
        /// 文章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            codeContentCssDAO cssdao = new codeContentCssDAO();
            CodeContentCss codecss = new CodeContentCss();

            string textTitle = TextBoxTitle.Text;
            string dropDownList2 = DropDownList2.Text;
            string dropDownList1 = DropDownList1.Text;
            string textareaExp = TextareaExp.InnerText;
            string textareaContent = TextareaContent.InnerText;
            if (textTitle == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('标题不能为空');</script>");
                return;
            }
            else if (textareaExp == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('说明不能为空');</script>");
                return;
            }
            else if (textareaContent == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('内容不能为空');</script>");
                return;
            }

            codecss.Title = textTitle;
            codecss.CaName = dropDownList1;
            codecss.PopName = dropDownList2;
            codecss.Explain = textareaExp;
            codecss.NewsContent = textareaContent;

            bool res = cssdao.CodeContentCssInsert(codecss);

            if (res)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文章增加插入成功');</script>");
                 TextBoxTitle.Text="";
                  TextareaExp.InnerText="";
                  TextareaContent.InnerText="";

            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文章增加插入失败');</script>");
            }

        }
        /// <summary>
        /// 精心推荐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_ClickTuiJian(object sender, EventArgs e)
        {
            Recmd recmd = new Recmd();
            RecmdDAO recmddao = new RecmdDAO();

            string titleTuiJian = TextJxTuijian.Text;
            string contTuiJian = TxtJxTuijianTart.InnerText;
            string drTuiJian = DropJxTuiJian.Text;

            if (titleTuiJian == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('标题不能为空');</script>");
                return;
            }
            else if (contTuiJian == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('内容不能为空');</script>");
                return;
            }

            recmd.Title = titleTuiJian;
            recmd.Cont = contTuiJian;
            recmd.PopName = drTuiJian;

            bool res = recmddao.insertRecmd(recmd);
            if (res)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('精心推荐插入成功');</script>");
               TextJxTuijian.Text = "";
               TxtJxTuijianTart.InnerText = "";

            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('精心推荐插入失败');</script>");
            }


        }
        /// <summary>
        /// 个人日记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Btn_Click(object sender, EventArgs e)
        {
            RiJiDAO rijidao = new RiJiDAO();
            RiJiModal rijimodal = new RiJiModal();

            string txtcon = TxtCont.InnerText;
            string txturl = TxtUrl.Text;

            if (txtcon == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('内容不能为空');</script>");
                return;
            }
            else if (txturl == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('地址不能为空');</script>");
                return;
            }
            rijimodal.RiJiText = txtcon;
            rijimodal.RiJiImgUrl = txturl;

            bool bol = rijidao.RiJiInsert(rijimodal);
            if (bol)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记插入成功');</script>");
                TxtCont.InnerText = "";
                TxtUrl.Text = "";
                Response.Redirect("default.aspx");
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记插入失败');</script>");
            }

        }
        /// <summary>
        /// 碎言碎语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button3_Click(object sender, EventArgs e)
        {
            SayModal saymodal = new SayModal();
            
            SayDAO saydao = new SayDAO();
            string txtconttext = TxtContText.InnerText;
           
            if (txtconttext == "")
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('内容不能为空');</script>");
                return;
            }
            saymodal.SayCont = txtconttext;

            bool b = saydao.SayInsertrt(saymodal);
            if (b)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert(' 碎言碎语插入成功');</script>");
                TxtContText.InnerText = "";
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert(' 碎言碎语插入失败');</script>");
            }


        }

        protected void Modify_Click(object sender, EventArgs e)
        {
            RiJiDAO rijidao = new RiJiDAO();
            RiJiModal rijimodal = new RiJiModal();
            string wid = TxtId.Text;
            string con = TxtCont.InnerText;
            string url = TxtUrl.Text;

            rijimodal.Id = wid;
            rijimodal.RiJiText = con;
            rijimodal.RiJiImgUrl = url;

          bool b = rijidao.RiJiUpdate(rijimodal);
          if (b)
          {

              Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记修改成功');</script>");
              TxtCont.InnerText = "";
              TxtUrl.Text = "";
              Response.Redirect("default.aspx");
          }
          else
          {

              Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记修改失败');</script>");
          }
        }

        protected void Del_Click(object sender, EventArgs e)
        {
            int wid = Convert.ToInt32(TxtId.Text);

            bool b = new RiJiDAO().RiJiDel(wid);

            if (b)
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记删除成功');</script>");
                Response.Redirect("default.aspx");
            }
            else
            {

                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('个人日记删除失败');</script>");
            }


        }

    }
}