<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorkPerson.aspx.cs" Inherits="admin_WorkPerson" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <link href="css.css" type="text/css" rel="Stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 194px;
            width: 973px;
        }
        .auto-style2 {
            background-color: #EEEED1;
            font-size: 12px;
            line-height: 25px;
            border: 1px solid #CBD8AC;
            width: 973px;
        }
        .auto-style3 {
            width: 973px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" align="left" cellpadding="5" cellspacing="2" class="table-border">
  <tr>
    <td class="auto-style2">个人作品管理</td>
  </tr>
  <tr>
    <td class="auto-style1"><asp:Repeater ID ="rpWorkPerson"  runat="server" >
    <HeaderTemplate>
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
  <tr>
    <td width="8%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">序号</div>
    </div></td>
    <td width="21%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">作品名称</div>
    </div></td>
    <td width="15%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">作品分类</div>
    </div></td>
    <td width="13%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">上传时间</div>
    </div></td>
    <td width="17%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">视频播放源</div>
    </div></td>
    <td width="17%" bgcolor="#EEEED1"><div align="center" class="STYLE6">
      <div align="center">查看文件</div>
    </div></td>
    <td width="10%" bgcolor="#EEEED1"><div align="center">上传人</div></td>
    <td width="8%" bgcolor="#EEEED1"><div align="center"><span class="STYLE6">修改</span></div></td>
    <td width="8%" bgcolor="#EEEED1"><div align="center"><span class="STYLE6">删除</span></div></td>
  </tr>
  

    </HeaderTemplate>
    
    <ItemTemplate>
    <tr>
    <td bgcolor="#FFFFFF"><div align="center"><%# Container.ItemIndex + 1%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkName") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkCate")%></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkTime") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("WorkUrl") %></div></td>
   <td bgcolor="#FFFFFF"><div align="center"><a href ='CheckFiles.aspx?id=<%#Eval("WorkID")%>&action=WorkPerson' class="blue">查看文件</a></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><%#Eval("UserName") %></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='WorksInfo.aspx?id=<%#Eval("WorkID") %>&action=AdminEdit' ><img alt="修改" src="images/edit.gif" border="0px"></div></td>
    <td bgcolor="#FFFFFF"><div align="center"><a href ='sqldel.aspx?id=<%#Eval("WorkID") %>&action=delWorkPerson'  onclick="javascript:return confirm('确认删除吗！")'><img src="images/delete.gif" border="0px"></a></div></td>
  </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater></td>
  </tr>
  <tr>
    <td class="auto-style3">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页" 
            NextPageText="下一页" PrevPageText="上一页" ShowCustomInfoSection="Left" 
            ShowMoreButtons="False" ShowPageIndexBox="Always" SubmitButtonText="Go" 
            TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" 
            onpagechanging="AspNetPager1_PageChanging">
        </webdiyer:AspNetPager>
      </td>
  </tr>
  <tr>
    <td class="auto-style2">&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
