using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_top : System.Web.UI.Page
{
    public string userid = "";
    public string strUsername = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            // RA.Common.Jscript.AlertAndRedirect("登录超时,请重新登录！", "login.aspx", this.Page);
            Response.Write("<script>alert('登录超时,请重新登录！');parent.location.href='login.aspx'</script>");
        }
        else
        {
            userid = Session["userid"].ToString();
            strUsername = Session["username"].ToString();
        }
    }
    protected void btnLoginOut_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Write("<script>alert('注销成功！');parent.location.href='../index.aspx'</script>");
    }
}
