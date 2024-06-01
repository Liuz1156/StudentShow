<%@ Page Language="C#" MasterPageFile="~/stu/MasterPage.master" AutoEventWireup="true" CodeFile="WorkPersonList.aspx.cs" Inherits="stu_AddWorkPersonList" Title="学生科技作品展示平台"  Debug="true"%>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" border="0" cellspacing="2" cellpadding="5" style="line-height:25px; font-size:12px;">
    <tr>
    <td><asp:GridView ID ="gdvWishList" runat ="server" AutoGenerateColumns="False" 
                    Width="100%" onrowdatabound="gdvWishList_RowDataBound" >
                    <Columns>
                     <asp:TemplateField HeaderText="选择">
               
                <ItemTemplate>
                    <asp:CheckBox ID="ChkSelected"  runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
                        <asp:BoundField HeaderText="编号" ReadOnly="True" />
                        <asp:BoundField DataField="WorkName" HeaderText="作品名称" />
                        <asp:BoundField DataField="WorkCate" HeaderText="作品分类" />
                       <%-- <asp:BoundField DataField="WorkDes" HeaderText="作品描述" />--%>
                        <asp:TemplateField HeaderText="作品描述"><ItemTemplate>
                       <a href="#"  title='<%#Eval("WorkDes")%>' class="blue"> <%#DAL.cutString (Eval("WorkDes").ToString (),20) %></a>
                        
                        </ItemTemplate></asp:TemplateField>
                         <asp:TemplateField HeaderText="文件下载">
                             <ItemTemplate>
                                <a href ='../admin/DownloadFile.aspx?id=<%#Eval("WorkID")%>&action=WorkPerson'  title="下载上传文件" class="blue">download</a>
                             </ItemTemplate>
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                             </EditItemTemplate>
                        </asp:TemplateField>
                         <asp:BoundField DataField="WorkTime" HeaderText="上传时间"></asp:BoundField>
<asp:TemplateField HeaderText="作品视频"><ItemTemplate><a href ='../admin/PlayOnline.aspx?id=<%#Eval("WorkID")%>&action=WorkPerson'  title="播放作品视频"><img src="66.gif" border="0px" /></a></ItemTemplate></asp:TemplateField>
                       
                     <asp:TemplateField HeaderText="查看详细"><ItemTemplate >
                            <a href='AddWorkPerson.aspx?id=<%#Eval("WorkID") %>&action=StuEdit' 
                                title ="查看详细" >查看详细</a></ItemTemplate></asp:TemplateField>
                        
                    </Columns>
               
                
                </asp:GridView></td>
  </tr>
  <tr>
    <td>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" 
            CurrentPageButtonClass="cpb" FirstPageText="首页" LastPageText="尾页" 
            NextPageText="下一页" PageIndexBoxType="DropDownList" PrevPageText="上一页" 
            ShowMoreButtons="False" ShowPageIndexBox="Always" SubmitButtonText="Go" 
            TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" 
            onpagechanging="AspNetPager1_PageChanging">
        </webdiyer:AspNetPager>
      </td>
  </tr>
</table>
</asp:Content>

