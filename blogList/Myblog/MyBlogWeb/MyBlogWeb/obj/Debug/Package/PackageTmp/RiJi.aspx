<%@ Page Title="个人日记" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="RiJi.aspx.cs" Inherits="MyBlogWeb.RiJi" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="css/animate.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="left" id="riji">
        <div class="weizi">
            <div class="wz_text">
                当前位置：<a href="Default.aspx">首页</a>><h1>
                    个人日记</h1>
            </div>
        </div>
        <div class="rj_content">
            <asp:Repeater ID="RepRiJi" runat="server">
                <ItemTemplate>
            <!--时光-->
            <div class="shiguang animated bounceIn" style=" position:relative">
                <div class="left sg_ico">
                    <img src="images/my_1.jpg" width="120" height="120" alt="" />
                </div>
                <div class="right sg_text">
                    <img src="images/left.png" width="13" height="16" alt="左图标" />
                    <p><%#Eval("riJiText")%></p>
                    <p class="font" style=" position:absolute; bottom:10px; right:10px; color:#686666"> <%#Convert.ToDateTime(Eval("riJiDateTime")).ToString("yyyy/MM/dd HH:mm")%></p>
                </div>
                <div class="clear">
                </div>
            </div>
            <!--时光 end-->
             <script type="text/javascript">
                 $(function () {
                     $("#nav ul li").removeClass("nava");
                     $("#nav ul").find("#nav4").addClass("nava").find("a").css("color", "#fff");
                 })
                        
                    </script>
             </ItemTemplate>
            </asp:Repeater>         
        </div>
    </div>
</asp:Content>
