using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogModal
{
  public class MyNavlink
    {
      public MyNavlink() { 
      }
      private string id;
      public string Id
      {
          get { return id; }
          set { id = value; }
      }
      private string title;
      public string Tile
      {
          get { return title; }
          set { title = value; }
      }
      private string categoryDate;
      public string CategoryDate
      {
          get { return categoryDate; }
          set { categoryDate = value; }
      }
    }
}
