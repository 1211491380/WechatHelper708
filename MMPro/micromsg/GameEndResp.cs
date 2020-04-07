using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GameEndResp")]
	[Serializable]
	public class GameEndResp : IExtensible
	{
		private BaseResponse _BaseResponse;

		private uint _Score;

		private string _Achievement = "";

		private uint _Rank;

		private uint _LifeNum;

		private uint _CheckLeftTime;

		private int _Count;

		private readonly List<UserGameAchieveInfo> _RankList = new List<UserGameAchieveInfo>();

		private string _PropsViewTip = "";

		private string _RankViewTip = "";

		private uint _GameCoinCount = 0u;

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

		[ProtoMember(2, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public uint Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				this._Score = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "Achievement", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Achievement
		{
			get
			{
				return this._Achievement;
			}
			set
			{
				this._Achievement = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public uint Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "LifeNum", DataFormat = DataFormat.TwosComplement)]
		public uint LifeNum
		{
			get
			{
				return this._LifeNum;
			}
			set
			{
				this._LifeNum = value;
			}
		}

		[ProtoMember(6, IsRequired = true, Name = "CheckLeftTime", DataFormat = DataFormat.TwosComplement)]
		public uint CheckLeftTime
		{
			get
			{
				return this._CheckLeftTime;
			}
			set
			{
				this._CheckLeftTime = value;
			}
		}

		[ProtoMember(7, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
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

		[ProtoMember(8, Name = "RankList", DataFormat = DataFormat.Default)]
		public List<UserGameAchieveInfo> RankList
		{
			get
			{
				return this._RankList;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "PropsViewTip", DataFormat = DataFormat.Default), DefaultValue("")]
		public string PropsViewTip
		{
			get
			{
				return this._PropsViewTip;
			}
			set
			{
				this._PropsViewTip = value;
			}
		}

		[ProtoMember(12, IsRequired = false, Name = "RankViewTip", DataFormat = DataFormat.Default), DefaultValue("")]
		public string RankViewTip
		{
			get
			{
				return this._RankViewTip;
			}
			set
			{
				this._RankViewTip = value;
			}
		}

		[ProtoMember(13, IsRequired = false, Name = "GameCoinCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint GameCoinCount
		{
			get
			{
				return this._GameCoinCount;
			}
			set
			{
				this._GameCoinCount = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
