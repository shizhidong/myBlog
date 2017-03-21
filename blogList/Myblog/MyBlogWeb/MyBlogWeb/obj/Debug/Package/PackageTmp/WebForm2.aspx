<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MyBlogWeb.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        id<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

        内容<textarea id="TxtCont" cols="35" rows="6" runat="server" /></textarea><br />

        地址<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="删除" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
