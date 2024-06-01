<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorkTuanDui.aspx.cs" Inherits="admin_WorkTuanDui" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            background-color: #EEEED1;
            font-size: 12px;
            line-height: 25px;
            border: 1px solid #CBD8AC;
            width: 1705px;
        }
        .auto-style2 {
            width: 1705px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" align="left" cellpadding="5" cellspacing="2" class="table-border">
  <tr>
    <td class="auto-style1">团队作品管理</td>
  </tr>
  <tr>
    <td class="auto-style2"><asp:Repeater  ID="rpTuanDui" runat ="server"><HeaderTemplate><table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
 <tr>
    <td width="4%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">序号</div>
    </div></td>
    <td width="14%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">作品名称</div>
    </div></td>
    <td width="8%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">作品分类</div>
    </div></td>
    <td width="7%" bgcolor="#EEEED1"><div align="center">团队组长</div></td>
    <td width="15%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">上传时间</div>
    </div></td>
    <td width="6%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">上传人</div>
    </div></td>
    <td width="19%" bgcolor="#EEEED1"><div align="center">系统描述</div></td>
    <td width="13%" bgcolor="#EEEED1"><div align="center">查看文件</div></td>
    <td width="5%" bgcolor="#EEEED1"><div align="center"><span class="STYLE6">修改</span></div></td>
    <td width="4%" bgcolor="#EEEED1"><div align="center"><span class="STYLE6">删除</span></div></td>
  </tr></HeaderTemplate>
  
  <ItemTemplate><tr>
    <td bgcolor="#FFFFFF"><div align="center"><%# Container.ItemIndex + 1%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkName") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkCate") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("UserName") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkTime") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("UserName") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ="#"  class="blue"><%#DAL.cutString (Eval("WorkDes").ToString (),20)%></a></div></td>
     <td bgcolor="#FFFFFF"><div align="center"><a href ='CheckFiles.aspx?id=<%#Eval("WorkID")%>&action=WorkTuanDui' class="blue">查看文件</a></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='WorkTuanDuiInfo.aspx?id=<%#Eval("WorkID")%>&action=AdminEdit' class="blue" ></a><img alt="修改" src="images/edit.gif" border="0px"></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='sqldel.aspx?id=<%#Eval("WorkID")%>&action=delWorkTuanDui' class="blue"><img src="images/delete.gif" border="0px"></a></div></td>
  </tr></ItemTemplate>
  <FooterTemplate></table></FooterTemplate>
  </asp:Repeater>
  
</td>
  </tr>
  <tr>
    <td class="auto-style2">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" 
            CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页，每页%PageSize%条" 
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
            ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowPageIndexBox="Always" 
            SubmitButtonText="Go" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到">
        </webdiyer:AspNetPager>
      </td>
  </tr>
  <tr>
    <td class="auto-style1">&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
