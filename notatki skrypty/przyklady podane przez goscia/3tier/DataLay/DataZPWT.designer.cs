﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLay
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="testdb2")]
	public partial class DataZPWTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertpracownicy(pracownicy instance);
    partial void Updatepracownicy(pracownicy instance);
    partial void Deletepracownicy(pracownicy instance);
    partial void Inserttematy(tematy instance);
    partial void Updatetematy(tematy instance);
    partial void Deletetematy(tematy instance);
    partial void Insertzespoly(zespoly instance);
    partial void Updatezespoly(zespoly instance);
    partial void Deletezespoly(zespoly instance);
    #endregion
		
		public DataZPWTDataContext() : 
				base(global::DataLay.Properties.Settings.Default.testdb2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataZPWTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataZPWTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataZPWTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataZPWTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<pracownicy> pracownicies
		{
			get
			{
				return this.GetTable<pracownicy>();
			}
		}
		
		public System.Data.Linq.Table<tematy> tematies
		{
			get
			{
				return this.GetTable<tematy>();
			}
		}
		
		public System.Data.Linq.Table<zespoly> zespolies
		{
			get
			{
				return this.GetTable<zespoly>();
			}
		}
		
		public System.Data.Linq.Table<wyplaty> wyplaties
		{
			get
			{
				return this.GetTable<wyplaty>();
			}
		}
		
		public System.Data.Linq.Table<studenci> studencis
		{
			get
			{
				return this.GetTable<studenci>();
			}
		}
		
		public System.Data.Linq.Table<przydzialy> przydzialies
		{
			get
			{
				return this.GetTable<przydzialy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pracownicy")]
	public partial class pracownicy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NR_PRAC;
		
		private char _PLEC;
		
		private System.Nullable<System.DateTime> _DATA_UR;
		
		private string _NAZWISKO;
		
		private short _NR_ZESP;
		
		private EntitySet<zespoly> _zespolies;
		
		private EntityRef<zespoly> _zespoly;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNR_PRACChanging(int value);
    partial void OnNR_PRACChanged();
    partial void OnPLECChanging(char value);
    partial void OnPLECChanged();
    partial void OnDATA_URChanging(System.Nullable<System.DateTime> value);
    partial void OnDATA_URChanged();
    partial void OnNAZWISKOChanging(string value);
    partial void OnNAZWISKOChanged();
    partial void OnNR_ZESPChanging(short value);
    partial void OnNR_ZESPChanged();
    #endregion
		
		public pracownicy()
		{
			this._zespolies = new EntitySet<zespoly>(new Action<zespoly>(this.attach_zespolies), new Action<zespoly>(this.detach_zespolies));
			this._zespoly = default(EntityRef<zespoly>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_PRAC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NR_PRAC
		{
			get
			{
				return this._NR_PRAC;
			}
			set
			{
				if ((this._NR_PRAC != value))
				{
					this.OnNR_PRACChanging(value);
					this.SendPropertyChanging();
					this._NR_PRAC = value;
					this.SendPropertyChanged("NR_PRAC");
					this.OnNR_PRACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLEC", DbType="Char(1) NOT NULL")]
		public char PLEC
		{
			get
			{
				return this._PLEC;
			}
			set
			{
				if ((this._PLEC != value))
				{
					this.OnPLECChanging(value);
					this.SendPropertyChanging();
					this._PLEC = value;
					this.SendPropertyChanged("PLEC");
					this.OnPLECChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_UR", DbType="DateTime")]
		public System.Nullable<System.DateTime> DATA_UR
		{
			get
			{
				return this._DATA_UR;
			}
			set
			{
				if ((this._DATA_UR != value))
				{
					this.OnDATA_URChanging(value);
					this.SendPropertyChanging();
					this._DATA_UR = value;
					this.SendPropertyChanged("DATA_UR");
					this.OnDATA_URChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAZWISKO", DbType="NVarChar(50)")]
		public string NAZWISKO
		{
			get
			{
				return this._NAZWISKO;
			}
			set
			{
				if ((this._NAZWISKO != value))
				{
					this.OnNAZWISKOChanging(value);
					this.SendPropertyChanging();
					this._NAZWISKO = value;
					this.SendPropertyChanged("NAZWISKO");
					this.OnNAZWISKOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_ZESP", DbType="SmallInt NOT NULL")]
		public short NR_ZESP
		{
			get
			{
				return this._NR_ZESP;
			}
			set
			{
				if ((this._NR_ZESP != value))
				{
					if (this._zespoly.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNR_ZESPChanging(value);
					this.SendPropertyChanging();
					this._NR_ZESP = value;
					this.SendPropertyChanged("NR_ZESP");
					this.OnNR_ZESPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownicy_zespoly", Storage="_zespolies", ThisKey="NR_PRAC", OtherKey="NR_PRAC_KZ")]
		public EntitySet<zespoly> zespolies
		{
			get
			{
				return this._zespolies;
			}
			set
			{
				this._zespolies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="zespoly_pracownicy", Storage="_zespoly", ThisKey="NR_ZESP", OtherKey="NR_ZESP", IsForeignKey=true)]
		public zespoly zespoly
		{
			get
			{
				return this._zespoly.Entity;
			}
			set
			{
				zespoly previousValue = this._zespoly.Entity;
				if (((previousValue != value) 
							|| (this._zespoly.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._zespoly.Entity = null;
						previousValue.pracownicies.Remove(this);
					}
					this._zespoly.Entity = value;
					if ((value != null))
					{
						value.pracownicies.Add(this);
						this._NR_ZESP = value.NR_ZESP;
					}
					else
					{
						this._NR_ZESP = default(short);
					}
					this.SendPropertyChanged("zespoly");
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
		
		private void attach_zespolies(zespoly entity)
		{
			this.SendPropertyChanging();
			entity.pracownicy = this;
		}
		
		private void detach_zespolies(zespoly entity)
		{
			this.SendPropertyChanging();
			entity.pracownicy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tematy")]
	public partial class tematy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NR_TEM;
		
		private string _TEMAT;
		
		private System.Nullable<System.DateTime> _DATA_ROZP;
		
		private int _NR_PRAC_KT;
		
		private System.Nullable<int> _NR_TEM_NADRZ;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNR_TEMChanging(int value);
    partial void OnNR_TEMChanged();
    partial void OnTEMATChanging(string value);
    partial void OnTEMATChanged();
    partial void OnDATA_ROZPChanging(System.Nullable<System.DateTime> value);
    partial void OnDATA_ROZPChanged();
    partial void OnNR_PRAC_KTChanging(int value);
    partial void OnNR_PRAC_KTChanged();
    partial void OnNR_TEM_NADRZChanging(System.Nullable<int> value);
    partial void OnNR_TEM_NADRZChanged();
    #endregion
		
		public tematy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_TEM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int NR_TEM
		{
			get
			{
				return this._NR_TEM;
			}
			set
			{
				if ((this._NR_TEM != value))
				{
					this.OnNR_TEMChanging(value);
					this.SendPropertyChanging();
					this._NR_TEM = value;
					this.SendPropertyChanged("NR_TEM");
					this.OnNR_TEMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEMAT", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TEMAT
		{
			get
			{
				return this._TEMAT;
			}
			set
			{
				if ((this._TEMAT != value))
				{
					this.OnTEMATChanging(value);
					this.SendPropertyChanging();
					this._TEMAT = value;
					this.SendPropertyChanged("TEMAT");
					this.OnTEMATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_ROZP", DbType="DateTime")]
		public System.Nullable<System.DateTime> DATA_ROZP
		{
			get
			{
				return this._DATA_ROZP;
			}
			set
			{
				if ((this._DATA_ROZP != value))
				{
					this.OnDATA_ROZPChanging(value);
					this.SendPropertyChanging();
					this._DATA_ROZP = value;
					this.SendPropertyChanged("DATA_ROZP");
					this.OnDATA_ROZPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_PRAC_KT", DbType="Int NOT NULL")]
		public int NR_PRAC_KT
		{
			get
			{
				return this._NR_PRAC_KT;
			}
			set
			{
				if ((this._NR_PRAC_KT != value))
				{
					this.OnNR_PRAC_KTChanging(value);
					this.SendPropertyChanging();
					this._NR_PRAC_KT = value;
					this.SendPropertyChanged("NR_PRAC_KT");
					this.OnNR_PRAC_KTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_TEM_NADRZ", DbType="Int")]
		public System.Nullable<int> NR_TEM_NADRZ
		{
			get
			{
				return this._NR_TEM_NADRZ;
			}
			set
			{
				if ((this._NR_TEM_NADRZ != value))
				{
					this.OnNR_TEM_NADRZChanging(value);
					this.SendPropertyChanging();
					this._NR_TEM_NADRZ = value;
					this.SendPropertyChanged("NR_TEM_NADRZ");
					this.OnNR_TEM_NADRZChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zespoly")]
	public partial class zespoly : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _NR_ZESP;
		
		private string _NAZWA_ZESP;
		
		private int _NR_PRAC_KZ;
		
		private short _NR_INST;
		
		private EntitySet<pracownicy> _pracownicies;
		
		private EntityRef<pracownicy> _pracownicy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNR_ZESPChanging(short value);
    partial void OnNR_ZESPChanged();
    partial void OnNAZWA_ZESPChanging(string value);
    partial void OnNAZWA_ZESPChanged();
    partial void OnNR_PRAC_KZChanging(int value);
    partial void OnNR_PRAC_KZChanged();
    partial void OnNR_INSTChanging(short value);
    partial void OnNR_INSTChanged();
    #endregion
		
		public zespoly()
		{
			this._pracownicies = new EntitySet<pracownicy>(new Action<pracownicy>(this.attach_pracownicies), new Action<pracownicy>(this.detach_pracownicies));
			this._pracownicy = default(EntityRef<pracownicy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_ZESP", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short NR_ZESP
		{
			get
			{
				return this._NR_ZESP;
			}
			set
			{
				if ((this._NR_ZESP != value))
				{
					this.OnNR_ZESPChanging(value);
					this.SendPropertyChanging();
					this._NR_ZESP = value;
					this.SendPropertyChanged("NR_ZESP");
					this.OnNR_ZESPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAZWA_ZESP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NAZWA_ZESP
		{
			get
			{
				return this._NAZWA_ZESP;
			}
			set
			{
				if ((this._NAZWA_ZESP != value))
				{
					this.OnNAZWA_ZESPChanging(value);
					this.SendPropertyChanging();
					this._NAZWA_ZESP = value;
					this.SendPropertyChanged("NAZWA_ZESP");
					this.OnNAZWA_ZESPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_PRAC_KZ", DbType="Int NOT NULL")]
		public int NR_PRAC_KZ
		{
			get
			{
				return this._NR_PRAC_KZ;
			}
			set
			{
				if ((this._NR_PRAC_KZ != value))
				{
					if (this._pracownicy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNR_PRAC_KZChanging(value);
					this.SendPropertyChanging();
					this._NR_PRAC_KZ = value;
					this.SendPropertyChanged("NR_PRAC_KZ");
					this.OnNR_PRAC_KZChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_INST", DbType="SmallInt NOT NULL")]
		public short NR_INST
		{
			get
			{
				return this._NR_INST;
			}
			set
			{
				if ((this._NR_INST != value))
				{
					this.OnNR_INSTChanging(value);
					this.SendPropertyChanging();
					this._NR_INST = value;
					this.SendPropertyChanged("NR_INST");
					this.OnNR_INSTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="zespoly_pracownicy", Storage="_pracownicies", ThisKey="NR_ZESP", OtherKey="NR_ZESP")]
		public EntitySet<pracownicy> pracownicies
		{
			get
			{
				return this._pracownicies;
			}
			set
			{
				this._pracownicies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="pracownicy_zespoly", Storage="_pracownicy", ThisKey="NR_PRAC_KZ", OtherKey="NR_PRAC", IsForeignKey=true)]
		public pracownicy pracownicy
		{
			get
			{
				return this._pracownicy.Entity;
			}
			set
			{
				pracownicy previousValue = this._pracownicy.Entity;
				if (((previousValue != value) 
							|| (this._pracownicy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._pracownicy.Entity = null;
						previousValue.zespolies.Remove(this);
					}
					this._pracownicy.Entity = value;
					if ((value != null))
					{
						value.zespolies.Add(this);
						this._NR_PRAC_KZ = value.NR_PRAC;
					}
					else
					{
						this._NR_PRAC_KZ = default(int);
					}
					this.SendPropertyChanged("pracownicy");
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
		
		private void attach_pracownicies(pracownicy entity)
		{
			this.SendPropertyChanging();
			entity.zespoly = this;
		}
		
		private void detach_pracownicies(pracownicy entity)
		{
			this.SendPropertyChanging();
			entity.zespoly = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wyplaty")]
	public partial class wyplaty
	{
		
		private int _NR_PRAC;
		
		private int _NR_TEM;
		
		private System.DateTime _DATA_NALICZ;
		
		private decimal _KWOTA;
		
		public wyplaty()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_PRAC", DbType="Int NOT NULL")]
		public int NR_PRAC
		{
			get
			{
				return this._NR_PRAC;
			}
			set
			{
				if ((this._NR_PRAC != value))
				{
					this._NR_PRAC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_TEM", DbType="Int NOT NULL")]
		public int NR_TEM
		{
			get
			{
				return this._NR_TEM;
			}
			set
			{
				if ((this._NR_TEM != value))
				{
					this._NR_TEM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_NALICZ", DbType="DateTime NOT NULL")]
		public System.DateTime DATA_NALICZ
		{
			get
			{
				return this._DATA_NALICZ;
			}
			set
			{
				if ((this._DATA_NALICZ != value))
				{
					this._DATA_NALICZ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KWOTA", DbType="Decimal(10,1) NOT NULL")]
		public decimal KWOTA
		{
			get
			{
				return this._KWOTA;
			}
			set
			{
				if ((this._KWOTA != value))
				{
					this._KWOTA = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.studenci")]
	public partial class studenci
	{
		
		private short _NR_STUD;
		
		private string _NAZWISKO;
		
		private System.DateTime _DATA_UR;
		
		private char _PLEC;
		
		private short _NR_KIER;
		
		public studenci()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_STUD", DbType="SmallInt NOT NULL")]
		public short NR_STUD
		{
			get
			{
				return this._NR_STUD;
			}
			set
			{
				if ((this._NR_STUD != value))
				{
					this._NR_STUD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAZWISKO", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string NAZWISKO
		{
			get
			{
				return this._NAZWISKO;
			}
			set
			{
				if ((this._NAZWISKO != value))
				{
					this._NAZWISKO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATA_UR", DbType="DateTime NOT NULL")]
		public System.DateTime DATA_UR
		{
			get
			{
				return this._DATA_UR;
			}
			set
			{
				if ((this._DATA_UR != value))
				{
					this._DATA_UR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PLEC", DbType="Char(1) NOT NULL")]
		public char PLEC
		{
			get
			{
				return this._PLEC;
			}
			set
			{
				if ((this._PLEC != value))
				{
					this._PLEC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_KIER", DbType="SmallInt NOT NULL")]
		public short NR_KIER
		{
			get
			{
				return this._NR_KIER;
			}
			set
			{
				if ((this._NR_KIER != value))
				{
					this._NR_KIER = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.przydzialy")]
	public partial class przydzialy
	{
		
		private int _NR_PRAC;
		
		private int _NR_TEM;
		
		private string _KOD_FUNKCJI;
		
		public przydzialy()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_PRAC", DbType="Int NOT NULL")]
		public int NR_PRAC
		{
			get
			{
				return this._NR_PRAC;
			}
			set
			{
				if ((this._NR_PRAC != value))
				{
					this._NR_PRAC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NR_TEM", DbType="Int NOT NULL")]
		public int NR_TEM
		{
			get
			{
				return this._NR_TEM;
			}
			set
			{
				if ((this._NR_TEM != value))
				{
					this._NR_TEM = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KOD_FUNKCJI", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string KOD_FUNKCJI
		{
			get
			{
				return this._KOD_FUNKCJI;
			}
			set
			{
				if ((this._KOD_FUNKCJI != value))
				{
					this._KOD_FUNKCJI = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
