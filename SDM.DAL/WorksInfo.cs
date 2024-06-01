using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SDM.DAL
{
	/// <summary>
	/// 数据访问类:WorksInfo
	/// </summary>
	public partial class WorksInfo
	{
		public WorksInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		/*public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("WorkID", "WorksInfo"); 
		}
        */
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int WorkID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WorksInfo");
			strSql.Append(" where WorkID=@WorkID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SDM.Model.WorksInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WorksInfo(");
			strSql.Append("UserID,WorkName,WorkCate,WorkDes,WorkTime,WorkUrl,WorkPicUrl)");
			strSql.Append(" values (");
            strSql.Append("@UserID,@WorkName,@WorkCate,@WorkDes,@WorkTime,@WorkUrl,@WorkPicUrl)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@WorkName", SqlDbType.VarChar,500),
					new SqlParameter("@WorkCate", SqlDbType.VarChar,50),
					new SqlParameter("@WorkDes", SqlDbType.Text),
					new SqlParameter("@WorkTime", SqlDbType.VarChar,50),
					new SqlParameter("@WorkUrl", SqlDbType.Text),
                                        new SqlParameter ("@WorkPicUrl",SqlDbType.Text)
                                        };
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.WorkName;
			parameters[2].Value = model.WorkCate;
			parameters[3].Value = model.WorkDes;
			parameters[4].Value = model.WorkTime;
			parameters[5].Value = model.WorkUrl;
            parameters[6].Value = model.WorkPicUrl;
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SDM.Model.WorksInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WorksInfo set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("WorkName=@WorkName,");
			strSql.Append("WorkCate=@WorkCate,");
			strSql.Append("WorkDes=@WorkDes,");
			strSql.Append("WorkTime=@WorkTime,");
			strSql.Append("WorkUrl=@WorkUrl,");
            strSql.Append(" WorkPicUrl=@WorkPicUrl ");
			strSql.Append(" where WorkID=@WorkID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@WorkName", SqlDbType.VarChar,500),
					new SqlParameter("@WorkCate", SqlDbType.VarChar,50),
					new SqlParameter("@WorkDes", SqlDbType.Text),
					new SqlParameter("@WorkTime", SqlDbType.VarChar,50),
					new SqlParameter("@WorkUrl", SqlDbType.Text),
                    new SqlParameter ("@WorkPicUrl",SqlDbType.Text),
					new SqlParameter("@WorkID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.WorkName;
			parameters[2].Value = model.WorkCate;
			parameters[3].Value = model.WorkDes;
			parameters[4].Value = model.WorkTime;
			parameters[5].Value = model.WorkUrl;
			parameters[6].Value = model.WorkPicUrl;
            parameters[7].Value = model.WorkID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int WorkID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WorksInfo ");
			strSql.Append(" where WorkID=@WorkID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string WorkIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WorksInfo ");
			strSql.Append(" where WorkID in ("+WorkIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.WorksInfo GetModel(int WorkID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 WorkID,UserID,WorkName,WorkCate,WorkDes,WorkTime,WorkUrl,WorkPicUrl from WorksInfo ");
			strSql.Append(" where WorkID=@WorkID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkID;

			SDM.Model.WorksInfo model=new SDM.Model.WorksInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SDM.Model.WorksInfo DataRowToModel(DataRow row)
		{
			SDM.Model.WorksInfo model=new SDM.Model.WorksInfo();
			if (row != null)
			{
				if(row["WorkID"]!=null && row["WorkID"].ToString()!="")
				{
					model.WorkID=int.Parse(row["WorkID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["WorkName"]!=null)
				{
					model.WorkName=row["WorkName"].ToString();
				}
				if(row["WorkCate"]!=null)
				{
					model.WorkCate=row["WorkCate"].ToString();
				}
				if(row["WorkDes"]!=null)
				{
					model.WorkDes=row["WorkDes"].ToString();
				}
				if(row["WorkTime"]!=null)
				{
					model.WorkTime=row["WorkTime"].ToString();
				}
				if(row["WorkUrl"]!=null)
				{
					model.WorkUrl=row["WorkUrl"].ToString();
				}
                if (row["WorkPicUrl"] != null)
                {
                    model.WorkPicUrl = row["WorkPicUrl"].ToString();
                }
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select WorkID,UserID,WorkName,WorkCate,WorkDes,WorkTime,WorkUrl,WorkPicUrl ");
			strSql.Append(" FROM WorksInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
            strSql.Append(" WorkID,UserID,WorkName,WorkCate,WorkDes,WorkTime,WorkUrl,WorkPicUrl ");
			strSql.Append(" FROM WorksInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM WorksInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.WorkID desc");
			}
			strSql.Append(")AS Row, T.*  from WorksInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "WorksInfo";
			parameters[1].Value = "WorkID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

