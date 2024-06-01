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

public partial class stu_login : System.Web.UI.Page
{
    public SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtXueHao.Focus();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtXueHao.Text == "" || txtPwd.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("登录账号和密码不能为空！", this.Page);
            return;
        }
        else
        {
            DataTable dt = bll.GetLogin(this.txtXueHao.Text.Trim(), this.txtPwd.Text.Trim()).Tables["ds"];
            if (dt.Rows.Count > 0)
            {
                Session["userid"] = dt.Rows[0][0].ToString();
                Session["username"] = dt.Rows[0][1].ToString();//保存登录用户名
                Session["usernumber"]=dt.Rows[0][3].ToString ();

                Response.Redirect("index.aspx");
            }
            else
            {
                SDM.DAL.ShowInfo.Alert("对不起，登录失败，请核对您的账号名和密码！", this.Page);
                txtPwd.Text = "";
                txtXueHao.Text = "";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        txtPwd.Text = "";
        txtXueHao.Text = "";
    }
}
