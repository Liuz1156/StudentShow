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

public partial class admin_WorksInfo : System.Web.UI.Page
{
    public DataTable dt;


    public DAL dl = new DAL();
    public int UserID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["username"] == null || Session["username"].ToString() == "")
            {
                SDM.DAL.ShowInfo.AlertAndRedirect("请登录！", "../login.aspx", this.Page);
            }
            else
            {


                switch (Request.QueryString["action"].ToString().Trim())
                {

                    case "AdminEdit":
                        int id = int.Parse(Request.QueryString["id"]);
                        content1.InnerText = bll.GetModel(id).WorkDes.ToString();
                        txtWorkName.Text = bll.GetModel(id).WorkName.ToString();
                        txtWorkTime.Text = Convert.ToString(bll.GetModel(id).WorkTime.ToString());
                        txtWorkUrl.Text = bll.GetModel(id).WorkUrl.ToString();
                        txtWorkPicUrl.Text = bll.GetModel(id).WorkPicUrl.ToString();
                        imgsrc.ImageUrl = "../" + txtWorkPicUrl.Text.Trim();
                        btnOk.Visible = false;
                        btnSave.Visible = true;
                        break;
                    case "add":
                        btnOk.Visible = true;
                        btnSave.Visible = false;
                        txtWorkTime.Text = Convert.ToString(DateTime.Now.ToString());
                        break;

                    case "StuEdit":
                        btnSave.Visible = true;
                        btnOk.Visible = false;
                        btnSave.Text = "作品上传成功，只能查看，不能修改！！";
                        btnSave.Enabled = false;
                        int id2 = int.Parse(Request.QueryString["id"]);
                        content1.Value = bll.GetModel(id2).WorkDes.ToString();
                        txtWorkName.Text = bll.GetModel(id2).WorkName.ToString();
                        txtWorkTime.Text = Convert.ToString(bll.GetModel(id2).WorkTime.ToString());
                        txtWorkUrl.Text = bll.GetModel(id2).WorkUrl.ToString();
                        btnUploadVideo.Enabled = false;
                        btnUploadVideo.Text = "禁止上传";
                        txtWorkPicUrl.Text = bll.GetModel(id2).WorkPicUrl.ToString();
                        btnUploadPic.Enabled = false;
                        btnUploadPic.Text = "禁止上传";
                        imgsrc.ImageUrl ="../" + txtWorkPicUrl.Text.Trim();
                        break;
                }
            }
        }
    }
    private static bool IsAllowedExtension(FileUpload upfile,string[] arrExtension)
    {
        string strOldFilePath = "";
        string strExtension = "";
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
        string[] VideoType = { ".mp4" };
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
                    string serverpath = Server.MapPath("~/uploadfiles/zuoye/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    FileUpload1.PostedFile.SaveAs(serverpath);
                    SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                    this.txtWorkUrl.Text = "uploadfiles/zuoye/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                }
                else
                {
                    SDM.DAL.ShowInfo.Alert("视频文件格式错误，只能上传：mp4格式！！", this.Page);

                }
            }
        }
        catch (Exception ex)
        {
            this.Label1.Text = "上传发生错误，请检查文件类型是否正确！！！";
        }
    }
    public SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
    public SDM.Model.WorksInfo model = new SDM.Model.WorksInfo();
    public SDM.Model.WorksInfo checkModel()
    {
        model.UserID = int.Parse(Session["userid"].ToString());
        model.WorkCate = "个人作品";
        model.WorkDes = content1.Value.Trim();
        model.WorkName = txtWorkName.Text.Trim();
        model.WorkTime = Convert.ToString(DateTime.Now.ToString());
        model.WorkUrl = txtWorkUrl.Text.Trim();
        model.WorkPicUrl = txtWorkPicUrl.Text.Trim();
        return model;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
        int workid = int.Parse(Request.QueryString["id"]);
        SDM.Model.WorksInfo ModelInfo = new SDM.Model.WorksInfo();
        ModelInfo.WorkUrl = txtWorkUrl.Text.Trim();
        ModelInfo.UserID = Convert.ToInt32(Session["UserID"].ToString());
        ModelInfo.WorkCate = "个人作品";
        ModelInfo.WorkDes = content1.Value.Replace("'", "").Replace("/'", "").Trim();
        ModelInfo.WorkName = txtWorkName.Text.Trim();
        ModelInfo.WorkTime = Convert.ToString(DateTime.Now.ToString());
        ModelInfo.WorkID = workid;
        ModelInfo.WorkPicUrl = txtWorkPicUrl.Text.Trim();
        bll.Update(ModelInfo);
        SDM.DAL.ShowInfo.AlertAndRedirect("操作成功！", "WorkPerson.aspx", this.Page);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (txtWorkName.Text == "" || content1.Value == "" || txtWorkUrl.Text == "")
        {
            SDM.DAL.ShowInfo.Alert("作品名称||作品描述||作品视频为必填项！！", this.Page);
            return;
        }
        else
        {
            bll.Add(checkModel());
            SDM.DAL.ShowInfo.Alert("操作成功！", this.Page);
            txtWorkUrl.Text = "";
            txtWorkName.Text = "";
            content1.Value = "";
        }
    }
    protected void btnUploadPic_Click(object sender, EventArgs e)
    {
        string[] PicType = {"jpg","png","gif" };
        if (this.FileUpload2.PostedFile.FileName == "")
        {
            SDM.DAL.ShowInfo.Alert("请选择文件！！", this.Page);
            return;
        }
        else
        {
            string filepath = FileUpload2.PostedFile.FileName;
            if (IsAllowedExtension(FileUpload2, PicType) == true)
            {
                string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                string serverpath = Server.MapPath("~/uploadfiles/zuoye/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                FileUpload2.PostedFile.SaveAs(serverpath);
                SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                this.txtWorkPicUrl.Text = "uploadfiles/zuoye/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                imgsrc.ImageUrl = "../" + txtWorkPicUrl.Text.Trim();
            }
            else
            {
                SDM.DAL.ShowInfo.Alert("视频文件格式错误，只能上传：jpg、png或者gif格式！！", this.Page);
            }

        }
    }
}
