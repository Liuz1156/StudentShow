using System;
namespace SDM.Model
{
	/// <summary>
	/// Commernts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Commernts
	{
		public Commernts()
		{}
		#region Model
		private int _commerntid;
		private int? _workid;
		private int? _userid;
		private string _commentcontent;
		private string _commernttime;
		/// <summary>
		/// 
		/// </summary>
		public int CommerntID
		{
			set{ _commerntid=value;}
			get{return _commerntid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WorkID
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommentContent
		{
			set{ _commentcontent=value;}
			get{return _commentcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommerntTime
		{
			set{ _commernttime=value;}
			get{return _commernttime;}
		}
		#endregion Model

	}
}

