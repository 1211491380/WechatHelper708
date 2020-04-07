using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "ScanImageRequest")]
	[Serializable]
	public class ScanImageRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private uint _ClientScanID;

		private SKBuiltinBuffer_t _ImageBuffer;

		private uint _TotalLength;

		private uint _Offset;

		private uint _EndFlag;

		private uint _ImageType;

		private uint _OPCode = 0u;

		private uint _SessionID = 0u;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "ClientScanID", DataFormat = DataFormat.TwosComplement)]
		public uint ClientScanID
		{
			get
			{
				return this._ClientScanID;
			}
			set
			{
				this._ClientScanID = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "ImageBuffer", DataFormat = DataFormat.Default)]
		public SKBuiltinBuffer_t ImageBuffer
		{
			get
			{
				return this._ImageBuffer;
			}
			set
			{
				this._ImageBuffer = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "TotalLength", DataFormat = DataFormat.TwosComplement)]
		public uint TotalLength
		{
			get
			{
				return this._TotalLength;
			}
			set
			{
				this._TotalLength = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "Offset", DataFormat = DataFormat.TwosComplement)]
		public uint Offset
		{
			get
			{
				return this._Offset;
			}
			set
			{
				this._Offset = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "EndFlag", DataFormat = DataFormat.TwosComplement)]
		public uint EndFlag
		{
			get
			{
				return this._EndFlag;
			}
			set
			{
				this._EndFlag = value;
			}
		}

		[ProtoMember(7, IsRequired = true, Name = "ImageType", DataFormat = DataFormat.TwosComplement)]
		public uint ImageType
		{
			get
			{
				return this._ImageType;
			}
			set
			{
				this._ImageType = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "OPCode", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint OPCode
		{
			get
			{
				return this._OPCode;
			}
			set
			{
				this._OPCode = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "SessionID", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				this._SessionID = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
