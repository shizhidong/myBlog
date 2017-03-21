<%@ Page Title="留言板" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="guestbook.aspx.cs" Inherits="MyBlogWeb.guestbook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--left-->
    <div class="left" id="guestbook">
        <div class="weizi">
            <div class="wz_text">
                当前位置：<a href="#">首页</a>><h1>
                    留言板</h1>
            </div>
        </div>
        <div class="g_content">
            <h3>
                有什么想对我说的嘛？</h3>
        </div>
        <div>
            <p style="margin-left:30px; margin-bottom:10px;">加QQ：<span style="color:#8B1A1A; margin-right:5px; font-size:16px">59317748</span>或下方留言,也可在线交谈。</p>
            <div class="guestList">
                <span class="guestTitle">您的姓名：</span><span><asp:TextBox ID="TextName" Width="200"
                    Height="25" BorderColor="#d1cfcf" BorderWidth="1px" BorderStyle="Solid" runat="server"></asp:TextBox></span></div>
            <div class="guestList">
                <span class="guestTitle">您的电话：</span><span><asp:TextBox ID="TextPhone" Width="200"
                    Height="25" BorderColor="#d1cfcf" BorderWidth="1px" BorderStyle="Solid" runat="server"></asp:TextBox></span>
                    <asp:Label ID="lblVerfInfo" runat="server" Text="" CssClass="cosrgv"></asp:Label>
                    </div>
            
            <div class="guestList">
                <span class="guestTitle" style="float: left">您要说的：</span><span><textarea id="TextSay"
                    cols="55" rows="6" style="width: 500px; height: 200px; border: 1px solid #d1cfcf"
                    runat="server" /></textarea></span></div>
            <div style="margin-left:300px; margin-top:30px" >
                <asp:Button ID="btnAdd" runat="server" Text="提交" CssClass="btnGuest" 
                    onclick="btnAdd_Click" /></div>
        </div>
    </div>
    <!--end left -->
    <script type="text/javascript">

        jQuery(".lanmubox").slide({ easing: "easeOutBounce", delayTime: 400 });

        $(function () {
            $("#nav ul li").removeClass("nava");
            $("#nav ul").find("#nav5").addClass("nava").find("a").css("color", "#fff");
        })
    </script>
</asp:Content>

