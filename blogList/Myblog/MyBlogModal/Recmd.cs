using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
   public class Recmd
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
       private string cont;
       public string Cont
       {
           get { return cont; }
           set { cont = value; }
       }
       private string createTime;
       public string CreateTime
       {
           get { return createTime; }
           set { createTime = value; }
       }
       private string popName;
       public string PopName
       {
           get { return popName; }
           set { popName = value; }
       }
       public Recmd() { }
    }
}
