<%@ Page Title="更多" Language="C#" MasterPageFile="~/BlogRight.Master" AutoEventWireup="true"
    CodeBehind="More.aspx.cs" Inherits="MyBlogWeb.More" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--left-->
    <div class="left" id="c_left">
        <div class="content_text">
            <asp:Repeater ID="repMore" runat="server">
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
                                        <%#Eval("popName") %></span><span class="left sj">时间:<%#Eval("createTime") %></span>
                                    <span class="left fl">分类:<a href="#" title="学无止境"><%#Eval("caName") %></a></span><span
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
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!--left end-->
</asp:Content>
