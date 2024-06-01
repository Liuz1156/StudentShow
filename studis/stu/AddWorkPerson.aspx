<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="AddWorkPerson.aspx.cs" Inherits="stu_WorkPerson" Title="学生科技作品展示平台"  ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../pfiles/themes/default/default.css" />
	<link rel="stylesheet" href="../pfiles/plugins/code/prettify.css" />
	<script type="text/javascript" charset="utf-8" src="../pfiles/kindeditor.js"></script>
	<script type="text/javascript" charset="utf-8" src="../pfiles/lang/zh_CN.js"></script>
	<script type="text/javascript" charset="utf-8" src="../pfiles/plugins/code/prettify.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
	
    <script type="text/javascript" language="javascript"> 
    function Check_FileType() 
    { 
        var str=document.getElementById("FileUpload2").value; 
        var pos=str.lastIndexOf("."); 
        var lastname=str.substring(pos,str.length); 
        if(lastname.toLowerCase()!=".jpg"&&lastname.toLowerCase()!=".gif") 
        { 
            alert("您上传的文件类型为"+lastname+"，图片必须为.mp4类型"); 
            return false; 
        } 
        else 
        { 
            return true; 
        }         
    } 
    </script> 
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
    <td bgcolor="#FFFFFF"><div align="left"><%--<asp:TextBox ID="txtWorkDes" 
            runat="server" CssClass="txt" Width="419px" Height="152px" 
            TextMode="MultiLine"></asp:TextBox>--%><textarea id="serverid" cols="100" rows="8" style="width:100%;height:400px;visibility:hidden;" runat="server"></textarea>
            <script>
		KindEditor.ready(function(K) {
			var editor1 = K.create('##ctl00_ContentPlaceHolder1_serverid', {
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
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">当前系统时间</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:TextBox ID="txtWorkTime" runat="server" CssClass="txt" Width="141px"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center">上传视频文件</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="txt" Width="343px" />
&nbsp;<asp:Button ID="btnUploadVideo" runat="server" CssClass="txt" onclick="btnUploadVideo_Click" 
            Text="上传文件"  OnClientClick="return Check_FileType()"  />
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF"><div align="center"></div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        视频文件格式为：mp4.</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">&nbsp;</td>
    <td bgcolor="#FFFFFF" style="text-align: left">
        <asp:TextBox ID="txtWorkUrl" 
            runat="server" CssClass="txt" Width="419px"></asp:TextBox>
                                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">作品图片</td>
    <td bgcolor="#FFFFFF" style="text-align: left">
        <asp:FileUpload ID="FileUpload2" runat="server" CssClass="txt" Width="343px" />
        <asp:Button ID="btnUploadPic" runat="server" CssClass="txt" onclick="btnUploadPic_Click" 
            Text="上传" /> 图片格式：png,jpg，gif.
                                    </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF">&nbsp;</td>
    <td bgcolor="#FFFFFF" style="text-align: left">
        <asp:TextBox ID="txtWorkPicUrl" 
            runat="server" CssClass="txt" Width="419px"></asp:TextBox>
                                    </td>
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
</asp:Content>

