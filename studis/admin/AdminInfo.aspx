<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminInfo.aspx.cs" Inherits="admin_AdminInfo" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            border: 1px solid #D6D6D6;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="98%" class="admin_top">
    <tr><td>管理员账号编辑--<a href ="admininfo.aspx?action=add" class="blue">添加管理员账号</a></td></tr>
    <tr><td>输入账号名称：<asp:TextBox ID="txtUserNameSearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
                    </td></tr>
    <tr><td>账号登录密码：<asp:TextBox ID="txtUserXySearch" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" CssClass="txt" Text="保存" 
            onclick="btnSave_Click" Width="66px" />
                    &nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" CssClass="txt" onclick="btnSubmit_Click" 
            Text="提交" />
                    </td></tr>
        
    </table> 
    <table width="98%" border="0" align="left" cellpadding="5" cellspacing="2" class="table-border">
  <tr>
    <td>
        <asp:Repeater ID="Repeater1" runat="server">
        
        <HeaderTemplate>
        
       <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
  <tr>
    <td bgcolor="#EEEED1"><div align="center" class="STYLE6">序号</div></td>
    <td bgcolor="#EEEED1"><div align="center" class="STYLE6">帐号名称</div></td>
    <td bgcolor="#EEEED1"><div align="center" class="STYLE6">登录密码</div></td>
    <td bgcolor="#EEEED1"><div align="center" class="STYLE6">修改</div></td>
    <td bgcolor="#EEEED1"><div align="center" class="STYLE6">删除</div></td>
  </tr>
  
</HeaderTemplate>

<ItemTemplate>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"><%# Container.ItemIndex + 1%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("AdminName")%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("AdminPass")%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='admininfo.aspx?id=<%#Eval("AdminID")%>&action=edit' class="blue"><img alt="Edit" src="images/edit.gif" border="0px" /></a></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='sqlDel.aspx?id=<%#Eval("AdminID") %>&action=delAdmin'><img alt="Delete" src="images/delete.gif" border="0px" /></a></div></td>
  </tr>
</ItemTemplate>
<FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
      </td>
  </tr>
  <tr>
    <td class="admin_top">&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
