<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorksInfo.aspx.cs" Inherits="admin_WorksInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
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
        if(lastname.toLowerCase()!=".jpg"&&lastname.toLowerCase()!=".gif") 
        { 
            alert("您上传的文件类型为"+lastname+"，只能上传：mp4格式！！"); 
            return false; 
        } 
        else 
        { 
            return true; 
        }         
    } 
    </script> 
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
 <table width="98%" class="admin_top">
    <tr><td>学生作品管理(类别：个人作品)</td></tr>
    </table> 
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#EEEED1" 
                class="table-border" style="height: 158px">
  <tr>
    <td colspan="2" bgcolor="#FFFFFF"><div align="center">学生作品编辑</div></td>
  </tr>
  <tr>
    <td width="17%" bgcolor="#FFFFFF"><div align="center">作品名称</div></td>
    <td width="83%" bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtWorkName" runat="server" CssClass="txt" Width="285px"></asp:TextBox>
        （*输入作品名称）</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">作品分类</div></td>
    <td bgcolor="#FFFFFF"><div align="left">个人作品</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">作品描述</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
      <%-- <asp:TextBox ID="txtWorkDes" runat="server" CssClass="txt" Height="116px" 
            TextMode="MultiLine" Width="562px"></asp:TextBox>--%><textarea id="content1" cols="100" rows="8" style="width:950px;height:400px;visibility:hidden;" runat="server"></textarea>
        
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">当前系统时间</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtWorkTime" runat="server" CssClass="txt" Width="141px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">上传作品</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="txt" Width="343px" />
&nbsp;<asp:Button ID="btnUploadVideo" runat="server" CssClass="txt" onclick="btnUploadVideo_Click" 
            Text="上传作品(视频)"  OnClientClick="return Check_FileType()"  />
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="txtWorkUrl" runat="server" CssClass="txt" Width="285px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">作品图片</td>
    <td bgcolor="#FFFFFF">
        <asp:FileUpload ID="FileUpload2" runat="server" CssClass="txt" Width="343px" />
&nbsp;<asp:Button ID="btnUploadPic" runat="server" CssClass="txt" onclick="btnUploadPic_Click" 
            Text="上传" />
        <asp:TextBox ID="txtWorkPicUrl" runat="server" CssClass="txt" Width="285px"></asp:TextBox>
                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">&nbsp;</td>
    <td bgcolor="#FFFFFF">
        <asp:Image ID="imgsrc" runat="server" Height="200px" Width="160px" />&nbsp;</td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">&nbsp;</td>
    <td bgcolor="#FFFFFF">&nbsp;</td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"></div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        </div></td>
  </tr>
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" style="text-align: center">
        <asp:Button ID="btnOk" runat="server" CssClass="txt" onclick="btnOk_Click" 
            Text="确定" />
&nbsp;<asp:Button ID="btnSave" runat="server" CssClass="txt" Text="保存" 
            onclick="btnSave_Click" />
      </td>
  </tr>
  <tr>
    <td colspan="2" bgcolor="#FFFFFF" class="admin_top">&gt;&gt;<a href ="javascript:history.back(-1)" class="blue">返回</a>&lt;&lt;</td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
