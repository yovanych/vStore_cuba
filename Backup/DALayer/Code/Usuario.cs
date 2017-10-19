
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DALayer
{
	public abstract class _Usuario : SqlClientEntity
	{
		public _Usuario()
		{
			this.QuerySource = "Usuario";
			this.MappingName = "Usuario";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UsuarioLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_usuario)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_usuario, Id_usuario);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UsuarioLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Id_usuario
			{
				get
				{
					return new SqlParameter("@Id_usuario", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Login
			{
				get
				{
					return new SqlParameter("@Login", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Password
			{
				get
				{
					return new SqlParameter("@Password", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Nombre
			{
				get
				{
					return new SqlParameter("@Nombre", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter Id_role
			{
				get
				{
					return new SqlParameter("@Id_role", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_usuario = "id_usuario";
            public const string Login = "login";
            public const string Password = "password";
            public const string Nombre = "nombre";
            public const string Id_role = "id_role";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_usuario] = _Usuario.PropertyNames.Id_usuario;
					ht[Login] = _Usuario.PropertyNames.Login;
					ht[Password] = _Usuario.PropertyNames.Password;
					ht[Nombre] = _Usuario.PropertyNames.Nombre;
					ht[Id_role] = _Usuario.PropertyNames.Id_role;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_usuario = "Id_usuario";
            public const string Login = "Login";
            public const string Password = "Password";
            public const string Nombre = "Nombre";
            public const string Id_role = "Id_role";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_usuario] = _Usuario.ColumnNames.Id_usuario;
					ht[Login] = _Usuario.ColumnNames.Login;
					ht[Password] = _Usuario.ColumnNames.Password;
					ht[Nombre] = _Usuario.ColumnNames.Nombre;
					ht[Id_role] = _Usuario.ColumnNames.Id_role;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_usuario = "s_Id_usuario";
            public const string Login = "s_Login";
            public const string Password = "s_Password";
            public const string Nombre = "s_Nombre";
            public const string Id_role = "s_Id_role";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_usuario
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_usuario);
			}
			set
	        {
				base.Setint(ColumnNames.Id_usuario, value);
			}
		}

		public virtual string Login
	    {
			get
	        {
				return base.Getstring(ColumnNames.Login);
			}
			set
	        {
				base.Setstring(ColumnNames.Login, value);
			}
		}

		public virtual string Password
	    {
			get
	        {
				return base.Getstring(ColumnNames.Password);
			}
			set
	        {
				base.Setstring(ColumnNames.Password, value);
			}
		}

		public virtual string Nombre
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre, value);
			}
		}

		public virtual int Id_role
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_role);
			}
			set
	        {
				base.Setint(ColumnNames.Id_role, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_usuario
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_usuario) ? string.Empty : base.GetintAsString(ColumnNames.Id_usuario);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_usuario);
				else
					this.Id_usuario = base.SetintAsString(ColumnNames.Id_usuario, value);
			}
		}

		public virtual string s_Login
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Login) ? string.Empty : base.GetstringAsString(ColumnNames.Login);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Login);
				else
					this.Login = base.SetstringAsString(ColumnNames.Login, value);
			}
		}

		public virtual string s_Password
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Password) ? string.Empty : base.GetstringAsString(ColumnNames.Password);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Password);
				else
					this.Password = base.SetstringAsString(ColumnNames.Password, value);
			}
		}

		public virtual string s_Nombre
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre);
				else
					this.Nombre = base.SetstringAsString(ColumnNames.Nombre, value);
			}
		}

		public virtual string s_Id_role
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_role) ? string.Empty : base.GetintAsString(ColumnNames.Id_role);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_role);
				else
					this.Id_role = base.SetintAsString(ColumnNames.Id_role, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter Id_usuario
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Login
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Login, Parameters.Login);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Password
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Password, Parameters.Password);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre, Parameters.Nombre);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Id_role
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_role, Parameters.Id_role);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
				}
			}

			public WhereParameter Login
		    {
				get
		        {
					if(_Login_W == null)
	        	    {
						_Login_W = TearOff.Login;
					}
					return _Login_W;
				}
			}

			public WhereParameter Password
		    {
				get
		        {
					if(_Password_W == null)
	        	    {
						_Password_W = TearOff.Password;
					}
					return _Password_W;
				}
			}

			public WhereParameter Nombre
		    {
				get
		        {
					if(_Nombre_W == null)
	        	    {
						_Nombre_W = TearOff.Nombre;
					}
					return _Nombre_W;
				}
			}

			public WhereParameter Id_role
		    {
				get
		        {
					if(_Id_role_W == null)
	        	    {
						_Id_role_W = TearOff.Id_role;
					}
					return _Id_role_W;
				}
			}

			private WhereParameter _Id_usuario_W = null;
			private WhereParameter _Login_W = null;
			private WhereParameter _Password_W = null;
			private WhereParameter _Nombre_W = null;
			private WhereParameter _Id_role_W = null;

			public void WhereClauseReset()
			{
				_Id_usuario_W = null;
				_Login_W = null;
				_Password_W = null;
				_Nombre_W = null;
				_Id_role_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter Id_usuario
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_usuario, Parameters.Id_usuario);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Login
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Login, Parameters.Login);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Password
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Password, Parameters.Password);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre, Parameters.Nombre);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Id_role
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_role, Parameters.Id_role);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_usuario
		    {
				get
		        {
					if(_Id_usuario_W == null)
	        	    {
						_Id_usuario_W = TearOff.Id_usuario;
					}
					return _Id_usuario_W;
				}
			}

			public AggregateParameter Login
		    {
				get
		        {
					if(_Login_W == null)
	        	    {
						_Login_W = TearOff.Login;
					}
					return _Login_W;
				}
			}

			public AggregateParameter Password
		    {
				get
		        {
					if(_Password_W == null)
	        	    {
						_Password_W = TearOff.Password;
					}
					return _Password_W;
				}
			}

			public AggregateParameter Nombre
		    {
				get
		        {
					if(_Nombre_W == null)
	        	    {
						_Nombre_W = TearOff.Nombre;
					}
					return _Nombre_W;
				}
			}

			public AggregateParameter Id_role
		    {
				get
		        {
					if(_Id_role_W == null)
	        	    {
						_Id_role_W = TearOff.Id_role;
					}
					return _Id_role_W;
				}
			}

			private AggregateParameter _Id_usuario_W = null;
			private AggregateParameter _Login_W = null;
			private AggregateParameter _Password_W = null;
			private AggregateParameter _Nombre_W = null;
			private AggregateParameter _Id_role_W = null;

			public void AggregateClauseReset()
			{
				_Id_usuario_W = null;
				_Login_W = null;
				_Password_W = null;
				_Nombre_W = null;
				_Id_role_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UsuarioInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Id_usuario.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UsuarioUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UsuarioDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_usuario);
			p.SourceColumn = ColumnNames.Id_usuario;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_usuario);
			p.SourceColumn = ColumnNames.Id_usuario;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Login);
			p.SourceColumn = ColumnNames.Login;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Password);
			p.SourceColumn = ColumnNames.Password;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre);
			p.SourceColumn = ColumnNames.Nombre;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_role);
			p.SourceColumn = ColumnNames.Id_role;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
