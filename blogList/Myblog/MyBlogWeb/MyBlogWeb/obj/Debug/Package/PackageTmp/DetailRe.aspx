<%@ Page Title="详情" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="DetailRe.aspx.cs" Inherits="MyBlogWeb.DetailRe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--left-->
    <div class="left" id="news">
        <div class="weizi">
            <div class="wz_text">
                当前位置：<a href="Default.aspx">首页</a>>精心推荐><span>文章内容</span></div>
        </div>
        <div class="news_content">
            <div class="news_top">
                <h1>
                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                </h1>
                <p>
                    <span class="left sj color"><span class="left">时间:</span><asp:Label ID="lblTime"
                        runat="server" Text=""></asp:Label></span> <span class="left author color">
                            <asp:Label ID="lblMyName" runat="server" Text="Label"></asp:Label></span>
                </p>
                <div class="clear">
                </div>
            </div>
            <div class="news_text" style="margin-top: 20px;">
                <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
    <!--end left -->
</asp:Content>
