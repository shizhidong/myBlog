<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MyBlogWeb.admin._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理</title>
    <script type="text/javascript" src="../js/jquery1.42.min.js"></script>
    <style type="text/css">
        .tabRiJi
        {
            width: 750px;
            height: auto;
            overflow: hidden;
            margin-bottom: 20px;
        }
        .tabRiJi tr th, .tabRiJi tr td
        {
            border: 1px solid #333;
            padding: 10px 0px;
            text-align: center;
            line-height: 24px;
            padding: 5px;
        }
    </style>
</head>
<body>
    <div style="width: 1030px; height: auto; overflow: hidden; margin: 0 auto">
        <div style="width: 200px; min-height: 400px; position: fixed; top: 8px; text-align: center;
            padding-top: 10px; overflow: hidden; border: 1px solid #212121; float: left">
            <p>
                <a href="#1F">关于我们(查询/修改)</a></p>
            <p>
                <a href="#2F">文章增加</a></p>
            <p>
                <a href="#3F">精心推荐</a></p>
            <p>
                <a href="#4F">个人日记</a></p>
            <p>
                <a href="#5F">碎言碎语</a></p>
            <p>
                <a href="#6F">留言</a></p>
        </div>
        <div style="width: 800px; height: auto; border: 1px solid #212121; padding-top: 10px;
            padding-left: 10px; padding-right: 10px; overflow: hidden; float: right">
            <form id="Form1" runat="server">
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px">
                <div>
                    <h4 id="1F">
                        关于我们(查询/修改)</h4>
                </div>
                <span style="display: inline-block; width: 100px; text-align: right">博主：</span><input
                    type="text" id="bozhu" value="" runat="server" /><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">职业：</span><input
                    type="text" id="zhiye" value="" runat="server" /><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">网站介绍：</span>
                <textarea id="aboutCode" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">简介：</span><textarea
                    id="jianjie" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">关于我：</span><textarea
                    id="guanyumy" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <div style="margin-left: 200px;">
                    <asp:Button ID="modify" runat="server" Text="修改" OnClick="modify_Click" /></div>
            </div>
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px;
                margin-top: 20px">
                <h4 id="2F">
                    文章增加</h4>
                <span style="display: inline-block; width: 100px; text-align: right">标题：</span><asp:TextBox
                    ID="TextBoxTitle" runat="server" Width="200" Height="20"></asp:TextBox><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">添加人：</span>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="150" Height="25">
                    <asp:ListItem Value="史漂亮">史漂亮</asp:ListItem>
                    <asp:ListItem Value="史不漂亮">史不漂亮</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">所属类别：</span>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="150" Height="25">
                    <asp:ListItem Value="css">css</asp:ListItem>
                    <asp:ListItem Value="js">js</asp:ListItem>
                    <asp:ListItem Value="html">html</asp:ListItem>
                    <asp:ListItem Value="asp">asp</asp:ListItem>
                    <asp:ListItem Value="其它">其它</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">说明：</span><textarea
                    id="TextareaExp" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">内容：</span>
                <textarea id="TextareaContent" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <div style="margin-left: 200px;">
                    <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" />
                </div>
            </div>
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px;
                margin-top: 20px">
                <h4 id="3F">
                    精心推荐</h4>
                <span style="display: inline-block; width: 100px; text-align: right">标题：</span><asp:TextBox
                    ID="TextJxTuijian" runat="server" Width="200" Height="20"></asp:TextBox><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">添加人：</span>
                <asp:DropDownList ID="DropJxTuiJian" runat="server" Width="150" Height="25">
                    <asp:ListItem Value="史漂亮">史漂亮</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">内容：</span>
                <textarea id="TxtJxTuijianTart" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <div style="margin-left: 200px;">
                    <asp:Button ID="Button1" runat="server" Text="添加" OnClick="btnAdd_ClickTuiJian" />
                </div>
            </div>
            <!--个人日记-->
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px;
                margin-top: 20px">
                <h4 id="4F">
                    个人日记</h4>
                <div style="height:400px; overflow-y:auto;">
                    <table cellpadding="0" cellspacing="0" class="tabRiJi">
                        <tr>
                            <th style="width: 50px">
                                id
                            </th>
                            <th style="width: 300px">
                                内容
                            </th>
                            <th style="width: 200px">
                                时间
                            </th>
                            <th style="width: 150px">
                                地址
                            </th>
                            <th style="width: 50px">
                                操作
                            </th>
                        </tr>
                        <asp:Repeater ID="RepRiJi" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td class="txId">
                                        <%#Eval("id")%>
                                    </td>
                                    <td class="tx">
                                        <%#Eval("riJiText")%>
                                    </td>
                                    <td>
                                    <%#Convert.ToDateTime(Eval("riJiDateTime")).ToString("yyyy-MM-dd HH:mm:ss")%>
                                   
                                    </td>
                                    <td class="tv">
                                        <%#Eval("riJiImgUrl")%>
                                    </td>
                                    <td>
                                        <a href="javascript:void(0)" onclick="modfiy(this)">修改</a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
                <span style="display: inline-block; width: 100px; text-align: right">id：</span><asp:TextBox
                    ID="TxtId" runat="server" Width="200" Height="20" onfocus="this.blur()" BackColor="#efefef"></asp:TextBox><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">图片地址：</span><asp:TextBox
                    ID="TxtUrl" runat="server" Width="200" Height="20"></asp:TextBox><br />
                <br />
                <span style="display: inline-block; width: 100px; text-align: right">日记内容：</span>
                <textarea id="TxtCont" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <br />
                <div style="margin-left: 200px;">
                    <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Btn_Click" />
                    <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Modify_Click" />
                    <asp:Button ID="Button5" runat="server" Text="删除" OnClick="Del_Click" />
                </div>
            </div>
            <!--碎言碎语-->
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px;
                margin-top: 20px">
                <h4 id="5F">
                    碎言碎语</h4>
                <span style="display: inline-block; width: 100px; text-align: right">内容：</span>
                <textarea id="TxtContText" cols="35" rows="6" runat="server" /></textarea><br />
                <br />
                <br />
                <div style="margin-left: 200px;">
                    <asp:Button ID="Button3" runat="server" Text="添加" OnClick="Button3_Click" /></div>
            </div>

             <!--留言-->
            <div style="border-bottom: 4px solid #000; overflow: hidden; padding-bottom: 30px;
                margin-top: 20px">
                <h4 id="6F">
                    留言</h4>
                     <table cellpadding="0" cellspacing="0" class="tabRiJi">
                    <tr>
                        <th style="width: 90px">
                            姓名
                        </th>
                        <th style="width: 90px">
                            电话
                        </th>
                        <th style="width: 400px">
                            内容
                        </th>
                        <th style="width: 170px">
                            时间
                        </th>
                    </tr>
                         <asp:Repeater ID="RepGuest" runat="server">
                            <ItemTemplate>
                            <tr>
                                <td><%#Eval("sayName")%></td>
                                <td><%#Eval("sayPhone")%></td>
                                <td><%#Eval("sayCont")%></td>
                                <td> <%#Convert.ToDateTime(Eval("sayDateTime")).ToString("yyyy-MM-dd HH:mm:ss")%></td>
                             </tr>
                            </ItemTemplate>
                         </asp:Repeater>
                </table>
            </div>

            </form>
        </div>
    </div>
    <script>
        //修改个人日记
        function modfiy(obj) {
            $("#TxtId").val($(obj).parent().parent().find(".txId").text());
            $("#TxtUrl").val($(obj).parent().parent().find(".tv").text());
            $("#TxtCont").text($(obj).parent().parent().find(".tx").text());

        }

    </script>
</body>
</html>
