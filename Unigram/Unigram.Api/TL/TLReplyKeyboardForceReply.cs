// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLReplyKeyboardForceReply : TLReplyMarkupBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			SingleUse = (1 << 1),
			Selective = (1 << 2),
		}

		public bool IsSingleUse { get { return Flags.HasFlag(Flag.SingleUse); } set { Flags = value ? (Flags | Flag.SingleUse) : (Flags & ~Flag.SingleUse); } }
		public bool IsSelective { get { return Flags.HasFlag(Flag.Selective); } set { Flags = value ? (Flags | Flag.Selective) : (Flags & ~Flag.Selective); } }

		public Flag Flags { get; set; }

		public TLReplyKeyboardForceReply() { }
		public TLReplyKeyboardForceReply(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ReplyKeyboardForceReply; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xF4108AA0);
			to.Write((Int32)Flags);
			if (cache) WriteToCache(to);
		}
	}
}