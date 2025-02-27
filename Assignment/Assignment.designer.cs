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

namespace Assignment
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DuAnMau_QLBH")]
	public partial class AssignmentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHang(Hang instance);
    partial void UpdateHang(Hang instance);
    partial void DeleteHang(Hang instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public AssignmentDataContext() : 
				base(global::Assignment.Properties.Settings.Default.DuAnMau_QLBHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AssignmentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssignmentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssignmentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssignmentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hang> Hangs
		{
			get
			{
				return this.GetTable<Hang>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hang")]
	public partial class Hang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdHang;
		
		private string _TenHang;
		
		private int _SoLuong;
		
		private double _DonGiaNhap;
		
		private double _DonGiaBan;
		
		private string _HinhAnh;
		
		private string _GhiChu;
		
		private string _MaNhanVien;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdHangChanging(int value);
    partial void OnIdHangChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaNhapChanging(double value);
    partial void OnDonGiaNhapChanged();
    partial void OnDonGiaBanChanging(double value);
    partial void OnDonGiaBanChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    #endregion
		
		public Hang()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdHang
		{
			get
			{
				return this._IdHang;
			}
			set
			{
				if ((this._IdHang != value))
				{
					this.OnIdHangChanging(value);
					this.SendPropertyChanging();
					this._IdHang = value;
					this.SendPropertyChanged("IdHang");
					this.OnIdHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaNhap", DbType="Float NOT NULL")]
		public double DonGiaNhap
		{
			get
			{
				return this._DonGiaNhap;
			}
			set
			{
				if ((this._DonGiaNhap != value))
				{
					this.OnDonGiaNhapChanging(value);
					this.SendPropertyChanging();
					this._DonGiaNhap = value;
					this.SendPropertyChanged("DonGiaNhap");
					this.OnDonGiaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaBan", DbType="Float NOT NULL")]
		public double DonGiaBan
		{
			get
			{
				return this._DonGiaBan;
			}
			set
			{
				if ((this._DonGiaBan != value))
				{
					this.OnDonGiaBanChanging(value);
					this.SendPropertyChanging();
					this._DonGiaBan = value;
					this.SendPropertyChanged("DonGiaBan");
					this.OnDonGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(400) NOT NULL", CanBeNull=false)]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_Hang", Storage="_NhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.Hangs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.Hangs.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DienThoai;
		
		private string _TenKhachHang;
		
		private string _DiaChi;
		
		private string _GioiTinh;
		
		private string _MaNhanVien;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    #endregion
		
		public KhachHang()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_KhachHang", Storage="_NhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.KhachHangs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.KhachHangs.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNhanVien;
		
		private string _MaNhanVien;
		
		private string _Email;
		
		private string _TenNhanVien;
		
		private string _DiaChi;
		
		private byte _VaiTro;
		
		private byte _TinhTrang;
		
		private string _MatKhau;
		
		private EntitySet<Hang> _Hangs;
		
		private EntitySet<KhachHang> _KhachHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNhanVienChanging(int value);
    partial void OnIdNhanVienChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTenNhanVienChanging(string value);
    partial void OnTenNhanVienChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnVaiTroChanging(byte value);
    partial void OnVaiTroChanged();
    partial void OnTinhTrangChanging(byte value);
    partial void OnTinhTrangChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public NhanVien()
		{
			this._Hangs = new EntitySet<Hang>(new Action<Hang>(this.attach_Hangs), new Action<Hang>(this.detach_Hangs));
			this._KhachHangs = new EntitySet<KhachHang>(new Action<KhachHang>(this.attach_KhachHangs), new Action<KhachHang>(this.detach_KhachHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNhanVien", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int IdNhanVien
		{
			get
			{
				return this._IdNhanVien;
			}
			set
			{
				if ((this._IdNhanVien != value))
				{
					this.OnIdNhanVienChanging(value);
					this.SendPropertyChanging();
					this._IdNhanVien = value;
					this.SendPropertyChanged("IdNhanVien");
					this.OnIdNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhanVien", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNhanVien
		{
			get
			{
				return this._TenNhanVien;
			}
			set
			{
				if ((this._TenNhanVien != value))
				{
					this.OnTenNhanVienChanging(value);
					this.SendPropertyChanging();
					this._TenNhanVien = value;
					this.SendPropertyChanged("TenNhanVien");
					this.OnTenNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VaiTro", DbType="TinyInt NOT NULL")]
		public byte VaiTro
		{
			get
			{
				return this._VaiTro;
			}
			set
			{
				if ((this._VaiTro != value))
				{
					this.OnVaiTroChanging(value);
					this.SendPropertyChanging();
					this._VaiTro = value;
					this.SendPropertyChanged("VaiTro");
					this.OnVaiTroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="TinyInt NOT NULL")]
		public byte TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_Hang", Storage="_Hangs", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<Hang> Hangs
		{
			get
			{
				return this._Hangs;
			}
			set
			{
				this._Hangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_KhachHang", Storage="_KhachHangs", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<KhachHang> KhachHangs
		{
			get
			{
				return this._KhachHangs;
			}
			set
			{
				this._KhachHangs.Assign(value);
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
		
		private void attach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
		
		private void attach_KhachHangs(KhachHang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_KhachHangs(KhachHang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
}
#pragma warning restore 1591
