using System;
using System.Data;
using System.Collections.Generic;

using SDM.Model;
namespace SDM.BLL
{
	/// <summary>
	/// StudentsInfo
	/// </summary>
	public partial class StudentsInfo
	{
		private readonly SDM.DAL.StudentsInfo dal=new SDM.DAL.StudentsInfo();
		public StudentsInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		/*public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        */
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			return dal.Exists(UserID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SDM.Model.StudentsInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SDM.Model.StudentsInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserID)
		{
			
			return dal.Delete(UserID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.StudentsInfo GetModel(int UserID)
		{
			
			return dal.GetModel(UserID);
		}

		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SDM.Model.StudentsInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SDM.Model.StudentsInfo> DataTableToList(DataTable dt)
		{
			List<SDM.Model.StudentsInfo> modelList = new List<SDM.Model.StudentsInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SDM.Model.StudentsInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        public int AddStudentInfoByTrans(string UserName, string UserSex, string UserNumber, string UserPass, string UserXy, string UserZy, string UserBj, string UserAddTime)
        {
            return dal.AddStudentInfoByTrans(UserName, UserSex, UserNumber, UserPass, UserXy, UserZy, UserBj, UserAddTime);
        }
        public bool Exists(string strUserNumber)
        {
            return dal.Exists(strUserNumber);
        }
        public DataSet GetStudentListByUserName(string username)
        {
            return dal.GetStudentListByUserName(username);
        }
        public DataSet GetStudentListByUserXy(string userxy)
        {
            return dal.GetStudentListByUserXy(userxy);
        }
        public DataSet GetLogin(string strName, string strPass)
        {
            return dal.GetLogin(strName, strPass);
        }
		#endregion  ExtensionMethod
	}
}

