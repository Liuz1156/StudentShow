using System;
namespace SDM.Model
{
	/// <summary>
	/// WorkTuanDui:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WorkTuanDui
	{
		public WorkTuanDui()
		{}
		#region Model
		private int _workid;
		private string _tdmc;
		private int? _userid_1;
		private string _userid_1_des;
		private int? _userid_2;
		private string _userid_2_des;
		private int? _userid_3;
		private string _userid_3_des;
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
		public string tdmc
		{
			set{ _tdmc=value;}
			get{return _tdmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID_1
		{
			set{ _userid_1=value;}
			get{return _userid_1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID_1_des
		{
			set{ _userid_1_des=value;}
			get{return _userid_1_des;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID_2
		{
			set{ _userid_2=value;}
			get{return _userid_2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID_2_des
		{
			set{ _userid_2_des=value;}
			get{return _userid_2_des;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID_3
		{
			set{ _userid_3=value;}
			get{return _userid_3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID_3_des
		{
			set{ _userid_3_des=value;}
			get{return _userid_3_des;}
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

