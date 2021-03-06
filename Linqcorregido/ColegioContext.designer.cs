#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linqcorregido
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ColegioDB")]
	public partial class ColegioContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttb_alumno(tb_alumno instance);
    partial void Updatetb_alumno(tb_alumno instance);
    partial void Deletetb_alumno(tb_alumno instance);
    partial void Inserttb_grado(tb_grado instance);
    partial void Updatetb_grado(tb_grado instance);
    partial void Deletetb_grado(tb_grado instance);
    #endregion
		
		public ColegioContextDataContext() : 
				base(global::Linqcorregido.Properties.Settings.Default.ColegioDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_alumno> tb_alumno
		{
			get
			{
				return this.GetTable<tb_alumno>();
			}
		}
		
		public System.Data.Linq.Table<tb_grado> tb_grado
		{
			get
			{
				return this.GetTable<tb_grado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_alumno")]
	public partial class tb_alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombres;
		
		private string _apellidos;
		
		private System.Nullable<int> _calificacion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombresChanging(string value);
    partial void OnnombresChanged();
    partial void OnapellidosChanging(string value);
    partial void OnapellidosChanged();
    partial void OncalificacionChanging(System.Nullable<int> value);
    partial void OncalificacionChanged();
    #endregion
		
		public tb_alumno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombres", DbType="NChar(250)")]
		public string nombres
		{
			get
			{
				return this._nombres;
			}
			set
			{
				if ((this._nombres != value))
				{
					this.OnnombresChanging(value);
					this.SendPropertyChanging();
					this._nombres = value;
					this.SendPropertyChanged("nombres");
					this.OnnombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidos", DbType="NChar(250)")]
		public string apellidos
		{
			get
			{
				return this._apellidos;
			}
			set
			{
				if ((this._apellidos != value))
				{
					this.OnapellidosChanging(value);
					this.SendPropertyChanging();
					this._apellidos = value;
					this.SendPropertyChanged("apellidos");
					this.OnapellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_calificacion", DbType="Int")]
		public System.Nullable<int> calificacion
		{
			get
			{
				return this._calificacion;
			}
			set
			{
				if ((this._calificacion != value))
				{
					this.OncalificacionChanging(value);
					this.SendPropertyChanging();
					this._calificacion = value;
					this.SendPropertyChanged("calificacion");
					this.OncalificacionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_grado")]
	public partial class tb_grado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private string _seccion;
		
		private System.Nullable<int> _capacidad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnseccionChanging(string value);
    partial void OnseccionChanged();
    partial void OncapacidadChanging(System.Nullable<int> value);
    partial void OncapacidadChanged();
    #endregion
		
		public tb_grado()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NChar(250)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seccion", DbType="NChar(50)")]
		public string seccion
		{
			get
			{
				return this._seccion;
			}
			set
			{
				if ((this._seccion != value))
				{
					this.OnseccionChanging(value);
					this.SendPropertyChanging();
					this._seccion = value;
					this.SendPropertyChanged("seccion");
					this.OnseccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_capacidad", DbType="Int")]
		public System.Nullable<int> capacidad
		{
			get
			{
				return this._capacidad;
			}
			set
			{
				if ((this._capacidad != value))
				{
					this.OncapacidadChanging(value);
					this.SendPropertyChanging();
					this._capacidad = value;
					this.SendPropertyChanged("capacidad");
					this.OncapacidadChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
