using ProtoBuf;
using System;

namespace micromsg
{
	[ProtoContract(Name = "GetBrandListRequestBuffer")]
	[Serializable]
	public class GetBrandListRequestBuffer : IExtensible
	{
		private uint _Count;

		private uint _HiddenCount;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public uint Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				this._Count = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "HiddenCount", DataFormat = DataFormat.TwosComplement)]
		public uint HiddenCount
		{
			get
			{
				return this._HiddenCount;
			}
			set
			{
				this._HiddenCount = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
