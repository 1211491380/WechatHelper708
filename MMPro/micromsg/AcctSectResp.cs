using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "AcctSectResp")]
	[Serializable]
	public class AcctSectResp : IExtensible
	{
		private string _UserName = "";

		private string _NickName = "";

		private uint _BindUin;

		private string _BindEmail = "";

		private string _BindMobile = "";

		private string _Alias = "";

		private uint _Status;

		private uint _PluginFlag = 0u;

		private uint _RegType = 0u;

		private string _DeviceInfoXml = "";

		private uint _SafeDevice = 0u;

		private string _OfficialUserName = "";

		private string _OfficialNickName = "";

		private uint _PushMailStatus = 0u;

		private string _FSURL = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = false, Name = "UserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "NickName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				this._NickName = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "BindUin", DataFormat = DataFormat.TwosComplement)]
		public uint BindUin
		{
			get
			{
				return this._BindUin;
			}
			set
			{
				this._BindUin = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "BindEmail", DataFormat = DataFormat.Default), DefaultValue("")]
		public string BindEmail
		{
			get
			{
				return this._BindEmail;
			}
			set
			{
				this._BindEmail = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "BindMobile", DataFormat = DataFormat.Default), DefaultValue("")]
		public string BindMobile
		{
			get
			{
				return this._BindMobile;
			}
			set
			{
				this._BindMobile = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "Alias", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Alias
		{
			get
			{
				return this._Alias;
			}
			set
			{
				this._Alias = value;
			}
		}

		[ProtoMember(8, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public uint Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "PluginFlag", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint PluginFlag
		{
			get
			{
				return this._PluginFlag;
			}
			set
			{
				this._PluginFlag = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "RegType", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint RegType
		{
			get
			{
				return this._RegType;
			}
			set
			{
				this._RegType = value;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "DeviceInfoXml", DataFormat = DataFormat.Default), DefaultValue("")]
		public string DeviceInfoXml
		{
			get
			{
				return this._DeviceInfoXml;
			}
			set
			{
				this._DeviceInfoXml = value;
			}
		}

		[ProtoMember(12, IsRequired = false, Name = "SafeDevice", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint SafeDevice
		{
			get
			{
				return this._SafeDevice;
			}
			set
			{
				this._SafeDevice = value;
			}
		}

		[ProtoMember(13, IsRequired = false, Name = "OfficialUserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string OfficialUserName
		{
			get
			{
				return this._OfficialUserName;
			}
			set
			{
				this._OfficialUserName = value;
			}
		}

		[ProtoMember(14, IsRequired = false, Name = "OfficialNickName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string OfficialNickName
		{
			get
			{
				return this._OfficialNickName;
			}
			set
			{
				this._OfficialNickName = value;
			}
		}

		[ProtoMember(15, IsRequired = false, Name = "PushMailStatus", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint PushMailStatus
		{
			get
			{
				return this._PushMailStatus;
			}
			set
			{
				this._PushMailStatus = value;
			}
		}

		[ProtoMember(16, IsRequired = false, Name = "FSURL", DataFormat = DataFormat.Default), DefaultValue("")]
		public string FSURL
		{
			get
			{
				return this._FSURL;
			}
			set
			{
				this._FSURL = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
