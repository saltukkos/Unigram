// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageEntityMentionName : TLMessageEntityBase 
	{
		public Int32 UserId { get; set; }

		public TLMessageEntityMentionName() { }
		public TLMessageEntityMentionName(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageEntityMentionName; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
			UserId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x352DCA58);
			to.Write(Offset);
			to.Write(Length);
			to.Write(UserId);
			if (cache) WriteToCache(to);
		}
	}
}