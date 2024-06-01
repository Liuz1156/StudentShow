using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
public partial class admin_CheckFiles : System.Web.UI.Page
{
    public string MediaUrl = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
            int strid = int.Parse(Request.QueryString["id"]);
            string action = Request.QueryString["action"].ToString();
            MediaUrl = "../" + bll.GetModel(strid).WorkUrl.ToString();
            PlayOnline.Text = "您要查看的是作品视频<br/>" + "<a href='PlayOnline.aspx?id=" + strid + "&action=" + action + "' class='blue'>>>点击这里在线观看作品视频<<</a></br>";

            Download.Text = "如果您需要下载该作品视频<br/>" + "<a href='DownloadFile.aspx?id=" + strid + "&action=" + action + "' class='blue'>>>点击这里下载作品视频<<</a>";
        }

    }
}