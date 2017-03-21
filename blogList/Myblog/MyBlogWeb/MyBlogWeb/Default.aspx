<%@ Page Title="首页" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MyBlogWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--left-->
    <div class="left" id="c_left">
        <div class="s_tuijian">
            <h2>
                文章<span>推荐</span></h2>
        </div>
        <div class="content_text">
            <asp:Repeater ID="RepContent" runat="server">
                <ItemTemplate>
                    <!--wz-->
                    <div class="wz">
                        <h3>
                            <a href='Detail.aspx?CaId=<%#Eval("id") %>' title='<%#Eval("title") %>'>
                                <%#Eval("title") %></a></h3>
                        <dl>
                            <dt>
                                <img src="images/s.jpg" width="200" height="123" alt=""></dt>
                            <dd>
                                <p class="dd_text_1">
                                    <%# StringTruncat(Eval("explain").ToString(), 119, "...")%></p>
                                <p class="dd_text_2">
                                    <span class="left author">
                                        <%#Eval("popName") %></span><span class="left sj">
                                            <%#Convert.ToDateTime(Eval("createTime")).ToString("yyyy-MM-dd")%></span>
                                    <span class="left fl">分类:<a href='Detail.aspx?CaId=<%#Eval("id") %>' title='<%#Eval("caName") %>'><%#Eval("caName") %></a></span><span
                                        class="left yd"><a href='Detail.aspx?CaId=<%#Eval("id") %>' title="阅读全文">阅读全文</a>
                                    </span>
                                    <div class="clear">
                                    </div>
                                </p>
                            </dd>
                            <div class="clear">
                            </div>
                        </dl>
                    </div>
                    <!--wz end-->
                    <script type="text/javascript">
                        $(function () {
                            $("#nav ul li").removeClass("nava");
                            $("#nav ul").find("#nav1").addClass("nava").find("a").css("color","#fff");
                        })
                        
                    </script>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!--left end-->
</asp:Content>
