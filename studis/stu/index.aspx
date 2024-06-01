<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="stu_index" Title="学生科技作品展示平台" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        color: #FF0000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><table width="98%" border="0" cellspacing="2" cellpadding="5" style="line-height:25px; font-size:12px;">
  <tr>
    <td class="style1" style="text-align: left">使用须知：</td>
  </tr>
  <tr>
    <td class="style1" style="text-align: left">为了您更方便使用本系统，请仔细阅读以下注意事项！</td>
  </tr>
  <tr>
    <td style="text-align: left">1、学生得到管理员分配的学号及登录密码后，使用学号和密码登录本系统。<br />
        2、如学生作品属于个人性质，请点击左边--添加个人学生作品--;添加个人作品成功后，禁止添加团队学生作品！！<br />
        3、如学生作品属于团队性质，请点击左边--添加团队学生作品--；添加团队作品成功后，禁止添加个人学生作品！！<br />
        4、添加团队作品时，本系统默认团队成员为3人（即3人为一小组）；请小组成员沟通确定小组组长后，由组长登录本系统，添加团队作品。禁止非组长本人登录系统添加学生团队作品！！<br />
        5、添加团队作品时，小组成员请先输入学生姓名，查询当前小组各成员是否已被管理员分配账号，如若未分配，请联系管理员分配学号，否则小组成员将看不到自己的作品信息。<br />
        6、添加团队作品，请务必输入学生姓名然后点击查询当前输入的学生姓名UserID值（查询到结果后，系统会自动填充文本框，不需要手工再输入！！）。</td>
  </tr>
  <tr>
    <td style="text-align: left">&nbsp;</td>
  </tr>
</table>
</asp:Content>

