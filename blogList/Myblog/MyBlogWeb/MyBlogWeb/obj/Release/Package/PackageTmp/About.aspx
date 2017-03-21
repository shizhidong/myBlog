<%@ Page Title="关于我" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="MyBlogWeb.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--left-->
    <div class="left" id="about_me">
        <div class="weizi">
            <div class="wz_text">
                当前位置：<a href="#">首页</a>><h1>
                    关于我</h1>
            </div>
        </div>
        <div class="about_content">
            <asp:Label ID="lblAboutMy" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <!--end left -->
    <script type="text/javascript">
        $(function () {
            $("#nav ul li").removeClass("nava");
            $("#nav ul").find("#nav2").addClass("nava").find("a").css("color", "#fff");
        })
                    </script>
</asp:Content>
