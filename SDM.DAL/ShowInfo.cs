﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.Security;
namespace SDM.DAL
{
   public  class ShowInfo
    {
       public ShowInfo()
       { }
       #region 新版本
       /// <summary>
       /// 弹出JavaScript小窗口
       /// </summary>
       /// <param name="js">窗口信息</param>
       public static void Alert(string message, Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>
                    alert('" + message + "');</Script>";
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "alert"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "alert", js);
           }
           #endregion
       }

       /// <summary>
       /// 弹出消息框并且转向到新的URL
       /// </summary>
       /// <param name="message">消息内容</param>
       /// <param name="toURL">连接地址</param>
       public static void AlertAndRedirect(string message, string toURL, Page page)
       {
           #region
           string js = "<script language=javascript>alert('{0}');window.location.replace('{1}')</script>";
           //HttpContext.Current.Response.Write(string.Format(js, message, toURL));
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "AlertAndRedirect"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "AlertAndRedirect", string.Format(js, message, toURL));
           }
           #endregion
       }

       /// <summary>
       /// 回到历史页面
       /// </summary>
       /// <param name="value">-1/1</param>
       public static void GoHistory(int value, Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>
                    history.go({0});  
                  </Script>";
           //HttpContext.Current.Response.Write(string.Format(js, value));
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "GoHistory"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "GoHistory", string.Format(js, value));
           }
           #endregion
       }

       /// <summary>
       /// 刷新父窗口
       /// </summary>
       public static void RefreshParent(string url, Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>
                    window.opener.location.href='" + url + "';window.close();</Script>";
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshParent"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshParent", js);
           }
           #endregion
       }


       /// <summary>
       /// 刷新打开窗口
       /// </summary>
       public static void RefreshOpener(Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>
                    opener.location.reload();
                  </Script>";
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshOpener"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshOpener", js);
           }
           #endregion
       }


       /// <summary>
       /// 打开指定大小的新窗体
       /// </summary>
       /// <param name="url">地址</param>
       /// <param name="width">宽</param>
       /// <param name="heigth">高</param>
       /// <param name="top">头位置</param>
       /// <param name="left">左位置</param>
       public static void OpenWebFormSize(string url, int width, int heigth, int top, int left, Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>window.open('" + url + @"','','height=" + heigth + ",width=" + width + ",top=" + top + ",left=" + left + ",location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');</Script>";
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "OpenWebFormSize"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "OpenWebFormSize", js);
           }
           #endregion
       }


       /// <summary>
       /// 转向Url制定的页面
       /// </summary>
       /// <param name="url">连接地址</param>
       public static void JavaScriptLocationHref(string url, Page page)
       {
           #region
           string js = @"<Script language='JavaScript'>
                    window.location.replace('{0}');
                  </Script>";
           js = string.Format(js, url);
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "JavaScriptLocationHref"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "JavaScriptLocationHref", js);
           }
           #endregion
       }

       /// <summary>
       /// 打开指定大小位置的模式对话框
       /// </summary>
       /// <param name="webFormUrl">连接地址</param>
       /// <param name="width">宽</param>
       /// <param name="height">高</param>
       /// <param name="top">距离上位置</param>
       /// <param name="left">距离左位置</param>
       public static void ShowModalDialogWindow(string webFormUrl, int width, int height, int top, int left, Page page)
       {
           #region
           string features = "dialogWidth:" + width.ToString() + "px"
               + ";dialogHeight:" + height.ToString() + "px"
               + ";dialogLeft:" + left.ToString() + "px"
               + ";dialogTop:" + top.ToString() + "px"
               + ";center:yes;help=no;resizable:no;status:no;scroll=yes";
           ShowModalDialogWindow(webFormUrl, features, page);
           #endregion
       }
       /// <summary>
       /// 弹出模态窗口
       /// </summary>
       /// <param name="webFormUrl"></param>
       /// <param name="features"></param>
       /// <returns></returns>
       public static string ShowModalDialogJavascript(string webFormUrl, string features)
       {
           #region
           string js = @"<script language=javascript>                            
                            showModalDialog('" + webFormUrl + "','','" + features + "');</script>";
           return js;
           #endregion
       }
       /// <summary>
       /// 弹出模态窗口
       /// </summary>
       /// <param name="webFormUrl"></param>
       /// <param name="features"></param>
       public static void ShowModalDialogWindow(string webFormUrl, string features, Page page)
       {
           string js = ShowModalDialogJavascript(webFormUrl, features);
           //HttpContext.Current.Response.Write(js);
           if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "ShowModalDialogWindow"))
           {
               page.ClientScript.RegisterStartupScript(page.GetType(), "ShowModalDialogWindow", js);
           }
       }
       ///<summary>
       /// 说明：留言时按照标准形式显示留言格式；即格式化文本
       /// </summary>
       /// 
       public static string FormatString(string str)
       {
           str = str.Replace(" ", "&nbsp;&nbsp");//控制格式含数
           str = str.Replace("<", "&lt;");
           str = str.Replace(">", "&glt;");
           str = str.Replace('\n'.ToString(), "<br>");
           return str;
       }
       ///<!--MD5验证-->
       public static string Md5(string strText)
       {
           return FormsAuthentication.HashPasswordForStoringInConfigFile(strText.Trim(), "md5");
       }
       #endregion

    }
}
