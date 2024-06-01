using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class stu_MasterPage : System.Web.UI.MasterPage
{
    public string strusername = "";
    public string strusernumber = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            if (Session["userid"] == null || Session["userid"].ToString() == ""||Session["username"]==null ||Session["username"].ToString ()=="")
            {
                SDM.DAL.ShowInfo.AlertAndRedirect("请登录！", "login.aspx", this.Page);
            }
            else
            {
                strusername = Session["username"].ToString();
                strusernumber = Session["usernumber"].ToString();
 
            }
        //}
    }
}
