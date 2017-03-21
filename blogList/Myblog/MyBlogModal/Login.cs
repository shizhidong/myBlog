using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
    public class Login
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPwd;
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
        public Login() { }
    }
}
