



















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DefaultConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=MY-PC\SQLWEIYANG;Initial Catalog=MvcDataManage;Persist Security Info=True;User ID=sa;password=**zapped**;`
//     Schema:                 ``
//     Include Views:          `True`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace DefaultConnection
{

	public partial class DefaultConnectionDB : Database
	{
		public DefaultConnectionDB() 
			: base("DefaultConnection")
		{
			CommonConstruct();
		}

		public DefaultConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			DefaultConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static DefaultConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new DefaultConnectionDB();
        }

		[ThreadStatic] static DefaultConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static DefaultConnectionDB repo { get { return DefaultConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("ww_Cabinet")]


	[PrimaryKey("CabinetIId")]



	[ExplicitColumns]
    public partial class ww_Cabinet : DefaultConnectionDB.Record<ww_Cabinet>  
    {



		[Column] public int CabinetIId { get; set; }





		[Column] public string Num { get; set; }





		[Column] public bool? BoolNull { get; set; }



	}

    
	[TableName("ww_Suspect")]


	[PrimaryKey("SuspectId")]



	[ExplicitColumns]
    public partial class ww_Suspect : DefaultConnectionDB.Record<ww_Suspect>  
    {



		[Column] public int SuspectId { get; set; }





		[Column] public int? ResID { get; set; }





		[Column] public string SuspectName { get; set; }





		[Column] public string SuspectNum { get; set; }





		[Column] public string SuspectAge { get; set; }





		[Column] public string SuspectSex { get; set; }





		[Column] public string SuspectAdress { get; set; }





		[Column] public string SuspectIdCard { get; set; }



	}

    
	[TableName("ww_Res")]


	[PrimaryKey("ResID")]



	[ExplicitColumns]
    public partial class ww_Re : DefaultConnectionDB.Record<ww_Re>  
    {



		[Column] public int ResID { get; set; }





		[Column] public int? PhotoId { get; set; }





		[Column] public int? CabinetIId { get; set; }





		[Column] public string ResNmae { get; set; }





		[Column] public string ResNum { get; set; }





		[Column] public string ResMess { get; set; }





		[Column] public bool? BoolTansfe { get; set; }



	}

    
	[TableName("ww_Photo")]


	[PrimaryKey("PhotoId")]



	[ExplicitColumns]
    public partial class ww_Photo : DefaultConnectionDB.Record<ww_Photo>  
    {



		[Column] public int PhotoId { get; set; }





		[Column] public int? ResID { get; set; }





		[Column] public string PhotoName { get; set; }





		[Column] public string PhotoNum { get; set; }





		[Column] public string PhotoURL { get; set; }





		[Column] public bool? BoolDel { get; set; }



	}

    
	[TableName("ww_Transfe")]


	[PrimaryKey("TransfeId")]



	[ExplicitColumns]
    public partial class ww_Transfe : DefaultConnectionDB.Record<ww_Transfe>  
    {



		[Column] public int TransfeId { get; set; }





		[Column] public int? ResID { get; set; }





		[Column] public string TransfeUnit { get; set; }





		[Column] public string TransfeDepartment { get; set; }





		[Column] public string TransfePeople { get; set; }





		[Column] public DateTime? TransfeTime { get; set; }





		[Column] public string ReciveUnit { get; set; }





		[Column] public string ReciveDepartment { get; set; }





		[Column] public string RecivePeople { get; set; }





		[Column] public DateTime? ReciveTime { get; set; }





		[Column] public bool? BoolReturn { get; set; }



	}

    
	[TableName("ww_User")]


	[PrimaryKey("UserId")]



	[ExplicitColumns]
    public partial class ww_User : DefaultConnectionDB.Record<ww_User>  
    {



		[Column] public int UserId { get; set; }





		[Column] public int? RoleId { get; set; }





		[Column] public string UserName { get; set; }





		[Column] public string Password { get; set; }





		[Column] public string Department { get; set; }





		[Column] public string IDCard { get; set; }





		[Column] public string ReallName { get; set; }





		[Column] public string Phone { get; set; }





		[Column] public string Email { get; set; }





		[Column] public bool? BoolDel { get; set; }



	}

    
	[TableName("ww_Role")]


	[PrimaryKey("RoleId")]



	[ExplicitColumns]
    public partial class ww_Role : DefaultConnectionDB.Record<ww_Role>  
    {



		[Column] public int RoleId { get; set; }





		[Column] public string RoleName { get; set; }





		[Column] public string RoleNum { get; set; }



	}

    
	[TableName("ww_Operate")]


	[PrimaryKey("OperateId")]



	[ExplicitColumns]
    public partial class ww_Operate : DefaultConnectionDB.Record<ww_Operate>  
    {



		[Column] public int OperateId { get; set; }





		[Column] public string OperateName { get; set; }



	}

    
	[TableName("ww_UserOperate")]


	[PrimaryKey("UserOperateId")]



	[ExplicitColumns]
    public partial class ww_UserOperate : DefaultConnectionDB.Record<ww_UserOperate>  
    {



		[Column] public int UserOperateId { get; set; }





		[Column] public int? UserId { get; set; }





		[Column] public int? OperateId { get; set; }





		[Column] public string Dtime { get; set; }





		[Column] public string IP { get; set; }



	}

    
	[TableName("ww_CaseReason")]


	[PrimaryKey("CaseReasonId")]



	[ExplicitColumns]
    public partial class ww_CaseReason : DefaultConnectionDB.Record<ww_CaseReason>  
    {



		[Column] public int CaseReasonId { get; set; }





		[Column] public int? CaseReasonId_Paent { get; set; }





		[Column] public string CaseReasonName { get; set; }





		[Column] public bool? boolDel { get; set; }



	}

    
	[TableName("ww_Case")]


	[PrimaryKey("CaseId")]



	[ExplicitColumns]
    public partial class ww_Case : DefaultConnectionDB.Record<ww_Case>  
    {



		[Column] public int CaseId { get; set; }





		[Column] public int? ResID { get; set; }





		[Column] public int? CabinetIId { get; set; }





		[Column] public string CaseName { get; set; }





		[Column] public string CaseNum { get; set; }





		[Column] public int? CaseReasonId { get; set; }





		[Column] public string CaseSum { get; set; }



	}


}



