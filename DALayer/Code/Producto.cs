
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
	public abstract class _Producto : SqlClientEntity
	{
		public _Producto()
		{
			this.QuerySource = "Producto";
			this.MappingName = "Producto";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductoLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Id_producto)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Id_producto, Id_producto);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductoLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Id_producto
			{
				get
				{
					return new SqlParameter("@Id_producto", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Codigo
			{
				get
				{
					return new SqlParameter("@Codigo", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Nombre_producto
			{
				get
				{
					return new SqlParameter("@Nombre_producto", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Descripcion
			{
				get
				{
					return new SqlParameter("@Descripcion", SqlDbType.VarChar, 150);
				}
			}
			
			public static SqlParameter Id_categoria
			{
				get
				{
					return new SqlParameter("@Id_categoria", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Foto
			{
				get
				{
					return new SqlParameter("@Foto", SqlDbType.Image, 2147483647);
				}
			}
			
			public static SqlParameter Precio
			{
				get
				{
					return new SqlParameter("@Precio", SqlDbType.Money, 0);
				}
			}
			
			public static SqlParameter Existencia
			{
				get
				{
					return new SqlParameter("@Existencia", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Marca
			{
				get
				{
					return new SqlParameter("@Marca", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Vitrina
			{
				get
				{
					return new SqlParameter("@Vitrina", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Ventas
			{
				get
				{
					return new SqlParameter("@Ventas", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Id_producto = "id_producto";
            public const string Codigo = "codigo";
            public const string Nombre_producto = "nombre_producto";
            public const string Descripcion = "descripcion";
            public const string Id_categoria = "id_categoria";
            public const string Foto = "foto";
            public const string Precio = "precio";
            public const string Existencia = "existencia";
            public const string Marca = "marca";
            public const string Vitrina = "vitrina";
            public const string Ventas = "ventas";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_producto] = _Producto.PropertyNames.Id_producto;
					ht[Codigo] = _Producto.PropertyNames.Codigo;
					ht[Nombre_producto] = _Producto.PropertyNames.Nombre_producto;
					ht[Descripcion] = _Producto.PropertyNames.Descripcion;
					ht[Id_categoria] = _Producto.PropertyNames.Id_categoria;
					ht[Foto] = _Producto.PropertyNames.Foto;
					ht[Precio] = _Producto.PropertyNames.Precio;
					ht[Existencia] = _Producto.PropertyNames.Existencia;
					ht[Marca] = _Producto.PropertyNames.Marca;
					ht[Vitrina] = _Producto.PropertyNames.Vitrina;
					ht[Ventas] = _Producto.PropertyNames.Ventas;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Id_producto = "Id_producto";
            public const string Codigo = "Codigo";
            public const string Nombre_producto = "Nombre_producto";
            public const string Descripcion = "Descripcion";
            public const string Id_categoria = "Id_categoria";
            public const string Foto = "Foto";
            public const string Precio = "Precio";
            public const string Existencia = "Existencia";
            public const string Marca = "Marca";
            public const string Vitrina = "Vitrina";
            public const string Ventas = "Ventas";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Id_producto] = _Producto.ColumnNames.Id_producto;
					ht[Codigo] = _Producto.ColumnNames.Codigo;
					ht[Nombre_producto] = _Producto.ColumnNames.Nombre_producto;
					ht[Descripcion] = _Producto.ColumnNames.Descripcion;
					ht[Id_categoria] = _Producto.ColumnNames.Id_categoria;
					ht[Foto] = _Producto.ColumnNames.Foto;
					ht[Precio] = _Producto.ColumnNames.Precio;
					ht[Existencia] = _Producto.ColumnNames.Existencia;
					ht[Marca] = _Producto.ColumnNames.Marca;
					ht[Vitrina] = _Producto.ColumnNames.Vitrina;
					ht[Ventas] = _Producto.ColumnNames.Ventas;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Id_producto = "s_Id_producto";
            public const string Codigo = "s_Codigo";
            public const string Nombre_producto = "s_Nombre_producto";
            public const string Descripcion = "s_Descripcion";
            public const string Id_categoria = "s_Id_categoria";
            public const string Precio = "s_Precio";
            public const string Existencia = "s_Existencia";
            public const string Marca = "s_Marca";
            public const string Vitrina = "s_Vitrina";
            public const string Ventas = "s_Ventas";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Id_producto
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_producto);
			}
			set
	        {
				base.Setint(ColumnNames.Id_producto, value);
			}
		}

		public virtual string Codigo
	    {
			get
	        {
				return base.Getstring(ColumnNames.Codigo);
			}
			set
	        {
				base.Setstring(ColumnNames.Codigo, value);
			}
		}

		public virtual string Nombre_producto
	    {
			get
	        {
				return base.Getstring(ColumnNames.Nombre_producto);
			}
			set
	        {
				base.Setstring(ColumnNames.Nombre_producto, value);
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

		public virtual int Id_categoria
	    {
			get
	        {
				return base.Getint(ColumnNames.Id_categoria);
			}
			set
	        {
				base.Setint(ColumnNames.Id_categoria, value);
			}
		}

		public virtual byte[] Foto
	    {
			get
	        {
				return base.GetByteArray(ColumnNames.Foto);
			}
			set
	        {
				base.SetByteArray(ColumnNames.Foto, value);
			}
		}

		public virtual decimal Precio
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Precio);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Precio, value);
			}
		}

		public virtual int Existencia
	    {
			get
	        {
				return base.Getint(ColumnNames.Existencia);
			}
			set
	        {
				base.Setint(ColumnNames.Existencia, value);
			}
		}

		public virtual string Marca
	    {
			get
	        {
				return base.Getstring(ColumnNames.Marca);
			}
			set
	        {
				base.Setstring(ColumnNames.Marca, value);
			}
		}

		public virtual bool Vitrina
	    {
			get
	        {
				return base.Getbool(ColumnNames.Vitrina);
			}
			set
	        {
				base.Setbool(ColumnNames.Vitrina, value);
			}
		}

		public virtual int Ventas
	    {
			get
	        {
				return base.Getint(ColumnNames.Ventas);
			}
			set
	        {
				base.Setint(ColumnNames.Ventas, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Id_producto
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_producto) ? string.Empty : base.GetintAsString(ColumnNames.Id_producto);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_producto);
				else
					this.Id_producto = base.SetintAsString(ColumnNames.Id_producto, value);
			}
		}

		public virtual string s_Codigo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Codigo) ? string.Empty : base.GetstringAsString(ColumnNames.Codigo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Codigo);
				else
					this.Codigo = base.SetstringAsString(ColumnNames.Codigo, value);
			}
		}

		public virtual string s_Nombre_producto
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Nombre_producto) ? string.Empty : base.GetstringAsString(ColumnNames.Nombre_producto);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Nombre_producto);
				else
					this.Nombre_producto = base.SetstringAsString(ColumnNames.Nombre_producto, value);
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

		public virtual string s_Id_categoria
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Id_categoria) ? string.Empty : base.GetintAsString(ColumnNames.Id_categoria);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Id_categoria);
				else
					this.Id_categoria = base.SetintAsString(ColumnNames.Id_categoria, value);
			}
		}

		public virtual string s_Precio
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Precio) ? string.Empty : base.GetdecimalAsString(ColumnNames.Precio);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Precio);
				else
					this.Precio = base.SetdecimalAsString(ColumnNames.Precio, value);
			}
		}

		public virtual string s_Existencia
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Existencia) ? string.Empty : base.GetintAsString(ColumnNames.Existencia);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Existencia);
				else
					this.Existencia = base.SetintAsString(ColumnNames.Existencia, value);
			}
		}

		public virtual string s_Marca
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Marca) ? string.Empty : base.GetstringAsString(ColumnNames.Marca);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Marca);
				else
					this.Marca = base.SetstringAsString(ColumnNames.Marca, value);
			}
		}

		public virtual string s_Vitrina
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Vitrina) ? string.Empty : base.GetboolAsString(ColumnNames.Vitrina);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Vitrina);
				else
					this.Vitrina = base.SetboolAsString(ColumnNames.Vitrina, value);
			}
		}

		public virtual string s_Ventas
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ventas) ? string.Empty : base.GetintAsString(ColumnNames.Ventas);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ventas);
				else
					this.Ventas = base.SetintAsString(ColumnNames.Ventas, value);
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
				
				
				public WhereParameter Id_producto
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_producto, Parameters.Id_producto);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Codigo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Codigo, Parameters.Codigo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Nombre_producto
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Nombre_producto, Parameters.Nombre_producto);
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

				public WhereParameter Id_categoria
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Id_categoria, Parameters.Id_categoria);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Foto
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Foto, Parameters.Foto);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Precio
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Precio, Parameters.Precio);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Existencia
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Existencia, Parameters.Existencia);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Marca
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Marca, Parameters.Marca);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Vitrina
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Vitrina, Parameters.Vitrina);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ventas
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ventas, Parameters.Ventas);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Id_producto
		    {
				get
		        {
					if(_Id_producto_W == null)
	        	    {
						_Id_producto_W = TearOff.Id_producto;
					}
					return _Id_producto_W;
				}
			}

			public WhereParameter Codigo
		    {
				get
		        {
					if(_Codigo_W == null)
	        	    {
						_Codigo_W = TearOff.Codigo;
					}
					return _Codigo_W;
				}
			}

			public WhereParameter Nombre_producto
		    {
				get
		        {
					if(_Nombre_producto_W == null)
	        	    {
						_Nombre_producto_W = TearOff.Nombre_producto;
					}
					return _Nombre_producto_W;
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

			public WhereParameter Id_categoria
		    {
				get
		        {
					if(_Id_categoria_W == null)
	        	    {
						_Id_categoria_W = TearOff.Id_categoria;
					}
					return _Id_categoria_W;
				}
			}

			public WhereParameter Foto
		    {
				get
		        {
					if(_Foto_W == null)
	        	    {
						_Foto_W = TearOff.Foto;
					}
					return _Foto_W;
				}
			}

			public WhereParameter Precio
		    {
				get
		        {
					if(_Precio_W == null)
	        	    {
						_Precio_W = TearOff.Precio;
					}
					return _Precio_W;
				}
			}

			public WhereParameter Existencia
		    {
				get
		        {
					if(_Existencia_W == null)
	        	    {
						_Existencia_W = TearOff.Existencia;
					}
					return _Existencia_W;
				}
			}

			public WhereParameter Marca
		    {
				get
		        {
					if(_Marca_W == null)
	        	    {
						_Marca_W = TearOff.Marca;
					}
					return _Marca_W;
				}
			}

			public WhereParameter Vitrina
		    {
				get
		        {
					if(_Vitrina_W == null)
	        	    {
						_Vitrina_W = TearOff.Vitrina;
					}
					return _Vitrina_W;
				}
			}

			public WhereParameter Ventas
		    {
				get
		        {
					if(_Ventas_W == null)
	        	    {
						_Ventas_W = TearOff.Ventas;
					}
					return _Ventas_W;
				}
			}

			private WhereParameter _Id_producto_W = null;
			private WhereParameter _Codigo_W = null;
			private WhereParameter _Nombre_producto_W = null;
			private WhereParameter _Descripcion_W = null;
			private WhereParameter _Id_categoria_W = null;
			private WhereParameter _Foto_W = null;
			private WhereParameter _Precio_W = null;
			private WhereParameter _Existencia_W = null;
			private WhereParameter _Marca_W = null;
			private WhereParameter _Vitrina_W = null;
			private WhereParameter _Ventas_W = null;

			public void WhereClauseReset()
			{
				_Id_producto_W = null;
				_Codigo_W = null;
				_Nombre_producto_W = null;
				_Descripcion_W = null;
				_Id_categoria_W = null;
				_Foto_W = null;
				_Precio_W = null;
				_Existencia_W = null;
				_Marca_W = null;
				_Vitrina_W = null;
				_Ventas_W = null;

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
				
				
				public AggregateParameter Id_producto
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_producto, Parameters.Id_producto);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Codigo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Codigo, Parameters.Codigo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Nombre_producto
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Nombre_producto, Parameters.Nombre_producto);
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

				public AggregateParameter Id_categoria
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Id_categoria, Parameters.Id_categoria);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Foto
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Foto, Parameters.Foto);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Precio
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Precio, Parameters.Precio);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Existencia
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Existencia, Parameters.Existencia);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Marca
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Marca, Parameters.Marca);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Vitrina
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Vitrina, Parameters.Vitrina);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ventas
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ventas, Parameters.Ventas);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Id_producto
		    {
				get
		        {
					if(_Id_producto_W == null)
	        	    {
						_Id_producto_W = TearOff.Id_producto;
					}
					return _Id_producto_W;
				}
			}

			public AggregateParameter Codigo
		    {
				get
		        {
					if(_Codigo_W == null)
	        	    {
						_Codigo_W = TearOff.Codigo;
					}
					return _Codigo_W;
				}
			}

			public AggregateParameter Nombre_producto
		    {
				get
		        {
					if(_Nombre_producto_W == null)
	        	    {
						_Nombre_producto_W = TearOff.Nombre_producto;
					}
					return _Nombre_producto_W;
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

			public AggregateParameter Id_categoria
		    {
				get
		        {
					if(_Id_categoria_W == null)
	        	    {
						_Id_categoria_W = TearOff.Id_categoria;
					}
					return _Id_categoria_W;
				}
			}

			public AggregateParameter Foto
		    {
				get
		        {
					if(_Foto_W == null)
	        	    {
						_Foto_W = TearOff.Foto;
					}
					return _Foto_W;
				}
			}

			public AggregateParameter Precio
		    {
				get
		        {
					if(_Precio_W == null)
	        	    {
						_Precio_W = TearOff.Precio;
					}
					return _Precio_W;
				}
			}

			public AggregateParameter Existencia
		    {
				get
		        {
					if(_Existencia_W == null)
	        	    {
						_Existencia_W = TearOff.Existencia;
					}
					return _Existencia_W;
				}
			}

			public AggregateParameter Marca
		    {
				get
		        {
					if(_Marca_W == null)
	        	    {
						_Marca_W = TearOff.Marca;
					}
					return _Marca_W;
				}
			}

			public AggregateParameter Vitrina
		    {
				get
		        {
					if(_Vitrina_W == null)
	        	    {
						_Vitrina_W = TearOff.Vitrina;
					}
					return _Vitrina_W;
				}
			}

			public AggregateParameter Ventas
		    {
				get
		        {
					if(_Ventas_W == null)
	        	    {
						_Ventas_W = TearOff.Ventas;
					}
					return _Ventas_W;
				}
			}

			private AggregateParameter _Id_producto_W = null;
			private AggregateParameter _Codigo_W = null;
			private AggregateParameter _Nombre_producto_W = null;
			private AggregateParameter _Descripcion_W = null;
			private AggregateParameter _Id_categoria_W = null;
			private AggregateParameter _Foto_W = null;
			private AggregateParameter _Precio_W = null;
			private AggregateParameter _Existencia_W = null;
			private AggregateParameter _Marca_W = null;
			private AggregateParameter _Vitrina_W = null;
			private AggregateParameter _Ventas_W = null;

			public void AggregateClauseReset()
			{
				_Id_producto_W = null;
				_Codigo_W = null;
				_Nombre_producto_W = null;
				_Descripcion_W = null;
				_Id_categoria_W = null;
				_Foto_W = null;
				_Precio_W = null;
				_Existencia_W = null;
				_Marca_W = null;
				_Vitrina_W = null;
				_Ventas_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductoInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.Id_producto.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductoUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductoDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Id_producto);
			p.SourceColumn = ColumnNames.Id_producto;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Id_producto);
			p.SourceColumn = ColumnNames.Id_producto;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Codigo);
			p.SourceColumn = ColumnNames.Codigo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Nombre_producto);
			p.SourceColumn = ColumnNames.Nombre_producto;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Descripcion);
			p.SourceColumn = ColumnNames.Descripcion;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Id_categoria);
			p.SourceColumn = ColumnNames.Id_categoria;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Foto);
			p.SourceColumn = ColumnNames.Foto;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Precio);
			p.SourceColumn = ColumnNames.Precio;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Existencia);
			p.SourceColumn = ColumnNames.Existencia;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Marca);
			p.SourceColumn = ColumnNames.Marca;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Vitrina);
			p.SourceColumn = ColumnNames.Vitrina;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Ventas);
			p.SourceColumn = ColumnNames.Ventas;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
