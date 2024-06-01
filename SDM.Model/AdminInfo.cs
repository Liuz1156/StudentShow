using System;
namespace SDM.Model
{
	/// <summary>
	/// AdminInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdminInfo
	{
		public AdminInfo()
		{}
		#region Model
		private int _adminid;
		private string _adminname;
		private string _adminpass;
		/// <summary>
		/// 
		/// </summary>
		public int AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminPass
		{
			set{ _adminpass=value;}
			get{return _adminpass;}
		}
		#endregion Model

	}
}

