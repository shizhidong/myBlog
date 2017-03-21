using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class GuestBooks
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string sayName;
        public string SayName
        {
            get { return sayName; }
            set { sayName = value; }
        }
        private string sayPhone;
        public string SayPhone
        {
            get { return sayPhone; }
            set { sayPhone = value; }
        }
        private string sayCont;
        public string SayCont
        {
            get { return sayCont; }
            set { sayCont = value; }
        }
        private string sayDateTime;
        public string SayDateTime
        {
            get { return sayDateTime; }
            set { sayDateTime = value; }
        }
        public GuestBooks() { }
    }
}
