using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SDM.DAL
{
	/// <summary>
	/// 数据访问类:StudentsInfo
	/// </summary>
	public partial class StudentsInfo
	{
		public StudentsInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		/*public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "StudentsInfo"); 
		}
        */
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StudentsInfo");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SDM.Model.StudentsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentsInfo(");
			strSql.Append("UserName,UserSex,UserNumber,UserPass,UserXy,UserZy,UserBj,UserAddTime)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@UserSex,@UserNumber,@UserPass,@UserXy,@UserZy,@UserBj,@UserAddTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@UserSex", SqlDbType.VarChar,50),
					new SqlParameter("@UserNumber", SqlDbType.VarChar,200),
					new SqlParameter("@UserPass", SqlDbType.VarChar,50),
					new SqlParameter("@UserXy", SqlDbType.VarChar,200),
					new SqlParameter("@UserZy", SqlDbType.VarChar,200),
					new SqlParameter("@UserBj", SqlDbType.VarChar,50),
					new SqlParameter("@UserAddTime", SqlDbType.VarChar,50)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.UserSex;
			parameters[2].Value = model.UserNumber;
			parameters[3].Value = model.UserPass;
			parameters[4].Value = model.UserXy;
			parameters[5].Value = model.UserZy;
			parameters[6].Value = model.UserBj;
			parameters[7].Value = model.UserAddTime;

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
		public bool Update(SDM.Model.StudentsInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StudentsInfo set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserSex=@UserSex,");
			strSql.Append("UserNumber=@UserNumber,");
			strSql.Append("UserPass=@UserPass,");
			strSql.Append("UserXy=@UserXy,");
			strSql.Append("UserZy=@UserZy,");
			strSql.Append("UserBj=@UserBj,");
			strSql.Append("UserAddTime=@UserAddTime");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@UserSex", SqlDbType.VarChar,50),
					new SqlParameter("@UserNumber", SqlDbType.VarChar,200),
					new SqlParameter("@UserPass", SqlDbType.VarChar,50),
					new SqlParameter("@UserXy", SqlDbType.VarChar,200),
					new SqlParameter("@UserZy", SqlDbType.VarChar,200),
					new SqlParameter("@UserBj", SqlDbType.VarChar,50),
					new SqlParameter("@UserAddTime", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.UserSex;
			parameters[2].Value = model.UserNumber;
			parameters[3].Value = model.UserPass;
			parameters[4].Value = model.UserXy;
			parameters[5].Value = model.UserZy;
			parameters[6].Value = model.UserBj;
			parameters[7].Value = model.UserAddTime;
			parameters[8].Value = model.UserID;

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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentsInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StudentsInfo ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public SDM.Model.StudentsInfo GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,UserName,UserSex,UserNumber,UserPass,UserXy,UserZy,UserBj,UserAddTime from StudentsInfo ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			SDM.Model.StudentsInfo model=new SDM.Model.StudentsInfo();
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
		public SDM.Model.StudentsInfo DataRowToModel(DataRow row)
		{
			SDM.Model.StudentsInfo model=new SDM.Model.StudentsInfo();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["UserSex"]!=null)
				{
					model.UserSex=row["UserSex"].ToString();
				}
				if(row["UserNumber"]!=null)
				{
					model.UserNumber=row["UserNumber"].ToString();
				}
				if(row["UserPass"]!=null)
				{
					model.UserPass=row["UserPass"].ToString();
				}
				if(row["UserXy"]!=null)
				{
					model.UserXy=row["UserXy"].ToString();
				}
				if(row["UserZy"]!=null)
				{
					model.UserZy=row["UserZy"].ToString();
				}
				if(row["UserBj"]!=null)
				{
					model.UserBj=row["UserBj"].ToString();
				}
				if(row["UserAddTime"]!=null)
				{
					model.UserAddTime=row["UserAddTime"].ToString();
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
			strSql.Append("select UserID,UserName,UserSex,UserNumber,UserPass,UserXy,UserZy,UserBj,UserAddTime ");
			strSql.Append(" FROM StudentsInfo ");
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
			strSql.Append(" UserID,UserName,UserSex,UserNumber,UserPass,UserXy,UserZy,UserBj,UserAddTime ");
			strSql.Append(" FROM StudentsInfo ");
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
			strSql.Append("select count(1) FROM StudentsInfo ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from StudentsInfo T ");
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
			parameters[0].Value = "StudentsInfo";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 管理员添加学生信息15-05-3
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserSex"></param>
        /// <param name="UserNumber"></param>
        /// <param name="UserPass"></param>
        /// <param name="UserXy"></param>
        /// <param name="UserZy"></param>
        /// <param name="UserBj"></param>
        /// <param name="UserAddTime"></param>
        /// <returns></returns>
        public int AddStudentInfoByTrans(string UserName,string UserSex,string UserNumber,string UserPass,string UserXy,string UserZy,string UserBj,string UserAddTime)
        {
            StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StudentsInfo(");
			strSql.Append("UserName,UserSex,UserNumber,UserPass,UserXy,UserZy,UserBj,UserAddTime)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@UserSex,@UserNumber,@UserPass,@UserXy,@UserZy,@UserBj,@UserAddTime)");
            SqlParameter[] par = {new SqlParameter ("@UserName",UserName),
                                 new SqlParameter ("@UserSex",UserSex),
                                 new SqlParameter ("@UserNumber",UserNumber),
                                 new  SqlParameter ("@UserPass",UserPass ),
                                 new SqlParameter ("@UserXy",UserXy),
                                 new SqlParameter ("@UserZy",UserXy),
                                 new SqlParameter ("@UserBj",UserBj),
                                 new SqlParameter ("@UserAddTime",UserAddTime )
                                 };
            return DbHelperSQL.ExecuteSql(strSql.ToString(), par);
        }
		/// <summary>
		/// 检测学号是否唯一，在本系统中允许用户名重复，但学号是唯一！
		/// </summary>
		/// <param name="strUserNumber"></param>
		/// <returns></returns>
		public bool Exists(string strUserNumber)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from StudentsInfo");
			strSql.Append(" where UserNumber=@UserNumber");

			// 创建参数数组，并使用 SqlDbType.VarChar 类型
			SqlParameter[] parameters = {
		new SqlParameter("@UserNumber", SqlDbType.VarChar, 200) // 假设学号长度不超过200
    };
			parameters[0].Value = strUserNumber;

			// 调用 DbHelperSQL.Exists 方法执行查询
			return DbHelperSQL.Exists(strSql.ToString(), parameters);
		}

		/// <summary>
		/// 根据学生姓名查询
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public DataSet GetStudentListByUserName(string username)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from StudentsInfo ");
            sql.Append(" where ");
            sql.Append(" UserName=@username");
            SqlParameter[] par = {new SqlParameter ("@username",username) };
            return DbHelperSQL.Query(sql.ToString(), par);
        }
        /// <summary>
        /// 根据学生院系查询
        /// </summary>
        /// <param name="userxy"></param>
        /// <returns></returns>
        public DataSet GetStudentListByUserXy(string userxy)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from StudentsInfo ");
            sql.Append(" where ");
            sql.Append(" UserXy=@userxy");
            SqlParameter[] par = { new SqlParameter("@userxy", userxy) };
            return DbHelperSQL.Query(sql.ToString(), par);
        }
        /// <summary>
        /// 学生登录
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strPass"></param>
        /// <returns></returns>
        public DataSet GetLogin(string strName, string strPass)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select * from StudentsInfo ");
            strsql.Append(" where ");
            strsql.Append(" UserNumber=@strname and UserPass=@strpass ");
            SqlParameter[] parameter = {new SqlParameter ("@strname",strName ),
                                       new SqlParameter ("@strpass",strPass )
                                       };
            return DbHelperSQL.Query(strsql.ToString(), parameter);
        }
		#endregion  ExtensionMethod
	}
}

