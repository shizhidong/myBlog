using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class RiJiModal
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string riJiText;
        public string RiJiText
        {
            get { return riJiText; }
            set { riJiText = value; }
        }
        private string riJiDateTime;
        public string RiJiDateTime
        {
            get { return riJiDateTime; }
            set { riJiDateTime = value; }
        }
        private string riJiImgUrl;
        public string RiJiImgUrl
        {
            get { return riJiImgUrl; }
            set { riJiImgUrl = value; }
        }
        public RiJiModal() { }
    }
}
