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
using System.IO;
public partial class stu_WorkPerson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (Request.QueryString["action"].ToString())
            {
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
                    int id = int.Parse(Request.QueryString["id"]);
                    serverid.Value= bll.GetModel(id).WorkDes.ToString();
                    txtWorkName.Text = bll.GetModel(id).WorkName.ToString();
                    txtWorkTime.Text = Convert.ToString(bll.GetModel(id).WorkTime.ToString());
                    txtWorkUrl.Text = bll.GetModel(id).WorkUrl.ToString();
                    btnUploadVideo.Enabled = false;
                    btnUploadVideo.Text = "禁止上传";
                    txtWorkPicUrl.Text = bll.GetModel(id).WorkPicUrl.ToString();
                    btnUploadPic.Enabled = false;
                    btnUploadPic.Text = "禁止上传";
                    break;
            }
        }
    }
    public SDM.BLL.WorksInfo bll = new SDM.BLL.WorksInfo();
    public SDM.Model.WorksInfo model = new SDM.Model.WorksInfo();
    public SDM.Model.WorksInfo checkModel()
    {
        model.UserID = int.Parse(Session["userid"].ToString());
        model.WorkCate = "个人作品";
        model.WorkDes = serverid.Value.Trim();
        model.WorkName = txtWorkName.Text.Trim();
        model.WorkTime = Convert.ToString(DateTime.Now.ToString());
        model.WorkUrl = txtWorkUrl.Text.Trim();
        model.WorkPicUrl = txtWorkPicUrl.Text.Trim();
        return model;
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (txtWorkName.Text == "" || serverid.Value== "" || txtWorkUrl.Text == "")
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
            serverid.Value= "";
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
       
    }
    //判断文件是否符合要求
    private static bool IsAllowedExtension(FileUpload upfile,string[] arrExtension)
    {
        string strOldFilePath = "";
        string strExtension = "";
        //string[] arrExtension = { ".mp4"};
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
        string[] Video_type = { ".mp4"}; 
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
                if (IsAllowedExtension(FileUpload1,Video_type) == true)
                {
                    string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath("~/uploadfiles/zuoye/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    FileUpload1.PostedFile.SaveAs(serverpath);
                    SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                    this.txtWorkUrl.Text = "uploadfiles/zuoye/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    //TextBox1.Text = filename.ToString();
                    //string Extension = Path.GetExtension(FileUploadImg.PostedFile.FileName); //获取扩展名
                    //txtWorkUrl.Text = Path.GetExtension(FileUpload1.PostedFile.FileName); //获取扩展名
                    
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
    protected void btnUploadPic_Click(object sender, EventArgs e)
    {
        string[] Pic_type = { ".png",".jpg",".gif" };
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
                if (IsAllowedExtension(FileUpload2, Pic_type) == true)
                {
                    string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1);
                    string serverpath = Server.MapPath("~/uploadfiles/pic/") + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    FileUpload2.PostedFile.SaveAs(serverpath);
                    SDM.DAL.ShowInfo.Alert("上传成功！", this.Page);
                    this.txtWorkPicUrl.Text = "uploadfiles/pic/" + System.DateTime.Now.ToString("yyyMMddhhmmss") + filename;
                    //TextBox1.Text = filename.ToString();
                    //string Extension = Path.GetExtension(FileUploadImg.PostedFile.FileName); //获取扩展名
                    //txtWorkUrl.Text = Path.GetExtension(FileUpload1.PostedFile.FileName); //获取扩展名
                }
                else
                {
                    SDM.DAL.ShowInfo.Alert("文件格式错误，只能上传：png、jpg或gif格式！！", this.Page);
                }

             }
               
         }
        
        catch (Exception ex)
        {
            this.Label1.Text = "上传发生错误，请检查文件类型是否正确！！！";
        }
    }
}
