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

public partial class stu_mp4 : System.Web.UI.Page
{
    public string MediaUrl = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch(Request.QueryString["action"].ToString().Trim())
            {
                case "WorkPerson":
                     SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
                     int id = int.Parse(Request.QueryString["id"]);
                     MediaUrl = "../" + bll.GetModel(id).WorkUrl.ToString();
                     this.LiteralSource.Text = string.Format("<source type=\"video/mp4\" src=\"{0}\" />", MediaUrl);
                     break;
                case "WorkTuanDui":
                    SDM.BLL.WorkTuanDui bll2 = new SDM.BLL.WorkTuanDui();
                    int id2 = int.Parse(Request.QueryString["id"]);
                    MediaUrl = "../" + bll2.GetModel(id2).WorkUrl.ToString();
                    this.LiteralSource.Text = string.Format("<source type=\"video/mp4\" src=\"{0}\" />", MediaUrl);
                    break;
            }
           
        }
    }
}