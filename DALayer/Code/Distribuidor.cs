
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
	public abstract class _Distribuidor : SqlClientEntity
	{
		public _Distribuidor()
		{
			this.QuerySource = "Distribuidor";
			this.MappingName = "Distribuidor";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DistribuidorLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_distribuidor)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_distribuidor, Id_distribuidor);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DistribuidorLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Id_distribuidor
			{
				get
				{
					return new SqlParameter("@Id_distribuidor", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Nombre_distribuidor
			{
				get
				{
					return new SqlParameter("@Nombre_distribuidor", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Descripcion
			{
				get
				{
					return new SqlParameter("@Descripcion", SqlDbType.VarChar, 150);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_distribuidor = "id_distribuidor";
            public const string Nombre_distribuidor = "nombre_distribuidor";
            public const string Descripcion = "descripcion";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_distribuidor] = _Distribuidor.PropertyNames.Id_distribuidor;
					ht[Nombre_distribuidor] = _Distribuidor.PropertyNames.Nombre_distribuidor;
					ht[Descripcion] = _Distribuidor.PropertyNames.Descripcion;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_distribuidor = "Id_distribuidor";
            public const string Nombre_distribuidor = "Nombre_distribuidor";
            public const string Descripcion = "Descripcion";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_distribuidor] = _Distribuidor.ColumnNames.Id_distribuidor;
					ht[Nombre_distribuidor] = _Distribuidor.ColumnNames.Nombre_distribuidor;
					ht[Descripcion] = _Distribuidor.ColumnNames.Descripcion;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_distribuidor = "s_Id_distribuidor";
            public const string Nombre_distribuidor = "s_Nombre_distribuidor";
            public const string Descripcion = "s_Descripcion";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_distribuidor
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_distribuidor);
			}
			set
	        {
				base.Setint(ColumnNames.Id_distribuidor, value);
			}
		}

		public virtual string Nombre_distribuidor
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre_distribuidor);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre_distribuidor, value);
			}
		}

		public virtual string Descripcion
	    {
			get
	        {
				return base.Getstring(ColumnNames.Descripcion);
			}
			set
	        {
				base.Setstring(ColumnNames.Descripcion, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_distribuidor
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_distribuidor) ? string.Empty : base.GetintAsString(ColumnNames.Id_distribuidor);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_distribuidor);
				else
					this.Id_distribuidor = base.SetintAsString(ColumnNames.Id_distribuidor, value);
			}
		}

		public virtual string s_Nombre_distribuidor
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre_distribuidor) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_distribuidor);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre_distribuidor);
				else
					this.Nombre_distribuidor = base.SetstringAsString(ColumnNames.Nombre_distribuidor, value);
			}
		}

		public virtual string s_Descripcion
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Descripcion) ? string.Empty : base.GetstringAsString(ColumnNames.Descripcion);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Descripcion);
				else
					this.Descripcion = base.SetstringAsString(ColumnNames.Descripcion, value);
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
				
				
				public WhereParameter Id_distribuidor
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_distribuidor, Parameters.Id_distribuidor);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre_distribuidor
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre_distribuidor, Parameters.Nombre_distribuidor);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Descripcion
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_distribuidor
		    {
				get
		        {
					if(_Id_distribuidor_W == null)
	        	    {
						_Id_distribuidor_W = TearOff.Id_distribuidor;
					}
					return _Id_distribuidor_W;
				}
			}

			public WhereParameter Nombre_distribuidor
		    {
				get
		        {
					if(_Nombre_distribuidor_W == null)
	        	    {
						_Nombre_distribuidor_W = TearOff.Nombre_distribuidor;
					}
					return _Nombre_distribuidor_W;
				}
			}

			public WhereParameter Descripcion
		    {
				get
		        {
					if(_Descripcion_W == null)
	        	    {
						_Descripcion_W = TearOff.Descripcion;
					}
					return _Descripcion_W;
				}
			}

			private WhereParameter _Id_distribuidor_W = null;
			private WhereParameter _Nombre_distribuidor_W = null;
			private WhereParameter _Descripcion_W = null;

			public void WhereClauseReset()
			{
				_Id_distribuidor_W = null;
				_Nombre_distribuidor_W = null;
				_Descripcion_W = null;

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
				
				
				public AggregateParameter Id_distribuidor
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_distribuidor, Parameters.Id_distribuidor);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre_distribuidor
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_distribuidor, Parameters.Nombre_distribuidor);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Descripcion
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Descripcion, Parameters.Descripcion);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_distribuidor
		    {
				get
		        {
					if(_Id_distribuidor_W == null)
	        	    {
						_Id_distribuidor_W = TearOff.Id_distribuidor;
					}
					return _Id_distribuidor_W;
				}
			}

			public AggregateParameter Nombre_distribuidor
		    {
				get
		        {
					if(_Nombre_distribuidor_W == null)
	        	    {
						_Nombre_distribuidor_W = TearOff.Nombre_distribuidor;
					}
					return _Nombre_distribuidor_W;
				}
			}

			public AggregateParameter Descripcion
		    {
				get
		        {
					if(_Descripcion_W == null)
	        	    {
						_Descripcion_W = TearOff.Descripcion;
					}
					return _Descripcion_W;
				}
			}

			private AggregateParameter _Id_distribuidor_W = null;
			private AggregateParameter _Nombre_distribuidor_W = null;
			private AggregateParameter _Descripcion_W = null;

			public void AggregateClauseReset()
			{
				_Id_distribuidor_W = null;
				_Nombre_distribuidor_W = null;
				_Descripcion_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DistribuidorInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Id_distribuidor.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DistribuidorUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DistribuidorDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_distribuidor);
			p.SourceColumn = ColumnNames.Id_distribuidor;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_distribuidor);
			p.SourceColumn = ColumnNames.Id_distribuidor;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre_distribuidor);
			p.SourceColumn = ColumnNames.Nombre_distribuidor;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
