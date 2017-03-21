<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resume.aspx.cs" Inherits="MyBlogWeb.Resume" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>我的简历</title>
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
                <!--<li id="nav4"><a href="RiJi.aspx">个人日记</a></li>-->
                <li id="nav5"><a href="guestbook.aspx">留言</a></li>
                <!--<li><a href="xc.html">相册展示</a></li>
                <li><a href="learn.html">学无止境</a></li>
                <li><a href="Resume.aspx">个人简历</a></li>-->
                <div class="clear">
                </div>
            </ul>
        </div>
    </div>
    <!--header end-->
    <!--content start-->
    <div id="say">
        <!--开始-->
<div class="resume">
   <div class="resume_r">
    <div>
        <h3>基本信息</h3>
        <div class="jbxx">
             <ul>
                <li>姓名：史志东</li>
                <li>年龄：29岁</li>
                <li>学历：大专</li>
                <li>出生日期：1985年10月13日</li>
                <li>居住地：上海</li>
                <li>工作年限：5年</li>
                <li>电子邮件：shizhidongadmin@163.com</li>
                <li>手机：13641880567</li>
                <li>户口：徐州.丰县</li>
                <li>婚姻：已婚</li>
                <div style="clear:both"></div>
                <p class="address">现居住地址：浦东新区</p>
             </ul>
        </div>
        <div class="pic"><img src="images/pic.jpg"/></div>
        <div style="clear:both"></div>
        <h3>自我评价</h3>
        <p class="set">擅长:ASP.NET(C#), MsSqlServer ,DIV+CSS,XHTML,AJAX, XML,c# 熟悉: JavaScript,,jQuery 具有良好的心理，职业素质，具有开朗乐观积极的人生观，不畏挫折；爱岗敬业，对工作认真细心负责，个性温和，出色的独立工作能力，非常注重团队精神，有一定的的团队协作能力，较强的沟通能力。“活到老，学到老”是我深信不移的法则，不断学习，充实自己。</p>
        <p class="work_fgx"></p>
        </div>
        <div>
	        <h3>工作经验</h3>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
        </div>
          
        <!-- 2 -->
         <div>
            <p class="work_fgx"></p>
	        <h3>工作经验1</h3>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
        </div>
        <div>
            <p class="work_fgx"></p>
	        <h3>工作经验2</h3>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
	        <p class="work_fgx"></p>
	        <p class="set">2011/5--至今：上海明昊信息技术有限公司（150-500人）</p>
	        <p class="set">所属行业：计算机软件</p>
	        <p class="set">技术部：设计+前端制作 </p>
	        <p class="set">2011年5月由明昊公司外包到天翼视讯做设计和前端开发工作。在2012年初调回公司担任公司承接的项目《音乐频道》的设计和开发工作。</p>
        </div>
         <div>
         <p class="work_fgx"></p>
         <h3>教育经历</h3>
         <p class="set"><span>2000/6 -- 2003/6</span><span class="le">湖南师范大学</span><span class="le">计算机</span><span class="le">本科</span></p>
         <h3>培训经历</h3>
         <p class="set"><span>2009/4 -- 2010/4</span><span class="le">北大青鸟</span><span class="le">软件工程师</span><span class="le">软件工程师证书</span></p>
         <p class="set"><span>培训项目：</span><span class="le">asp.net</span><span class="le">java</span><span class="le">c#</span><span class="le">sqlserver</span></p>
         <h3>其它信息</h3>
          <p class="set">熟悉ASP.NET；熟悉数据库触发器、储存过程、AJAX、JS、正则表达式,CSS+div布局和风格套用，熟悉Dreamweaver、Visual Studio、Photoshop等网页相关软件。能独完成中型网站全过程，包括前后台以及数据库的设计，能制作论坛、产品管理、流量统计分析等系统。能结合JS与CSS样式表轻松完成整个网站的风格转换。 兴趣/爱好：听音乐、打羽毛球</p>
   </div>
   </div>
   <div class="download"><a href="#"><img src="images/download.jpg"/></a></div>
</div>
         
     </div>
    <!--content end-->

</body>
</html>
