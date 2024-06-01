using System;
namespace SDM.Model
{
	/// <summary>
	/// StudentsInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StudentsInfo
	{
		public StudentsInfo()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _usersex;
		private string _usernumber;
		private string _userpass;
		private string _userxy;
		private string _userzy;
		private string _userbj;
		private string _useraddtime;
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserSex
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserNumber
		{
			set{ _usernumber=value;}
			get{return _usernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPass
		{
			set{ _userpass=value;}
			get{return _userpass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserXy
		{
			set{ _userxy=value;}
			get{return _userxy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserZy
		{
			set{ _userzy=value;}
			get{return _userzy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserBj
		{
			set{ _userbj=value;}
			get{return _userbj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserAddTime
		{
			set{ _useraddtime=value;}
			get{return _useraddtime;}
		}
		#endregion Model

	}
}

