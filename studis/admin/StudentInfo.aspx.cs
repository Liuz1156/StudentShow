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
public partial class admin_StudentInfo : System.Web.UI.Page
{
    public SqlConnection conn = DAL.SqlCreation();
    public SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();
    public SDM.Model.StudentsInfo model = new SDM.Model.StudentsInfo();
    public SqlCommand cmd;
    public DataSet ds;
    public string strsql = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
            loadCount();
          
        }
    }
    public void loadData()
    {
        strsql = "select * from StudentsInfo order by UserID DESC";
        SqlDataAdapter da = new SqlDataAdapter(strsql, conn);
        ds = new DataSet();
        da.Fill(ds, AspNetPager1.PageSize * (AspNetPager1.CurrentPageIndex - 1), AspNetPager1.PageSize, "StudentsInfo");
        gdvWishList.DataSource = ds;
        gdvWishList.DataKeyNames = new string[] { "UserID" };
        gdvWishList.DataBind();
    }
    public void loadCount()
    {
        cmd = new SqlCommand("select count(1) from StudentsInfo", conn);
        conn.Open();
        AspNetPager1.RecordCount = (int)cmd.ExecuteScalar();
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
        loadData();
        loadCount();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");
            if (CheckBox1.Checked == true)
            {
                cbox.Checked = true;
            }
            else
            {
                cbox.Checked = false;
            }
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");
            if (cbox.Checked == true)
            {
                bll.Delete(Convert.ToInt32(gdvWishList.DataKeys[i].Value));
                //bll.Delete(int.Parse(gdvWishList.DataKeys[i].Value));

            }
        }
        loadData();
        loadCount();
        this.CheckBox1.Checked = false;
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        this.CheckBox1.Checked = false;
        for (int i = 0; i <= gdvWishList.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)gdvWishList.Rows[i].FindControl("ChkSelected");

            cbox.Checked = false;



        }
    }
    protected void btnSearchByName_Click(object sender, EventArgs e)
    {
        gdvWishList.DataSource = bll.GetStudentListByUserName(txtUserNameSearch.Text.Trim());
        gdvWishList.DataBind();
    }
    protected void btnSearchByXy_Click(object sender, EventArgs e)
    {
        gdvWishList.DataSource = bll.GetStudentListByUserXy(txtUserXySearch.Text.Trim());
        gdvWishList.DataBind();
    }
    protected void btnShowAll_Click(object sender, EventArgs e)
    {
        loadData();
        loadCount();
    }
}
