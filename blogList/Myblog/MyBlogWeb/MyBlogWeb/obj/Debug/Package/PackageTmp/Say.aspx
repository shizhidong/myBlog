<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Say.aspx.cs" Inherits="MyBlogWeb.Say" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>岁言碎语</title>
    <link rel="stylesheet" href="css/index.css" />
    <link rel="stylesheet" href="css/style.css" />
    <script type="text/javascript" src="js/jquery1.42.min.js"></script>
    <script type="text/javascript" src="js/jquery.SuperSlide.2.1.1.js"></script>
</head>
<body>
    <!--header start-->
    <div id="header">
        <h1>
            个人博客</h1>
        <p>
            <asp:Label ID="lblMy" runat="server" Text=""></asp:Label></p>
        <div id="nav">
            <ul>
                <li id="nav1"><a href="default.aspx">首页</a></li>
                <li id="nav2"><a href="about.aspx">关于我</a></li>
                <li id="nav3"><a href="Say.aspx">碎言碎语</a></li>
                <li id="nav4"><a href="RiJi.aspx">个人日记</a></li>
           <!--<li id="nav5"><a href="javascript:void(0)">相册展示</a></li>
         <li id="nav6"><a href="javascript:void(0)">学无止境</a></li>
         <li><a href="Resume.aspx">个人简历</a></li>-->
                <div class="clear">
                </div>
            </ul>
        </div>
    </div>
    <!--header end-->
    <!--content start-->
    <div id="say">
        <div class="weizi">
            <div class="wz_text">
                当前位置：<a href="Default.aspx">首页</a>><h1>
                    碎言碎语</h1>
            </div>
        </div>
        <asp:Repeater ID="RepSay" runat="server">
            <ItemTemplate>
                <ul class="say_box">
                    <div class="sy">
                        <p>
                            <%#Eval("sayCont")%></p>
                    </div>
                    <span class="dateview">
                        <%#Convert.ToDateTime(Eval("createTime")).ToString("yyyy/MM/dd HH:mm")%>
                        </span>
                </ul>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <!--content end-->
    <!--footer-->
    <div id="footer">
        <p>
            向前看少年</p>
    </div>
    <!--footer end-->
    <script type="text/javascript">


        jQuery(".lanmubox").slide({ easing: "easeOutBounce", delayTime: 400 });

        $(function () {
            $("#nav ul li").removeClass("nava");
            $("#nav ul").find("#nav3").addClass("nava").find("a").css("color", "#fff");
        })
    </script>
</body>
</html>
