﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_21")]
public partial class LqDBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Inserttb_userInfo(tb_userInfo instance);
  partial void Updatetb_userInfo(tb_userInfo instance);
  partial void Deletetb_userInfo(tb_userInfo instance);
  partial void InsertPhoto(Photo instance);
  partial void UpdatePhoto(Photo instance);
  partial void DeletePhoto(Photo instance);
  partial void InsertPhoto_Category(Photo_Category instance);
  partial void UpdatePhoto_Category(Photo_Category instance);
  partial void DeletePhoto_Category(Photo_Category instance);
  #endregion
	
	public LqDBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db_21ConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public LqDBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LqDBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LqDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LqDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<tb_userInfo> tb_userInfo
	{
		get
		{
			return this.GetTable<tb_userInfo>();
		}
	}
	
	public System.Data.Linq.Table<Photo> Photo
	{
		get
		{
			return this.GetTable<Photo>();
		}
	}
	
	public System.Data.Linq.Table<Photo_Category> Photo_Category
	{
		get
		{
			return this.GetTable<Photo_Category>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_userInfo")]
public partial class tb_userInfo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _userName;
	
	private string _userPass;
	
	private string _nickName;
	
	private string _sex;
	
	private string _emaile;
	
	private string _city;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnuserPassChanging(string value);
    partial void OnuserPassChanged();
    partial void OnnickNameChanging(string value);
    partial void OnnickNameChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OnemaileChanging(string value);
    partial void OnemaileChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    #endregion
	
	public tb_userInfo()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(20)")]
	public string userName
	{
		get
		{
			return this._userName;
		}
		set
		{
			if ((this._userName != value))
			{
				this.OnuserNameChanging(value);
				this.SendPropertyChanging();
				this._userName = value;
				this.SendPropertyChanged("userName");
				this.OnuserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userPass", DbType="VarChar(50)")]
	public string userPass
	{
		get
		{
			return this._userPass;
		}
		set
		{
			if ((this._userPass != value))
			{
				this.OnuserPassChanging(value);
				this.SendPropertyChanging();
				this._userPass = value;
				this.SendPropertyChanged("userPass");
				this.OnuserPassChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nickName", DbType="VarChar(20)")]
	public string nickName
	{
		get
		{
			return this._nickName;
		}
		set
		{
			if ((this._nickName != value))
			{
				this.OnnickNameChanging(value);
				this.SendPropertyChanging();
				this._nickName = value;
				this.SendPropertyChanged("nickName");
				this.OnnickNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="Char(10)")]
	public string sex
	{
		get
		{
			return this._sex;
		}
		set
		{
			if ((this._sex != value))
			{
				this.OnsexChanging(value);
				this.SendPropertyChanging();
				this._sex = value;
				this.SendPropertyChanged("sex");
				this.OnsexChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emaile", DbType="VarChar(50)")]
	public string emaile
	{
		get
		{
			return this._emaile;
		}
		set
		{
			if ((this._emaile != value))
			{
				this.OnemaileChanging(value);
				this.SendPropertyChanging();
				this._emaile = value;
				this.SendPropertyChanged("emaile");
				this.OnemaileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50)")]
	public string city
	{
		get
		{
			return this._city;
		}
		set
		{
			if ((this._city != value))
			{
				this.OncityChanging(value);
				this.SendPropertyChanging();
				this._city = value;
				this.SendPropertyChanged("city");
				this.OncityChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Photo")]
public partial class Photo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Title;
	
	private string _Descript;
	
	private string _Url;
	
	private System.Nullable<System.DateTime> _AddDate;
	
	private string _P_Type;
	
	private System.Nullable<int> _P_Size;
	
	private System.Nullable<int> _CategoryID;
	
	private EntityRef<Photo_Category> _Photo_Category;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptChanging(string value);
    partial void OnDescriptChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnAddDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAddDateChanged();
    partial void OnP_TypeChanging(string value);
    partial void OnP_TypeChanged();
    partial void OnP_SizeChanging(System.Nullable<int> value);
    partial void OnP_SizeChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    #endregion
	
	public Photo()
	{
		this._Photo_Category = default(EntityRef<Photo_Category>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descript", DbType="VarChar(100)")]
	public string Descript
	{
		get
		{
			return this._Descript;
		}
		set
		{
			if ((this._Descript != value))
			{
				this.OnDescriptChanging(value);
				this.SendPropertyChanging();
				this._Descript = value;
				this.SendPropertyChanged("Descript");
				this.OnDescriptChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Url", DbType="VarChar(255)")]
	public string Url
	{
		get
		{
			return this._Url;
		}
		set
		{
			if ((this._Url != value))
			{
				this.OnUrlChanging(value);
				this.SendPropertyChanging();
				this._Url = value;
				this.SendPropertyChanged("Url");
				this.OnUrlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> AddDate
	{
		get
		{
			return this._AddDate;
		}
		set
		{
			if ((this._AddDate != value))
			{
				this.OnAddDateChanging(value);
				this.SendPropertyChanging();
				this._AddDate = value;
				this.SendPropertyChanged("AddDate");
				this.OnAddDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Type", DbType="VarChar(20)")]
	public string P_Type
	{
		get
		{
			return this._P_Type;
		}
		set
		{
			if ((this._P_Type != value))
			{
				this.OnP_TypeChanging(value);
				this.SendPropertyChanging();
				this._P_Type = value;
				this.SendPropertyChanged("P_Type");
				this.OnP_TypeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Size", DbType="Int")]
	public System.Nullable<int> P_Size
	{
		get
		{
			return this._P_Size;
		}
		set
		{
			if ((this._P_Size != value))
			{
				this.OnP_SizeChanging(value);
				this.SendPropertyChanging();
				this._P_Size = value;
				this.SendPropertyChanged("P_Size");
				this.OnP_SizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				if (this._Photo_Category.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Photo_Category_Photo", Storage="_Photo_Category", ThisKey="CategoryID", OtherKey="ID", IsForeignKey=true)]
	public Photo_Category Photo_Category
	{
		get
		{
			return this._Photo_Category.Entity;
		}
		set
		{
			Photo_Category previousValue = this._Photo_Category.Entity;
			if (((previousValue != value) 
						|| (this._Photo_Category.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Photo_Category.Entity = null;
					previousValue.Photo.Remove(this);
				}
				this._Photo_Category.Entity = value;
				if ((value != null))
				{
					value.Photo.Add(this);
					this._CategoryID = value.ID;
				}
				else
				{
					this._CategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Photo_Category");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Photo_Category")]
public partial class Photo_Category : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _C_Name;
	
	private string _C_Status;
	
	private EntitySet<Photo> _Photo;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnC_NameChanging(string value);
    partial void OnC_NameChanged();
    partial void OnC_StatusChanging(string value);
    partial void OnC_StatusChanged();
    #endregion
	
	public Photo_Category()
	{
		this._Photo = new EntitySet<Photo>(new Action<Photo>(this.attach_Photo), new Action<Photo>(this.detach_Photo));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Name", DbType="VarChar(50)")]
	public string C_Name
	{
		get
		{
			return this._C_Name;
		}
		set
		{
			if ((this._C_Name != value))
			{
				this.OnC_NameChanging(value);
				this.SendPropertyChanging();
				this._C_Name = value;
				this.SendPropertyChanged("C_Name");
				this.OnC_NameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Status", DbType="VarChar(50)")]
	public string C_Status
	{
		get
		{
			return this._C_Status;
		}
		set
		{
			if ((this._C_Status != value))
			{
				this.OnC_StatusChanging(value);
				this.SendPropertyChanging();
				this._C_Status = value;
				this.SendPropertyChanged("C_Status");
				this.OnC_StatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Photo_Category_Photo", Storage="_Photo", ThisKey="ID", OtherKey="CategoryID")]
	public EntitySet<Photo> Photo
	{
		get
		{
			return this._Photo;
		}
		set
		{
			this._Photo.Assign(value);
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
	
	private void attach_Photo(Photo entity)
	{
		this.SendPropertyChanging();
		entity.Photo_Category = this;
	}
	
	private void detach_Photo(Photo entity)
	{
		this.SendPropertyChanging();
		entity.Photo_Category = null;
	}
}
#pragma warning restore 1591
