// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEncryptedChatTyping : TLUpdateBase 
	{

		public TLUpdateEncryptedChatTyping() { }
		public TLUpdateEncryptedChatTyping(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateEncryptedChatTyping; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChatId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x1710F156);
			to.Write(ChatId);
			if (cache) WriteToCache(to);
		}
	}
}