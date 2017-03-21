using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class CodeContentCss
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string newsContent;
        public string NewsContent
        {
            get { return newsContent; }
            set { newsContent = value; }
        }
        private string createTime;
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string caName;
        public string CaName
        {
            get { return caName; }
            set { caName = value; }
        }
        private string explain;
        public string Explain
        {
            get { return explain; }
            set { explain = value; }
        }
        private string popName;
        public string PopName
        {
            get { return popName; }
            set { popName = value; }
        }
        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public CodeContentCss() { }
    }
}
