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

public partial class admin_sqlDel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (Request.QueryString["action"].ToString().Trim())
            {
                case "delStudent":
                    SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();
                    bll.Delete(int.Parse(Request.QueryString["id"]));
                    SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "StudentInfo.aspx", this.Page);
                    break;

                case "delAdmin":
                    SDM.BLL.AdminInfo bllAdminInfo = new SDM.BLL.AdminInfo();
                    bllAdminInfo.Delete(int.Parse(Request.QueryString["id"]));
                    SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "AdminInfo.aspx?action=add", this.Page);
                    break;
                case "delWorkPerson":
                    SDM.BLL.WorksInfo bllWorksInfo = new SDM.BLL.WorksInfo();
                    bllWorksInfo.Delete(int.Parse(Request.QueryString["id"]));
                    SDM.DAL.ShowInfo.AlertAndRedirect("删除成功！", "WorkPerson.aspx", this.Page);
                    break;
                case "delWorkTuanDui":
                    SDM.BLL.WorkTuanDui bllTuanDui = new SDM.BLL.WorkTuanDui();
                    bllTuanDui.Delete(int.Parse(Request.QueryString["id"]));
                    SDM.DAL.ShowInfo.AlertAndRedirect ("删除成功！","WorkTuanDui.aspx",this.Page);
                    break;
            }
        }
    }
}
