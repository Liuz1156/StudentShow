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

public partial class stu_person : System.Web.UI.Page
{
    public SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = int.Parse(Session["userid"].ToString());
            txtBj.Text = bll.GetModel(id).UserBj.ToString();
            txtBj.Enabled = false;
            txtXy.Text = bll.GetModel(id).UserXy.ToString();
            txtXy.Enabled = false;
            txtZy.Text = bll.GetModel(id).UserZy.ToString();
            txtZy.Enabled = false;
            txtUserSex.Text = bll.GetModel(id).UserSex.ToString();
            txtUserSex.Enabled = false;
            txtUserPass.Text = bll.GetModel(id).UserPass.ToString();
            txtUserNumber.Text = bll.GetModel(id).UserNumber.ToString();
            txtUserNumber.Enabled = false;
            txtUserName.Text = bll.GetModel(id).UserName.ToString();
            txtUserName.Enabled = false;
            txtTime.Text = bll.GetModel(id).UserAddTime.ToString();
            txtTime.Enabled = false;
        }
    }
    protected void btnAlter_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Session["userid"].ToString());
        SDM.Model.StudentsInfo model = new SDM.Model.StudentsInfo();
        model.UserID = id;
        model.UserName = txtUserName.Text.Trim();
        model.UserPass = txtUserPass.Text.Trim();
        model.UserNumber = txtUserNumber.Text.Trim();
        model.UserSex = txtUserSex.Text.Trim();
        model.UserXy = txtXy.Text.Trim();
        model.UserBj = txtBj.Text.Trim();
        model.UserZy = txtZy.Text.Trim();
        model.UserAddTime = Convert.ToString(txtTime.Text.Trim());
        bll.Update(model);
        SDM.DAL.ShowInfo.Alert("修改成功！", this.Page);

    }
}
