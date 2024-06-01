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

public partial class stu_WorkTuanDui : System.Web.UI.Page
{
    public SDM.BLL.WorkTuanDui bll = new SDM.BLL.WorkTuanDui();
    public string strsql = "";
    public DataTable dt;
       public  SDM.Model.WorkTuanDui model = new SDM.Model.WorkTuanDui();
    /// <summary>
    /// 添加团队作品信息
    /// </summary>
    /// <returns></returns>
       public SDM.Model.WorkTuanDui checkmodel()
       {
           model.tdmc = txttdmc.Text.Trim();
           model.UserID_1 = Convert.ToInt32(txtUser1ID.Text.Trim());
           model.UserID_1_des = txtUser1Des.Text.Trim();
           model.UserID_2 = Convert.ToInt32(txtUser2ID.Text.Trim());
           model.UserID_2_des = txtUser2Des.Text.Trim();
           model.UserID_3 = Convert.ToInt32(txtUser3ID.Text.Trim());
           model.UserID_3_des = txtUser3Des.Text.Trim();
           model.WorkCate = "团队作品";
           model.WorkDes = serverid.Value.Trim();
           model.WorkName = txtWorkName.Text.Trim();
           model.WorkTime = Convert.ToString(DateTime.Now.ToString());
           model.WorkUrl = txtWorkUrl.Text.Trim();
           model.WorkPicUrl = txtWorkPicUrl.Text.Trim();
           return model;
       }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null || Session["username"].ToString() == "")
        {
            SDM.DAL.ShowInfo.AlertAndRedirect("请登录！", "login.aspx",this.Page);
        }
        else 
        {

           
            switch (Request.QueryString["action"].ToString().Trim())
            {
                case "add":
                    txtTime.Text = Convert.ToString(DateTime.Now.ToString());
                    txtUser1.Text = Session["username"].ToString().Trim();
                    break;
                case "StuEdit":
                    int id = int.Parse(Request.QueryString["id"]);
                    txttdmc.Text = bll.GetModel(id).tdmc.ToString();
                    txtUser1ID.Text = Convert.ToString(bll.GetModel(id).UserID_1.ToString());
                    txtUser1Des.Text = bll.GetModel(id).UserID_1_des.ToString();
                    txtUser2ID.Text = Convert.ToString(bll.GetModel(id).UserID_2.ToString());
                    txtUser2Des.Text = bll.GetModel(id).UserID_2_des.ToString();
                    txtUser3ID.Text = Convert.ToString(bll.GetModel(id).UserID_3.ToString());
                    txtUser3Des.Text = bll.GetModel(id).UserID_3_des.ToString();
                    serverid.Value = bll.GetModel(id).WorkDes.ToString();
                    txtWorkName.Text = bll.GetModel(id).WorkName.ToString();
                    txtWorkUrl.Text = bll.GetModel(id).WorkUrl.ToString();
                    txtTime.Text = Convert.ToString(bll.GetModel(id).WorkTime.ToString());
                    btnSubmit.Enabled = false;
                    btnSubmit.Text = "您无权限提交信息";
                    btnUploadVideo.Enabled = false;
                    btnUploadVideo.Text = "禁止上传";
                    btnUploadPic.Enabled = false;
                    btnUploadPic.Text = "禁止上传";
                    break;
            }
        }
        
    }
     private static bool IsAllowedExtension(FileUpload upfile,string[] arrExtension) 
    { 
        string strOldFilePath = ""; 
        string strExtension=""; 
        //string[] arrExtension ={ ".mp4", ".jpg", ".gif","xls","doc"}; 
        if (upfile.PostedFile.FileName != string.Empty) 
        { 
            strOldFilePath = upfile.PostedFile.FileName;//获得文件的完整路径名 
            strExtension = strOldFilePath.Substring(strOldFilePath.LastIndexOf("."));//获得文件的扩展名，如：.jpg 
            for (int i = 0; i < arrExtension.Length; i++) 
            { 
                if (strExtension.Equals(arrExtension[i])) 
                { 
                    return true; 
                } 
            } 
        } 
        return false; 
    } 
    protected void btnUploadVideo_Click(object sender, EventArgs e)
    {
        string[] VideoType = { ".mp4"};
        try
        {
            if (this.FileUpload1.PostedFile.FileName == "")
            {
                SDM.DAL.ShowInfo.Alert("请选择文件！！", this.Page);
                return;
            }
            else
            {
                string filepath = FileUpload1.PostedFile.FileName;
                if (IsAllowedExtension(FileUpload1,VideoType) == true)
                {


                    string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath("~/uploadfiles/tuandui/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    FileUpload1.PostedFile.SaveAs(serverpath);
                    SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                    this.txtWorkUrl.Text = "uploadfiles/tuandui/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                }
                else
                {
                    SDM.DAL.ShowInfo.Alert("文件格式错误，只能上传：mp4格式！！", this.Page);
 
                }
            }
        }
        catch (Exception ex)
        {
            this.Label1.Text = "上传发生错误，请检查文件类型是否正确！！！";
        }
    }
    protected void btnSearch3_Click(object sender, EventArgs e)
    {
        if (txtUser1.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("请输入团队成员姓名！", this.Page);
            return;
        }
        else if (bll.Exists(txtUser1.Text.Trim()))
        {
            txtUser1ID.Text = Convert.ToString(bll.GetUserIDByUserName(txtUser1.Text.Trim()).Tables["ds"].Rows[0][0].ToString());
           
        }
        else
        {
            SDM.DAL.ShowInfo.Alert("当前成员不存在，请联系管理员添加此成员！！", this.Page);
            //获取团队成员1的UserID值。
            return;
        }

    }
    protected void btnSearch1_Click(object sender, EventArgs e)
    {
        if (txtUser2.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("请输入团队成员姓名！", this.Page);
            return;
        }
        else if (bll.Exists(txtUser2.Text.Trim()))
        {
            txtUser2ID.Text = Convert.ToString(bll.GetUserIDByUserName(txtUser2.Text.Trim()).Tables["ds"].Rows[0][0].ToString());

        }
        else
        {
            SDM.DAL.ShowInfo.Alert("当前成员不存在，请联系管理员添加此成员！！", this.Page);
            //获取团队成员1的UserID值。
            return;
        }
    }
    protected void btnSearch2_Click(object sender, EventArgs e)
    {
        if (txtUser3.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("请输入团队成员姓名！", this.Page);
            return;
        }
        else if (bll.Exists(txtUser3.Text.Trim()))
        {
            txtUser3ID.Text = Convert.ToString(bll.GetUserIDByUserName(txtUser3.Text.Trim()).Tables["ds"].Rows[0][0].ToString());

        }
        else
        {
            SDM.DAL.ShowInfo.Alert("当前成员不存在，请联系管理员添加此成员！！", this.Page);
            //获取团队成员1的UserID值。
            return;
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txttdmc.Text == "" || txtUser1ID.Text == "" || txtUser2ID.Text == "" || txtUser3ID.Text == "" || serverid.Value == "" || txtWorkName.Text == "" || txtWorkUrl.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("团队名称,团队成员ID,作品描述,作品名称必填！！", this.Page);
            return;
        }
        else
        {
            bll.Add(checkmodel());
            SDM.DAL.ShowInfo.Alert("操作成功！！", this.Page);

        }
    }
    protected void btnUploadPic_Click(object sender, EventArgs e)
    {
        string[] PicType = {".png",".jpg","gif" };
        try
        {
            if (this.FileUpload2.PostedFile.FileName == "")
            {
                SDM.DAL.ShowInfo.Alert("请选择文件！！", this.Page);
                return;
            }
            else
            {
                string filepath = FileUpload2.PostedFile.FileName;
                if (IsAllowedExtension(FileUpload2,PicType) == true)
                {


                    string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath("~/uploadfiles/tuandui/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    FileUpload2.PostedFile.SaveAs(serverpath);
                    SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                    this.txtWorkPicUrl.Text = "uploadfiles/tuandui/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                }
                else
                {
                    SDM.DAL.ShowInfo.Alert("文件格式错误，只能上传：jpg,gif,png格式！！", this.Page);

                }
            }
        }
        catch (Exception ex)
        {
            this.Label1.Text = "上传发生错误，请检查文件类型是否正确！！！";
        }
    }
}
