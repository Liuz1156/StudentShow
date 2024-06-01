<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="admin_StudentInfo"  Debug="true"%>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="css.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" class="admin_top">
    <tr><td>学生信息管理-<a href="StudentInfoAdd.aspx?action=Add" class="blue">添加学生信息</a></td></tr>
    <tr><td>按学生姓名筛选：<asp:TextBox ID="txtUserNameSearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearchByName" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearchByName_Click" />
                    </td></tr>
    <tr><td>按所属院系筛选：<asp:TextBox ID="txtUserXySearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearchByXy" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearchByXy_Click" />
                    &nbsp;
        <asp:Button ID="btnShowAll" runat="server" CssClass="txt" onclick="btnShowAll_Click" 
            Text="显示全部" />
                    </td></tr>
    </table> 
    <table width="98%" class="admin_top">
    <tr><td><asp:GridView ID ="gdvWishList" runat ="server" AutoGenerateColumns="False" 
                    Width="100%" onrowdatabound="gdvWishList_RowDataBound" >
                    <Columns>
                     <asp:TemplateField HeaderText="选择">
               
                <ItemTemplate>
                    <asp:CheckBox ID="ChkSelected"  runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
                        <asp:BoundField HeaderText="编号" ReadOnly="True" />
                        <asp:BoundField DataField="UserName" HeaderText="会员名" />
                        <asp:BoundField DataField="UserNumber" HeaderText="学号" />
                        <asp:BoundField DataField="UserPass" HeaderText="登录密码" />
                        <asp:BoundField DataField="UserSex" HeaderText="会员性别" />
<asp:BoundField DataField="UserXy" HeaderText="所属院系" />
                        <asp:BoundField DataField="UserZy" HeaderText="所学专业"></asp:BoundField>
                        <asp:BoundField DataField="UserBj" HeaderText="所属班级"></asp:BoundField>
                        <asp:BoundField DataField="UserAddTime" HeaderText="注册时间" />
                        <asp:TemplateField HeaderText="编辑"><ItemTemplate ><a href='StudentInfoAdd.aspx?id=<%#Eval("UserID") %>&action=Edit' title ="编辑" ><img src="images/user.gif" border="0px" /></a></ItemTemplate></asp:TemplateField>
                         <asp:TemplateField HeaderText="删除"><ItemTemplate ><a href='sqlDel.aspx?id=<%#Eval("UserID") %>&action=delStudent' title ="删除"   onclick="javascript:return confirm('确认删除吗？！')" ><img src="images/action_delete.gif" border="0px" /></a></ItemTemplate></asp:TemplateField>
                    </Columns>
               
                
                </asp:GridView></td></tr>
    <tr><td> <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="全选" 
                        oncheckedchanged="CheckBox1_CheckedChanged" />
&nbsp;
                    <asp:Button ID="btnDelete" runat="server" CssClass="txt" Text="删除"  OnClientClick="javascript:return confirm('确定删除吗？')"
                        onclick="btnDelete_Click" />
&nbsp;
                    <asp:Button ID="btnCancel" runat="server" CssClass="txt" Text="取消" 
                        onclick="btnCancel_Click" />&nbsp;</td></tr>
    </table> 
      <table width="98%" class="admin_top">
    <tr><td>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页" 
            NextPageText="下一页" onpagechanging="AspNetPager1_PageChanging" 
            PageIndexBoxType="DropDownList" PageSize="20" PrevPageText="上一页" 
            ShowMoreButtons="False" ShowPageIndexBox="Always" SubmitButtonText="Go" 
            TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到">
        </webdiyer:AspNetPager>
        </td></tr>
    </table> 
    </div>
    </form>
</body>
</html>
