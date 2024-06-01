<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlayOnline.aspx.cs" Inherits="stu_mp4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生科技作品展示平台</title>
     <link rel="stylesheet" type="text/css"
      href="//releases.flowplayer.org/5.5.2/skin/minimalist.css"/>
   
   
   <style>
   /* site specific styling */
   body {
      font: 12px "Myriad Pro", "Lucida Grande", "Helvetica Neue", sans-serif;
      text-align: center;
      padding-top: 1%;
      color: #999;
      background-color: #333333;
   }

   /* custom player skin */
   .flowplayer { width: 80%; background-color: #222; background-size: cover; max-width: 800px; }
   .flowplayer .fp-controls { background-color: rgba(0, 0, 0, 0.4)}
   .flowplayer .fp-timeline { background-color: rgba(0, 0, 0, 0.5)}
   .flowplayer .fp-progress { background-color: rgba(219, 0, 0, 1)}
   .flowplayer .fp-buffer { background-color: rgba(249, 249, 249, 1)}
   .flowplayer { background-image: url(https://farm4.staticflickr.com/3169/2972817861_73ae53c2e5_b.jpg)}

   </style>

   <!-- flowplayer depends on jQuery 1.7.2+ -->
   <script src="//code.jquery.com/jquery-1.10.2.min.js"></script>

   <!-- flowplayer javascript component -->
   <script src="//releases.flowplayer.org/5.5.2/flowplayer.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>网上视频播放系统 <a href="javascript:history.back(-1)" class="blue" target="main">>>返回首页<<</a></p>

   <div data-swf="//releases.flowplayer.org/5.5.2/flowplayer.swf"
      class="flowplayer no-toggle"
       data-ratio="0.416">
      <video loop="loop">
        <%-- <source type="video/webm" src="http://stream.flowplayer.org/bauhaus.webm">
<source type="video/mp4" src='<%=strsql %>'>--%>
<asp:Literal ID="LiteralSource" runat ="server"></asp:Literal>
      </video>
    </div>
    </form>
</body>
</html>