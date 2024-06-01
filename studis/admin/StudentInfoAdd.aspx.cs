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

public partial class admin_StudentInfoAdd : System.Web.UI.Page
{
    public SDM.BLL.StudentsInfo bll = new SDM.BLL.StudentsInfo();
    public string strsql = "";
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            string straction = Request.QueryString["action"].ToString().Trim();
            switch (straction)
            {
                case "Add":
                    btnOk.Visible = true;
                    btnSave.Visible = false;
                    txtUserAddTime.Text = Convert.ToString(DateTime.Now.ToString());
                    break;
                case "Edit":
                    btnOk.Visible = false ;
                    btnSave.Visible = true;
                    EditLoadData();
                    txtUserAddTime.Text = Convert.ToString(DateTime.Now.ToString());
                    break;
            }
        }
    }
    public void EditLoadData()
    {
        int id = int.Parse(Request.QueryString["id"]);
        txtUserName.Text = bll.GetModel(id).UserName.ToString();
        txtUserNumber.Text = bll.GetModel(id).UserNumber.ToString();
        txtUserPass.Text = bll.GetModel(id).UserPass.ToString();
        txtUserXy.Text = bll.GetModel(id).UserXy.ToString();
        txtUserZy.Text = bll.GetModel(id).UserZy.ToString();
        txtUserBj.Text = bll.GetModel(id).UserBj.ToString();
        DropDownList1.Text = bll.GetModel(id).UserSex.ToString();
        txtUserAddTime.Text = Convert.ToString(bll.GetModel(id).UserAddTime.ToString());
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {

            if (string.IsNullOrWhiteSpace(txtUserNumber.Text))
            {
                SDM.DAL.ShowInfo.Alert("请输入学生学号！", this.Page);
                return;
            }

            bool userExists = bll.Exists(txtUserNumber.Text.Trim());

            if (userExists)
            {
                SDM.DAL.ShowInfo.Alert("对不起，此学号已被添加，请更换！", this.Page);
                txtUserNumber.Focus();
            }
            else
            {
                SDM.DAL.ShowInfo.Alert("学号可用！", this.Page);
            }

    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "" || txtUserNumber.Text.Trim() == "" || txtUserXy.Text.Trim() == "" || txtUserZy.Text.Trim() == "" || txtUserBj.Text.Trim() == "")
        {
            SDM.DAL.ShowInfo.Alert("学生姓名||学生学号||学生所属院系||学生所学专业||学生所属班级信息必填！！", this.Page);
            return;
        }
        else if (bll.Exists(txtUserNumber.Text.Trim()))//防止用户没有检验学号直接添加
             {
               SDM.DAL.ShowInfo.Alert("对不起，此学号已被添加，请更换！！", this.Page);
               txtUserNumber.Focus();
             }
             else
            {
               //执行添加学生信息函数
               bll.AddStudentInfoByTrans(txtUserName.Text.Trim(), DropDownList1.SelectedItem.Text.Trim(), txtUserNumber.Text.Trim(), txtUserPass.Text.Trim(), txtUserXy.Text.Trim(), txtUserZy.Text.Trim(), txtUserBj.Text.Trim(), Convert.ToString(DateTime.Now.ToString()));
               SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
               txtUserName.Text = "";
               txtUserNumber.Text = "";
            }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);
        SDM.Model.StudentsInfo model = new SDM.Model.StudentsInfo();
        model.UserID = id;
        model.UserNumber = txtUserNumber.Text.Trim();
        model.UserName = txtUserName.Text.Trim();
        model.UserPass = txtUserPass.Text.Trim();
        model.UserSex = DropDownList1.SelectedItem.Text.Trim();
        model.UserXy = txtUserXy.Text.Trim();
        model.UserZy = txtUserZy.Text.Trim();
        model.UserBj = txtUserBj.Text.Trim();
        model.UserAddTime = txtUserAddTime.Text.Trim();
        bll.Update(model);
        SDM.DAL.ShowInfo.AlertAndRedirect("操作成功！", "StudentInfo.aspx", this.Page);
    }
}
