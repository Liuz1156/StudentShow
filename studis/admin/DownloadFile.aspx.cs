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

public partial class admin_DownloadFile : System.Web.UI.Page
{
    public string MediaUrl = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (Request.QueryString["action"].ToString().Trim())
            {
                case "WorkPerson":
                    SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
                    int id = int.Parse(Request.QueryString["id"]);
                    MediaUrl = "../" + bll.GetModel(id).WorkUrl.ToString();
                    Download(MediaUrl);
                    break;
                case "WorkTuanDui":
                    SDM.BLL.WorkTuanDui bll2 = new SDM.BLL.WorkTuanDui();
                    int id2 = int.Parse(Request.QueryString["id"]);
                    MediaUrl = "../" + bll2.GetModel(id2).WorkUrl.ToString();
                    Download(MediaUrl);
                    break;
            }
        }
    }
     private void Download(string url)
    {
        string filename = Path.GetFileName(url);
        Response.Clear();
        Response.ContentType = "application/octet-stream ";
        Response.AppendHeader("Content-Disposition ", "attachment;   Filename   =   " + System.Convert.ToChar(34) + filename + System.Convert.ToChar(34));
        Response.Charset = " ";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.Flush();
        Response.WriteFile(url);
    }
}


/*
// 定义文件名  
string fileName = "";
// 获取文件在服务器的地址  
string MediaUrl = "";
SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
int id = int.Parse(Request.QueryString["id"]);
MediaUrl = "../" + bll.GetModel(id).WorkUrl.ToString();

// 判断获取的是否为地址，而非文件名  
if (MediaUrl.IndexOf("/") > -1)
{
    // 获取文件名  
    fileName = MediaUrl.Substring(MediaUrl.LastIndexOf("/") + 1);
}
else
{
    // url为文件名时，直接获取文件名  
    fileName = MediaUrl;
}
// 以字符流的方式下载文件  
FileStream fileStream = new FileStream(MediaUrl, FileMode.Open);
byte[] bytes = new byte[(int)fileStream.Length];
fileStream.Read(bytes, 0, bytes.Length);
fileStream.Close();
Response.ContentType = "application / octet - stream";

// 通知浏览器下载 
Response.AddHeader("Content - Disposition", "attachment;filename =" + fileName);
Response.BinaryWrite(bytes);
Response.Flush();
Response.End();
}
*/
