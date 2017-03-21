using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

namespace MyBlogWeb
{
    public partial class WebConfigEncryptDecrypt : System.Web.UI.Page
    {
        string provider = "RsaProtectedConfigurationProvider";
        string section = "connectionStrings";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 加密Web.config文件
        /// </summary>
        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            Configuration confg = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            ConfigurationSection configSect = confg.GetSection(section);
            if (configSect != null)
            {
                configSect.SectionInformation.ProtectSection(provider);
                confg.Save();
            }





        }
        /// <summary>
        /// 解密Web.config文件
        /// </summary>
        protected void btnDecrypt_Click(object sender, EventArgs e)
        {
            //得到当前配置文件
            Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            //得到节部分
            ConfigurationSection section = config.GetSection("connectionStrings");
            //如果节不为空并且这个节被保护
            if (section != null && section.SectionInformation.IsProtected)
            {
                //保护指定的节使用RSA加密算法对数据进行加密和解密
                section.SectionInformation.UnprotectSection();
                //保存
                config.Save();
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('解密成功！');</script>");
                //RegisterStartupScript("", "<script>alert('解密成功！')</script>");
            }
        }
    }
}