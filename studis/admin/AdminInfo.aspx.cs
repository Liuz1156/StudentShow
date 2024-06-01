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

public partial class admin_AdminInfo : System.Web.UI.Page
{
   public  SDM.BLL.AdminInfo bll = new SDM.BLL.AdminInfo();
   public SDM.Model.AdminInfo model = new SDM.Model.AdminInfo();
   public SDM.Model.AdminInfo checkmodel()
   {
       model.AdminName = txtUserNameSearch.Text.Trim();
       model.AdminPass = txtUserXySearch.Text.Trim();
       return model;
   }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (Request.QueryString["action"].ToString().Trim())
            {
                case "add":
                    btnSave.Visible = false;
                    btnSubmit.Visible = true;
                    bind();
                    break;
                case "edit":
                    btnSave.Visible = true;
                    btnSubmit.Visible = false;
                    int id = int.Parse(Request.QueryString["id"]);
                    txtUserNameSearch.Text = bll.GetModel(id).AdminName.ToString();
                    txtUserXySearch.Text = bll.GetModel(id).AdminPass.ToString();
                    bind();
                    break;
            }
            
        }
    }
    public void bind()
    {
        Repeater1.DataSource = bll.GetAllList();
        Repeater1.DataBind();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        model.AdminID = int.Parse(Request.QueryString["id"].ToString());
        model.AdminName = txtUserNameSearch.Text.Trim();
        model.AdminPass = txtUserXySearch.Text.Trim();
        bll.Update(model);
        SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
        bind();//重新刷新数据
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtUserNameSearch.Text == "" || txtUserXySearch.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("账号和密码不能为空！", this.Page);
            return;
        }
        else
        {
            bll.Add(checkmodel());
            SDM.DAL.ShowInfo.Alert("操作成功!", this.Page);
            bind();
        }
    }
}
