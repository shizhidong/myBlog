<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyBlogWeb.admin.Login1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/LoginStyle.css" />
</head>
<body>
    <form id="form1" method="post" runat="server" action="Login.aspx">
    <section class="container">
    <div class="login">
      <h1>管理员登录</h1>
        <p><asp:TextBox ID="userName" runat="server" placeholder="登录名"></asp:TextBox></p>
        <p><asp:TextBox ID="userPassWord" TextMode="Password" runat="server" placeholder="密码"></asp:TextBox></p>
        <p class="submit"><asp:Button ID="login" runat="server" Text="登录" onclick="login_Click" /></p>
    </div>
  </section>
    </form>
   
</body>
</html>
