using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class aboutMy
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string aboutSite;
        public string AboutSite
        {
            get { return aboutSite; }
            set { aboutSite = value; }
        }
        private string createTime;
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string myName;
        public string MyName
        {
            get { return myName; }
            set { myName = value; }
        }
        private string occupation;
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }
        private string introduction;
        public string Introduction
        {
            get { return introduction; }
            set { introduction = value; }
        }
        private string aboutMyText;
        public string AboutMyText
        {
            get { return aboutMyText; }
            set { aboutMyText = value; }
        }

        public aboutMy() { }
    }
}
