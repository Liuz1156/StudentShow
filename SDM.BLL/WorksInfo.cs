using System;
using System.Data;
using System.Collections.Generic;

using SDM.Model;
namespace SDM.BLL
{
	/// <summary>
	/// WorksInfo
	/// </summary>
	public partial class WorksInfo
	{
		private readonly SDM.DAL.WorksInfo dal=new SDM.DAL.WorksInfo();
		public WorksInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int WorkID)
		{
			return dal.Exists(WorkID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SDM.Model.WorksInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SDM.Model.WorksInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int WorkID)
		{
			
			return dal.Delete(WorkID);
		}
		

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.WorksInfo GetModel(int WorkID)
		{
			
			return dal.GetModel(WorkID);
		}

	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SDM.Model.WorksInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SDM.Model.WorksInfo> DataTableToList(DataTable dt)
		{
			List<SDM.Model.WorksInfo> modelList = new List<SDM.Model.WorksInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SDM.Model.WorksInfo model;
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

		#endregion  ExtensionMethod
	}
}

