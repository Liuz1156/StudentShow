﻿using System;
using System.Data;
using System.Collections.Generic;

using SDM.Model;
namespace SDM.BLL
{
	/// <summary>
	/// AdminInfo
	/// </summary>
	public partial class AdminInfo
	{
		private readonly SDM.DAL.AdminInfo dal=new SDM.DAL.AdminInfo();
		public AdminInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
        /// 
		/*public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        */
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AdminID)
		{
			return dal.Exists(AdminID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SDM.Model.AdminInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SDM.Model.AdminInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AdminID)
		{
			
			return dal.Delete(AdminID);
		}
		

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.AdminInfo GetModel(int AdminID)
		{
			
			return dal.GetModel(AdminID);
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
        public DataSet GetLogin(string strName, string strPass)
        {
            return dal.GetLogin(strName, strPass);
        }
		#endregion  ExtensionMethod
	}
}

