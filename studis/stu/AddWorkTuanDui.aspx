<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="AddWorkTuanDui.aspx.cs" Inherits="stu_WorkTuanDui" Title="学生科技作品展示平台"  ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 27%;
        }
        .style2
        {
            width: 27%;
            height: 21px;
        }
        .style3
        {
            height: 21px;
            text-align: left;
        }
    </style>
     <link rel="stylesheet" href="../pfiles/themes/default/default.css" />
	<link rel="stylesheet" href="../pfiles/plugins/code/prettify.css" />
	<script charset="utf-8" src="../pfiles/kindeditor.js"></script>
	<script charset="utf-8" src="../pfiles/lang/zh_CN.js"></script>
	<script charset="utf-8" src="../pfiles/plugins/code/prettify.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script language="javascript"> 
    function Check_FileType() 
    { 
        var str=document.getElementById("FileUpload1").value; 
        var pos=str.lastIndexOf("."); 
        var lastname=str.substring(pos,str.length); 
        if(lastname.toLowerCase()!=".jpg"&&lastname.toLowerCase()!=".gif") 
        { 
            alert("您上传的文件类型为"+lastname+"，图片必须为.jpg,.gif类型"); 
            return false; 
        } 
        else 
        { 
            return true; 
        }         
    } 
    </script> 
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
    <td bgcolor="#FFFFFF" class="style2">作品图片</td>
    <td bgcolor="#FFFFFF" class="style3">
        <asp:FileUpload ID="FileUpload2" runat="server" CssClass="txt" />
&nbsp;<asp:Button ID="btnUploadPic" runat="server" CssClass="txt" onclick="btnUploadPic_Click" 
            Text="上传" />
                                    图片格式：JPG,GIF,PNG</td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">&nbsp;</td>
    <td bgcolor="#FFFFFF" style="text-align: left"><asp:TextBox ID="txtWorkPicUrl" 
            runat="server" CssClass="txt" Width="268px"></asp:TextBox>
        </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1"><div align="center">上传作品</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="txt" />
&nbsp;<asp:Button ID="btnUploadVideo" runat="server" CssClass="txt" onclick="btnUploadVideo_Click" 
            Text="上传" OnClientClick="return Check_FileType()"  />
&nbsp;<asp:Label ID ="Label1" runat ="server"></asp:Label></div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">&nbsp;</td>
    <td bgcolor="#FFFFFF" style="text-align: left"><asp:TextBox ID="txtWorkUrl" runat="server" CssClass="txt" Width="268px"></asp:TextBox>
        视频格式：mp4.</td>
  </tr>
  <tr>
    <td bgcolor="#EAEAEA" class="style1"><div align="center" class="STYLE4">团队成员（1）【团队组长】</div></td>
    <td bgcolor="#EAEAEA"><div align="left">
        <asp:TextBox ID="txtUser1" runat="server" CssClass="txt" ForeColor="Red" 
            ReadOnly="True" ToolTip="当前登录系统的学生姓名！！" Width="83px"></asp:TextBox>
        这里必须输入当前登录系统的学生姓名！！否则团队成员将看不到该团队作品。<br />
        <asp:Button ID="btnSearch3" runat="server" CssClass="txtbg" Text="查询" 
            onclick="btnSearch3_Click" />
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
&nbsp;<asp:Button ID="btnSearch1" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearch1_Click" />
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
&nbsp;<asp:Button ID="btnSearch2" runat="server" CssClass="txt" Text="查询" 
            onclick="btnSearch2_Click" />
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
    <td bgcolor="#FFFFFF" class="style1"><div align="center">整体作品描述</div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <%--<asp:TextBox ID="txtWorkDes" runat="server" CssClass="txt" ForeColor="Red" 
            Height="115px" TextMode="MultiLine" Width="498px"></asp:TextBox>--%>
            <textarea id="serverid" cols="100" rows="8" style="width:100%;height:400px;visibility:hidden;" runat="server"></textarea>
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
    <td bgcolor="#FFFFFF" class="style1"><div align="center"></div></td>
    <td bgcolor="#FFFFFF"><div align="left">
        <asp:Button ID="btnSubmit" runat="server" CssClass="txt" Text="提交" 
            onclick="btnSubmit_Click" />
        </div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" class="style1">&nbsp;</td>
    <td bgcolor="#FFFFFF">&gt;&gt;<a href ="javascript:history.back(-1)" class="blue">返回</a>&lt;&lt;&nbsp;</td>
  </tr>
</table>
</asp:Content>

