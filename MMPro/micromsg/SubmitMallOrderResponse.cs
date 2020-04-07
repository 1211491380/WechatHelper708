using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "SubmitMallOrderResponse")]
	[Serializable]
	public class SubmitMallOrderResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private string _PrepareId = "";

		private int _RetCode = 0;

		private string _RetMsg = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "PrepareId", DataFormat = DataFormat.Default), DefaultValue("")]
		public string PrepareId
		{
			get
			{
				return this._PrepareId;
			}
			set
			{
				this._PrepareId = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "RetCode", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int RetCode
		{
			get
			{
				return this._RetCode;
			}
			set
			{
				this._RetCode = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "RetMsg", DataFormat = DataFormat.Default), DefaultValue("")]
		public string RetMsg
		{
			get
			{
				return this._RetMsg;
			}
			set
			{
				this._RetMsg = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
