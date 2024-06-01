<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorkTuanDuiInfo.aspx.cs" Inherits="admin_WorkTuanDuiInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生科技作品展示平台</title>
     <link href="css.css" type="text/css" rel="Stylesheet" />
      <link rel="stylesheet" href="../pfiles/themes/default/default.css" />
	<link rel="stylesheet" href="../pfiles/plugins/code/prettify.css" />
	<script charset="utf-8" src="../pfiles/kindeditor.js"></script>
	<script charset="utf-8" src="../pfiles/lang/zh_CN.js"></script>
	<script charset="utf-8" src="../pfiles/plugins/code/prettify.js"></script>
	<script>
		KindEditor.ready(function(K) {
			var editor1 = K.create('#content1', {
				cssPath : '../pfiles/plugins/code/prettify.css',
				uploadJson : '../pfiles/asp.net/upload_json.ashx',
				fileManagerJson : '../pfiles/asp.net/file_manager_json.ashx',
				allowFileManager : true,
				afterCreate : function() {
					var self = this;
					K.ctrl(document, 13, function() {
						self.sync();
						K('form[name=example]')[0].submit();
					});
					K.ctrl(self.edit.doc, 13, function() {
						self.sync();
						K('form[name=example]')[0].submit();
					});
				}
			});
			prettyPrint();
		});
	</script>
    <script language="javascript"> 
    function Check_FileType() 
    { 
        var str=document.getElementById("FileUpload1").value; 
        var pos=str.lastIndexOf("."); 
        var lastname=str.substring(pos,str.length); 
        if(lastname.toLowerCase()!=".mp4") 
        { 
            alert("您上传的文件类型为"+lastname+"，必须为mp4格式"); 
            return false; 
        } 
        else 
        { 
            return true; 
        }         
    } 
    </script> 
    <style type="text/css">
        .auto-style1 {
            height: 90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#EEEED1" style="line-height:25px; font-size:12px;">
  <tr>
    <td colspan="2" bgcolor="#FFFFFF"><div align="center">团队学生作品编辑</div></td>
  </tr>
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" style="text-align: left">操作说明：团队作品请首先以团队组长身份登录当前系统。<br />
        团队组长为当前登录系统的学生姓名。</td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">作品名称</div></td>
    <td width="83%" bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtWorkName" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">作品分类</div></td>
    <td bgcolor="#FFFFFF"><div align="left">团队作品</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">团队名称</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txttdmc" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">当前系统时间</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtTime" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">上传作品</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="txt" />
&nbsp;<asp:Button ID="Button1" runat="server" CssClass="txt" onclick="Button1_Click" 
            Text="上传" OnClientClick="return Check_FileType()"  />
&nbsp;<asp:TextBox ID="txtWorkUrl" runat="server" CssClass="txt" Width="268px"></asp:TextBox>
        <asp:Label ID ="Label1" runat ="server"></asp:Label></div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">作品图片</td>
    <td bgcolor="#FFFFFF">
        <asp:FileUpload ID="FileUpload2" runat="server" CssClass="txt" />
&nbsp;<asp:Button ID="Button6" runat="server" CssClass="txt" onclick="Button6_Click" 
            Text="上传" />
&nbsp;<asp:TextBox ID="txtWorkPicUrl" runat="server" CssClass="txt" Width="268px"></asp:TextBox>
                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">&nbsp;</td>
    <td bgcolor="#FFFFFF">
        <asp:Image ID="imgsrc" runat ="server"  Height="200px" Width="160px"  />&nbsp;</td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">团队成员（1）【团队组长】</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser1" runat="server" CssClass="txt" ForeColor="Red" 
            ReadOnly="True" ToolTip="当前登录系统的学生姓名！！" Width="83px"></asp:TextBox>
        这里必须输入当前登录系统的学生姓名！！否则团队成员将看不到该团队作品。<br />
        <asp:Button ID="Button2" runat="server" CssClass="txtbg" Text="查询" 
            onclick="Button2_Click" />
        <asp:TextBox ID="txtUser1ID" runat="server" CssClass="txt" ForeColor="Red" 
            Width="36px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">该成员负责模块介绍（1）</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser1Des" runat="server" CssClass="txt" Height="95px" 
            TextMode="MultiLine" Width="499px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">团队成员（2）</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser2" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" CssClass="txt" Text="查询" 
            onclick="Button3_Click" />
        <asp:TextBox ID="txtUser2ID" runat="server" CssClass="txt" ForeColor="Red" 
            Width="36px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">该成员负责模块介绍（2）</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser2Des" runat="server" CssClass="txt" ForeColor="Red" 
            Height="120px" TextMode="MultiLine" Width="499px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">团队成员（3）</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser3" runat="server" CssClass="txt"></asp:TextBox>
&nbsp;<asp:Button ID="Button4" runat="server" CssClass="txt" Text="查询" 
            onclick="Button4_Click" />
&nbsp;<asp:TextBox ID="txtUser3ID" runat="server" CssClass="txt" ForeColor="Red" 
            Width="36px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">该成员负责模块介绍（3）</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser3Des" runat="server" CssClass="txt" ForeColor="Red" 
            Height="115px" TextMode="MultiLine" Width="498px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="center">整体作品描述</div></td>
    <td bgcolor="#FFFFFF" class="auto-style1"><div align="left">
     <%--   <asp:TextBox ID="txtWorkDes" runat="server" CssClass="txt" ForeColor="Red" 
            Height="115px" TextMode="MultiLine" Width="498px"></asp:TextBox>--%>
             <textarea id="content1" cols="100" rows="8" style="width:950px;height:400px;visibility:hidden;" runat="server"></textarea>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center"></div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:Button ID="Button5" runat="server" CssClass="txt" Text="修改" 
            onclick="Button5_Click" />
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">&nbsp;</td>
    <td bgcolor="#FFFFFF">&gt;&gt;<a href ="javascript:history.back(-1)" class="blue">返回</a>&lt;&lt;&nbsp;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
