<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckFiles.aspx.cs" Inherits="admin_CheckFiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>友情提醒</title>
    <link href ="css.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="admin_top" align="center" style="text-align:center;"><p>友情提醒</p>
    <p><asp:Label ID ="PlayOnline" runat ="server" ></asp:Label><br />
       <asp:Label ID ="Download" runat ="server" ></asp:Label><br />
    <a href="javascript:history.back(-1)" class="blue" target="main">>>返回首页<<</a>
    </p>
    </div>
    </form>
</body>
</html>
