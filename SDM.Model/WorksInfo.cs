using System;
namespace SDM.Model
{
	/// <summary>
	/// WorksInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WorksInfo
	{
		public WorksInfo()
		{}
		#region Model
		private int _workid;
		private int? _userid;
		private string _workname;
		private string _workcate;
		private string _workdes;
		private string _worktime;
		private string _workurl;
        private string _workpicurl;
        public string WorkPicUrl
        {
            get { return _workpicurl; }
            set
            {
                _workpicurl = value;
            }
        }
		/// <summary>
		/// 
		/// </summary>
		public int WorkID
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
		public string WorkName
		{
			set{ _workname=value;}
			get{return _workname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkCate
		{
			set{ _workcate=value;}
			get{return _workcate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkDes
		{
			set{ _workdes=value;}
			get{return _workdes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkTime
		{
			set{ _worktime=value;}
			get{return _worktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkUrl
		{
			set{ _workurl=value;}
			get{return _workurl;}
		}
		#endregion Model

	}
}

