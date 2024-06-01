<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Register src="inc/top.ascx" tagname="top" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生科技作品展示平台</title>
</head>
<body style="background-color:#CEEDCC;font-size:12px;">
    <form id="form1" runat="server">
    <%--<div>
    
        <uc1:top ID="top1" runat="server" />
    <table width="980px" height="400px" align="center">
    <tr><td align="center">
   <a href ="admin/login.aspx" title ="管理员登录"> <img src="images/1.gif" border="0px"/></a>
     <a href ="stu/login.aspx" title ="学生登录"> <img src="images/2.gif" border="0px"/></a>
       </td></tr>
    </table>
     <table width="980px" align="center">
    <tr><td align="center">
    </td></tr>
    </table>
    </div>--%>
	<div align="center"><img src="images/tp.gif" border="0" usemap="#Map" />
<map name="Map" id="Map"><area shape="rect" coords="448,186,633,244" href="admin/login.aspx" alt="管理员登录" />
<area shape="rect" coords="450,248,631,297" href="stu/login.aspx" alt="学生登录" />
</map>
</div>
    </form>
</body>
</html>
