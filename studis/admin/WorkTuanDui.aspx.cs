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
public partial class admin_WorkTuanDui : System.Web.UI.Page
{
    public SqlConnection conn = DAL.SqlCreation();
    public string strsql = "";
    public SqlCommand cmd;
    public SqlDataAdapter da;
    public DataSet ds;
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindLoad();
            BindCount();
        }
    }
    public void BindLoad()
    {
        strsql = "select * from WorkTuanDui_StudentsInfo order by WorkID desc";
        da = new SqlDataAdapter(strsql, conn);
        ds = new DataSet();
        da.Fill(ds, AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1), AspNetPager1.PageSize, "ds");
        rpTuanDui.DataSource = ds;
        rpTuanDui.DataBind();
    }
    public void BindCount()
    {
        strsql = "select count(1) from WorkTuanDui_StudentsInfo ";
        cmd = new SqlCommand(strsql, conn);
        conn.Open();
        AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
        conn.Close();
    }
}
