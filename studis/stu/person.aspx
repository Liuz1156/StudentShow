<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="Person.aspx.cs" Inherits="stu_person" Title="学生科技作品展示平台" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="650" border="0" cellspacing="2" cellpadding="5" style="line-height:25px; font-size:12px;">
  <tr>
    <td colspan="2"><div align="center" class="admin_top">查看当前学生信息</div>      <div align="left"></div></td>
  </tr>
  <tr>
    <td width="145"><div align="center">学生姓名</div></td>
    <td width="479"><div align="left">
        <asp:TextBox ID="txtUserName" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">性别</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtUserSex" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">学生学号</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtUserNumber" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">登录密码</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtUserPass" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">所属院系</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtXy" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">所属专业</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtZy" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">所属班级</div></td>
    <td><div align="left">
        <asp:TextBox ID="txtBj" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center">注册时间</div></td>
    <td><div align="left" style="font-weight: 700">
        <asp:TextBox ID="txtTime" runat="server" CssClass="txt"></asp:TextBox>
        </div></td>
  </tr>
  <tr>
    <td><div align="center"></div></td>
    <td><div align="left">
        <asp:Button ID="btnAlter" runat="server" CssClass="txt" onclick="btnAlter_Click" 
            Text="修改" />
        </div></td>
  </tr>
</table>
</asp:Content>

