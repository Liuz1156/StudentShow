using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SDM.DAL
{
	/// <summary>
	/// 数据访问类:Commernts
	/// </summary>
	public partial class Commernts
	{
		public Commernts()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CommerntID", "Commernts"); 
		}
        
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CommerntID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Commernts");
			strSql.Append(" where CommerntID=@CommerntID");
			SqlParameter[] parameters = {
					new SqlParameter("@CommerntID", SqlDbType.Int,4)
			};
			parameters[0].Value = CommerntID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SDM.Model.Commernts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Commernts(");
			strSql.Append("WorkID,UserID,CommentContent,CommerntTime)");
			strSql.Append(" values (");
			strSql.Append("@WorkID,@UserID,@CommentContent,@CommerntTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@CommentContent", SqlDbType.Text),
					new SqlParameter("@CommerntTime", SqlDbType.VarChar,50)};
			parameters[0].Value = model.WorkID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.CommentContent;
			parameters[3].Value = model.CommerntTime;

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
		public bool Update(SDM.Model.Commernts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Commernts set ");
			strSql.Append("WorkID=@WorkID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("CommentContent=@CommentContent,");
			strSql.Append("CommerntTime=@CommerntTime");
			strSql.Append(" where CommerntID=@CommerntID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@CommentContent", SqlDbType.Text),
					new SqlParameter("@CommerntTime", SqlDbType.VarChar,50),
					new SqlParameter("@CommerntID", SqlDbType.Int,4)};
			parameters[0].Value = model.WorkID;
			parameters[1].Value = model.UserID;
			parameters[2].Value = model.CommentContent;
			parameters[3].Value = model.CommerntTime;
			parameters[4].Value = model.CommerntID;

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
		public bool Delete(int CommerntID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Commernts ");
			strSql.Append(" where CommerntID=@CommerntID");
			SqlParameter[] parameters = {
					new SqlParameter("@CommerntID", SqlDbType.Int,4)
			};
			parameters[0].Value = CommerntID;

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
		public bool DeleteList(string CommerntIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Commernts ");
			strSql.Append(" where CommerntID in ("+CommerntIDlist + ")  ");
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
		public SDM.Model.Commernts GetModel(int CommerntID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CommerntID,WorkID,UserID,CommentContent,CommerntTime from Commernts ");
			strSql.Append(" where CommerntID=@CommerntID");
			SqlParameter[] parameters = {
					new SqlParameter("@CommerntID", SqlDbType.Int,4)
			};
			parameters[0].Value = CommerntID;

			SDM.Model.Commernts model=new SDM.Model.Commernts();
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
		public SDM.Model.Commernts DataRowToModel(DataRow row)
		{
			SDM.Model.Commernts model=new SDM.Model.Commernts();
			if (row != null)
			{
				if(row["CommerntID"]!=null && row["CommerntID"].ToString()!="")
				{
					model.CommerntID=int.Parse(row["CommerntID"].ToString());
				}
				if(row["WorkID"]!=null && row["WorkID"].ToString()!="")
				{
					model.WorkID=int.Parse(row["WorkID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["CommentContent"]!=null)
				{
					model.CommentContent=row["CommentContent"].ToString();
				}
				if(row["CommerntTime"]!=null)
				{
					model.CommerntTime=row["CommerntTime"].ToString();
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
			strSql.Append("select CommerntID,WorkID,UserID,CommentContent,CommerntTime ");
			strSql.Append(" FROM Commernts ");
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
			strSql.Append(" CommerntID,WorkID,UserID,CommentContent,CommerntTime ");
			strSql.Append(" FROM Commernts ");
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
			strSql.Append("select count(1) FROM Commernts ");
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
				strSql.Append("order by T.CommerntID desc");
			}
			strSql.Append(")AS Row, T.*  from Commernts T ");
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
			parameters[0].Value = "Commernts";
			parameters[1].Value = "CommerntID";
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

