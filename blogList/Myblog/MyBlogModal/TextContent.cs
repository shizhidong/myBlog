using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class TextContent
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string createTime;
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        public TextContent() { }
    }
}
