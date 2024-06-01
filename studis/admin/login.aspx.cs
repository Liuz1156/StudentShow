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
public partial class Admin_login : System.Web.UI.Page
{
    public SDM.BLL.AdminInfo bll = new SDM.BLL.AdminInfo();
    public SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
    public SDM.Model.AdminInfo checkModel()
    {
        model.AdminName = txtUserName.Text.Trim();
        model.AdminPass = txtUserPass.Text.Trim();
        return model;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtUserName.Focus();
        }
    }
   
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (string.IsNullOrEmpty(checkModel().AdminName))
        {
           //调用ShowInfo类的Alert方法来实现弹窗提醒
           SDM.DAL.ShowInfo.Alert("请输入账号名称！", this.Page);
            txtUserName.Focus();
            return;

        }
        if (string.IsNullOrEmpty(checkModel().AdminPass))
        {
            SDM.DAL.ShowInfo.Alert("请输入登录密码！", this.Page);
            txtUserPass.Focus();
            return;
        }
        else
        {
            //返回数据库中用户名与密码符合的信息
            DataTable dt = bll.GetLogin(txtUserName.Text.Trim(), txtUserPass.Text.Trim()).Tables["ds"];
            //如果返回的数据大于0，则代表用户输入的信息正确，不过为0，则信息输入错误
            if (dt.Rows.Count > 0)
            {
                Session["userid"] = dt.Rows[0][0].ToString();
                Session["username"] = dt.Rows[0][1].ToString();//保存登录用户名

                Response.Redirect("index.aspx");
            }
            else
            {
                SDM.DAL.ShowInfo.Alert("对不起，登录失败，请核对您的账号名和密码！", this.Page);
                txtUserPass.Text = "";
                txtUserName.Text = "";
            }
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        txtUserName.Text = "";
        txtUserPass.Text = "";
    }
}
