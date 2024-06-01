<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="stu_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生科技作品展示平台-学生登录</title>
    <link href="css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="401" border="0" cellspacing="5" cellpadding="5" align="center" style="line-height:25px; font-size:12px;">
  <tr>
    <td colspan="2" class="admin_top STYLE3">学生登录</td>
  </tr>
  <tr>
    <td width="98"><div align="center">登录账号</div></td>
    <td width="268"><div align="left">
        <asp:TextBox ID="txtXueHao" runat="server" CssClass="txt"></asp:TextBox>
        &nbsp;*</div></td>
  </tr>
  <tr>
    <td><div align="center">登录密码</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtPwd" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
        &nbsp;*</div></td>
  </tr>
  <tr>
    <td colspan="2" class="admin_top">
        <asp:Button ID="Button1" runat="server" CssClass="txt" Text="登录" 
            onclick="Button1_Click" />
        &nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="txt" Text="取消" 
            onclick="Button2_Click" />
      </td>
  </tr>
  <tr>
    <td colspan="2">**备注:登录账号即为学生学号.**</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
