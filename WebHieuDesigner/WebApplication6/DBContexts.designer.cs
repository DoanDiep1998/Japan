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

namespace WebApplication6
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HieuDesigner")]
	public partial class DBContextsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertBaner(Baner instance);
    partial void UpdateBaner(Baner instance);
    partial void DeleteBaner(Baner instance);
    partial void InsertBaoGia(BaoGia instance);
    partial void UpdateBaoGia(BaoGia instance);
    partial void DeleteBaoGia(BaoGia instance);
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    partial void InsertDanhMucCon(DanhMucCon instance);
    partial void UpdateDanhMucCon(DanhMucCon instance);
    partial void DeleteDanhMucCon(DanhMucCon instance);
    #endregion
		
		public DBContextsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HieuDesignerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Baner> Baners
		{
			get
			{
				return this.GetTable<Baner>();
			}
		}
		
		public System.Data.Linq.Table<BaoGia> BaoGias
		{
			get
			{
				return this.GetTable<BaoGia>();
			}
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<DanhMucCon> DanhMucCons
		{
			get
			{
				return this.GetTable<DanhMucCon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Tile;
		
		private string _Contents;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private string _Images;
		
		private System.Nullable<int> _ID_DanhMucCon;
		
		private EntitySet<Baner> _Baners;
		
		private EntitySet<BaoGia> _BaoGias;
		
		private EntityRef<DanhMucCon> _DanhMucCon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTileChanging(string value);
    partial void OnTileChanged();
    partial void OnContentsChanging(string value);
    partial void OnContentsChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    partial void OnID_DanhMucConChanging(System.Nullable<int> value);
    partial void OnID_DanhMucConChanged();
    #endregion
		
		public Item()
		{
			this._Baners = new EntitySet<Baner>(new Action<Baner>(this.attach_Baners), new Action<Baner>(this.detach_Baners));
			this._BaoGias = new EntitySet<BaoGia>(new Action<BaoGia>(this.attach_BaoGias), new Action<BaoGia>(this.detach_BaoGias));
			this._DanhMucCon = default(EntityRef<DanhMucCon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tile", DbType="NVarChar(500)")]
		public string Tile
		{
			get
			{
				return this._Tile;
			}
			set
			{
				if ((this._Tile != value))
				{
					this.OnTileChanging(value);
					this.SendPropertyChanging();
					this._Tile = value;
					this.SendPropertyChanged("Tile");
					this.OnTileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contents", DbType="NVarChar(MAX)")]
		public string Contents
		{
			get
			{
				return this._Contents;
			}
			set
			{
				if ((this._Contents != value))
				{
					this.OnContentsChanging(value);
					this.SendPropertyChanging();
					this._Contents = value;
					this.SendPropertyChanged("Contents");
					this.OnContentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(MAX)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_DanhMucCon", DbType="Int")]
		public System.Nullable<int> ID_DanhMucCon
		{
			get
			{
				return this._ID_DanhMucCon;
			}
			set
			{
				if ((this._ID_DanhMucCon != value))
				{
					if (this._DanhMucCon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_DanhMucConChanging(value);
					this.SendPropertyChanging();
					this._ID_DanhMucCon = value;
					this.SendPropertyChanged("ID_DanhMucCon");
					this.OnID_DanhMucConChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Baner", Storage="_Baners", ThisKey="Id", OtherKey="id_Item")]
		public EntitySet<Baner> Baners
		{
			get
			{
				return this._Baners;
			}
			set
			{
				this._Baners.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_BaoGia", Storage="_BaoGias", ThisKey="Id", OtherKey="itemID")]
		public EntitySet<BaoGia> BaoGias
		{
			get
			{
				return this._BaoGias;
			}
			set
			{
				this._BaoGias.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMucCon_Item", Storage="_DanhMucCon", ThisKey="ID_DanhMucCon", OtherKey="Id", IsForeignKey=true)]
		public DanhMucCon DanhMucCon
		{
			get
			{
				return this._DanhMucCon.Entity;
			}
			set
			{
				DanhMucCon previousValue = this._DanhMucCon.Entity;
				if (((previousValue != value) 
							|| (this._DanhMucCon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMucCon.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._DanhMucCon.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._ID_DanhMucCon = value.Id;
					}
					else
					{
						this._ID_DanhMucCon = default(Nullable<int>);
					}
					this.SendPropertyChanged("DanhMucCon");
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
		
		private void attach_Baners(Baner entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_Baners(Baner entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
		
		private void attach_BaoGias(BaoGia entity)
		{
			this.SendPropertyChanging();
			entity.Item = this;
		}
		
		private void detach_BaoGias(BaoGia entity)
		{
			this.SendPropertyChanging();
			entity.Item = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admins")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserName;
		
		private string _Pass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(30)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(30)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Baner")]
	public partial class Baner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _Images;
		
		private System.Nullable<int> _location;
		
		private System.Nullable<int> _id_Item;
		
		private EntityRef<Item> _Item;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    partial void OnlocationChanging(System.Nullable<int> value);
    partial void OnlocationChanged();
    partial void Onid_ItemChanging(System.Nullable<int> value);
    partial void Onid_ItemChanged();
    #endregion
		
		public Baner()
		{
			this._Item = default(EntityRef<Item>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(500)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(MAX)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location", DbType="Int")]
		public System.Nullable<int> location
		{
			get
			{
				return this._location;
			}
			set
			{
				if ((this._location != value))
				{
					this.OnlocationChanging(value);
					this.SendPropertyChanging();
					this._location = value;
					this.SendPropertyChanged("location");
					this.OnlocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Item", DbType="Int")]
		public System.Nullable<int> id_Item
		{
			get
			{
				return this._id_Item;
			}
			set
			{
				if ((this._id_Item != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_ItemChanging(value);
					this.SendPropertyChanging();
					this._id_Item = value;
					this.SendPropertyChanged("id_Item");
					this.Onid_ItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_Baner", Storage="_Item", ThisKey="id_Item", OtherKey="Id", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.Baners.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.Baners.Add(this);
						this._id_Item = value.Id;
					}
					else
					{
						this._id_Item = default(Nullable<int>);
					}
					this.SendPropertyChanged("Item");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BaoGia")]
	public partial class BaoGia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _HotenKH;
		
		private string _Email;
		
		private string _SoDienThoai;
		
		private string _Images;
		
		private System.Nullable<int> _itemID;
		
		private EntityRef<Item> _Item;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnHotenKHChanging(string value);
    partial void OnHotenKHChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    partial void OnitemIDChanging(System.Nullable<int> value);
    partial void OnitemIDChanged();
    #endregion
		
		public BaoGia()
		{
			this._Item = default(EntityRef<Item>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotenKH", DbType="NVarChar(500)")]
		public string HotenKH
		{
			get
			{
				return this._HotenKH;
			}
			set
			{
				if ((this._HotenKH != value))
				{
					this.OnHotenKHChanging(value);
					this.SendPropertyChanging();
					this._HotenKH = value;
					this.SendPropertyChanged("HotenKH");
					this.OnHotenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(MAX)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(MAX)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemID", DbType="Int")]
		public System.Nullable<int> itemID
		{
			get
			{
				return this._itemID;
			}
			set
			{
				if ((this._itemID != value))
				{
					if (this._Item.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnitemIDChanging(value);
					this.SendPropertyChanging();
					this._itemID = value;
					this.SendPropertyChanged("itemID");
					this.OnitemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Item_BaoGia", Storage="_Item", ThisKey="itemID", OtherKey="Id", IsForeignKey=true)]
		public Item Item
		{
			get
			{
				return this._Item.Entity;
			}
			set
			{
				Item previousValue = this._Item.Entity;
				if (((previousValue != value) 
							|| (this._Item.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Item.Entity = null;
						previousValue.BaoGias.Remove(this);
					}
					this._Item.Entity = value;
					if ((value != null))
					{
						value.BaoGias.Add(this);
						this._itemID = value.Id;
					}
					else
					{
						this._itemID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Item");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Content;
		
		private string _Img;
		
		private EntitySet<DanhMucCon> _DanhMucCons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnImgChanging(string value);
    partial void OnImgChanged();
    #endregion
		
		public DanhMuc()
		{
			this._DanhMucCons = new EntitySet<DanhMucCon>(new Action<DanhMucCon>(this.attach_DanhMucCons), new Action<DanhMucCon>(this.detach_DanhMucCons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(500)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(500)")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Img", DbType="NVarChar(500)")]
		public string Img
		{
			get
			{
				return this._Img;
			}
			set
			{
				if ((this._Img != value))
				{
					this.OnImgChanging(value);
					this.SendPropertyChanging();
					this._Img = value;
					this.SendPropertyChanged("Img");
					this.OnImgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_DanhMucCon", Storage="_DanhMucCons", ThisKey="Id", OtherKey="ID_DanhMucCha")]
		public EntitySet<DanhMucCon> DanhMucCons
		{
			get
			{
				return this._DanhMucCons;
			}
			set
			{
				this._DanhMucCons.Assign(value);
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
		
		private void attach_DanhMucCons(DanhMucCon entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_DanhMucCons(DanhMucCon entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMucCon")]
	public partial class DanhMucCon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _ID_DanhMucCha;
		
		private EntitySet<Item> _Items;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnID_DanhMucChaChanging(System.Nullable<int> value);
    partial void OnID_DanhMucChaChanged();
    #endregion
		
		public DanhMucCon()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			this._DanhMuc = default(EntityRef<DanhMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(500)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_DanhMucCha", DbType="Int")]
		public System.Nullable<int> ID_DanhMucCha
		{
			get
			{
				return this._ID_DanhMucCha;
			}
			set
			{
				if ((this._ID_DanhMucCha != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_DanhMucChaChanging(value);
					this.SendPropertyChanging();
					this._ID_DanhMucCha = value;
					this.SendPropertyChanged("ID_DanhMucCha");
					this.OnID_DanhMucChaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMucCon_Item", Storage="_Items", ThisKey="Id", OtherKey="ID_DanhMucCon")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_DanhMucCon", Storage="_DanhMuc", ThisKey="ID_DanhMucCha", OtherKey="Id", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.DanhMucCons.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.DanhMucCons.Add(this);
						this._ID_DanhMucCha = value.Id;
					}
					else
					{
						this._ID_DanhMucCha = default(Nullable<int>);
					}
					this.SendPropertyChanged("DanhMuc");
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
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.DanhMucCon = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.DanhMucCon = null;
		}
	}
}
#pragma warning restore 1591
