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
public partial class admin_WorkPerson : System.Web.UI.Page
{
    public SqlConnection conn = DAL.SqlCreation();
    public string strsql = "";
    public SqlDataAdapter da;
    public DataSet ds;
    public SqlCommand cmd;
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
        strsql = "select * from WorksInfo_StudentsInfo order by WorkID desc";
        da = new SqlDataAdapter(strsql, conn);
        ds = new DataSet();
        da.Fill(ds, AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1), AspNetPager1.PageSize, "ds");
        rpWorkPerson.DataSource = ds;
        rpWorkPerson.DataBind();
    }
    public void BindCount()
    {
        strsql = "select count(1) from WorksInfo_StudentsInfo ";
        conn.Open();
        cmd = new SqlCommand(strsql, conn);
        AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
        conn.Close();
    }
    protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
    {
        AspNetPager1.PageSize = e.NewPageIndex;
        BindLoad();
        BindCount();
    }
}
