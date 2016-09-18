// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.discardEncryption
	/// </summary>
	public partial class TLMessagesDiscardEncryption : TLObject
	{
		public Int32 ChatId { get; set; }

		public TLMessagesDiscardEncryption() { }
		public TLMessagesDiscardEncryption(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesDiscardEncryption; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChatId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xEDD923C5);
			to.Write(ChatId);
			if (cache) WriteToCache(to);
		}
	}
}