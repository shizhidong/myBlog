using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class SayModal
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string sayCont;
        public string SayCont
        {
            get { return sayCont; }
            set { sayCont = value; }
        }
        private string createTime;
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        public SayModal() { }
    }
}
