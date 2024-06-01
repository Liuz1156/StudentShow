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
using System.Data.SqlClient;
public partial class stu_AddWorkPersonList : System.Web.UI.Page
{
    public SqlConnection conn = DAL.SqlCreation();
    public string strsql = "";
    public DataSet ds;
    public SqlDataAdapter da;
    public SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                BindInit();
                BindCount();
            }
        }

    }
    public string SubStr(string sString, int nLeng)
    {
        if (sString.Length <= nLeng)
        {
            return sString;
        }
        string sNewStr = sString.Substring(0, nLeng);
        sNewStr = sNewStr + "...";
        return sNewStr;
    }
    public void BindInit()
    {
        strsql = "select * from WorksInfo_StudentsInfo  where UserID="+ int.Parse(Session["userid"].ToString()) +" order by WorkID desc";
        da = new SqlDataAdapter(strsql, conn);
        ds = new DataSet();
        da.Fill(ds, AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1), AspNetPager1.PageSize, "ds");
        gdvWishList.DataSource = ds;
        gdvWishList.DataKeyNames = new string[] { "WorkID" };
        gdvWishList.DataBind();
       
    }
    public void BindCount()
    {
        strsql = "select count(1) from WorksInfo_StudentsInfo where UserID='" + int.Parse(Session["userid"].ToString()) + "'";
        cmd = new SqlCommand(strsql, conn);
        conn.Open();
        AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
        conn.Close();
    }
    protected void gdvWishList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex != -1)
        {
            int id = e.Row.RowIndex + 1;
            e.Row.Cells[1].Text = id.ToString();
        }
    }
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.CurrentPageIndex = e.NewPageIndex;
        BindInit();
        BindCount();
    }
}
