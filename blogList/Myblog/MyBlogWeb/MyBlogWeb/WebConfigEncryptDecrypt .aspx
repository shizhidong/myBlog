<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebConfigEncryptDecrypt .aspx.cs" Inherits="MyBlogWeb.WebConfigEncryptDecrypt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="加密数据库连接" OnClick="btnEncrypt_Click" />
        <asp:Button ID="Button2" runat="server" Text="解密数据库连接" OnClick="btnDecrypt_Click" />
    </div>
    </form>
</body>
</html>
