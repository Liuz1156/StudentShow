<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="WorkTuanDuiList.aspx.cs" Inherits="stu_WorkTuanDuiList" Title="学生科技作品展示平台" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 35px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="98%" border="0" align="left" cellpadding="5" cellspacing="2" class="table-border">
  <tr>
    <td class="admin_top">团队作品（仅限查看当前学生参与的作品）</td>
  </tr>
  <tr>
    <td class="style1"><asp:GridView ID ="gdvWishList" runat ="server" AutoGenerateColumns="False" 
                    Width="100%" onrowdatabound="gdvWishList_RowDataBound" >
                    <Columns>
                     <asp:TemplateField HeaderText="选择">
               
                <ItemTemplate>
                    <asp:CheckBox ID="ChkSelected"  runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
                        <asp:BoundField HeaderText="编号" ReadOnly="True" />
                        <asp:BoundField DataField="WorkName" HeaderText="作品名称" />
                        <asp:BoundField DataField="tdmc" HeaderText="团队名称" />
                        <asp:BoundField DataField="UserName" HeaderText="团队组长" />
                        <asp:BoundField DataField="WorkCate" HeaderText="作品分类" />
                        <asp:TemplateField HeaderText="作品描述"><ItemTemplate>
                       <a href="#"  title='<%#Eval("WorkDes")%>' class="blue"> <%#DAL.cutString (Eval("WorkDes").ToString (),20) %></a>
                        
                        </ItemTemplate></asp:TemplateField>
                        <asp:TemplateField HeaderText="文件下载">
                             <ItemTemplate>
                                <a href ='../admin/DownloadFile.aspx?id=<%#Eval("WorkID")%>&action=WorkTuanDui'  title="查看上传文件" class="blue">download</a>
                             </ItemTemplate>
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                             </EditItemTemplate>
                        </asp:TemplateField>
                         <asp:BoundField DataField="WorkTime" HeaderText="上传时间"></asp:BoundField>
<asp:TemplateField HeaderText="作品视频"><ItemTemplate><a href ='../PlayOnline.aspx?id=<%#Eval("WorkID")%>&action=WorkTuanDui'  title="播放作品视频"><img src="66.gif" border="0px" /></a></ItemTemplate></asp:TemplateField>
                       
                    <asp:TemplateField HeaderText="详细介绍"><ItemTemplate >
                            <a href='AddWorkTuanDui.aspx?id=<%#Eval("WorkID") %>&action=StuEdit'  class="blue"
                                title ="详细介绍" >详细介绍</a></ItemTemplate></asp:TemplateField>
                        
                    </Columns>
               
                
                </asp:GridView></td>
  </tr>
  <tr>
    <td class="style1">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页" 
            NextPageText="下一页" onpagechanging="AspNetPager1_PageChanging" 
            PageIndexBoxType="DropDownList" PrevPageText="上一页" ShowMoreButtons="False" 
            ShowPageIndexBox="Always" SubmitButtonText="Go" TextAfterPageIndexBox="页" 
            TextBeforePageIndexBox="转到">
        </webdiyer:AspNetPager>
      </td>
  </tr>
  <tr>
    <td class="admin_top">&nbsp;</td>
  </tr>
</table>
</asp:Content>

