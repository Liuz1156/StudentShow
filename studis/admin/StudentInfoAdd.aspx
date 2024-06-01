<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfoAdd.aspx.cs" Inherits="admin_StudentInfoAdd" %>

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
    <tr><td>添加学生信息-<a href="StudentInfo.aspx" class="blue">学生信息管理</a></td></tr>
    </table> 
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#EEEED1">
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" class="admin_top">学生信息编辑</td>
  </tr>
  <tr>
    <td width="169" bgcolor="#FFFFFF"><div align="center">学生姓名</div></td>
    <td width="811" bgcolor="#FFFFFF">
        <asp:TextBox ID="txtUserName" runat="server" CssClass="txt"></asp:TextBox>
                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">性别</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="txt">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">学号</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtUserNumber" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;<%--<asp:Button ID="btnCheck" runat="server" CssClass="txt" Text="检查是否重复" 
            onclick="btnCheck_Click" />--%>
&nbsp;</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">登录密码</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtUserPass" runat="server" CssClass="txt">123456</asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">所属学院(系别)</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtUserXy" runat="server" CssClass="txt" Width="167px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">所学专业</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtUserZy" runat="server" CssClass="txt" Width="166px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">所属班级</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtUserBj" runat="server" CssClass="txt" Width="165px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">当前系统时间：</td>
    <td bgcolor="#FFFFFF">
        <asp:TextBox ID="txtUserAddTime" runat="server" CssClass="txt" Width="165px"></asp:TextBox>
                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"></div></td>
    <td bgcolor="#FFFFFF">
        <asp:Button ID="btnOk" runat="server" CssClass="txt" Text="确定" 
            onclick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" CssClass="txt" Text="保存" 
            onclick="btnSave_Click" />
&nbsp;
        </td>
  </tr>
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" class="admin_top STYLE2">说明：为了系统便于统一管理，请按照学校相关规定，对学院名称、专业名称、班级名称统一编排。<br />
        系统默认学生登录密码：123456。学生登录系统后，请自行修改默认登录密码！</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
