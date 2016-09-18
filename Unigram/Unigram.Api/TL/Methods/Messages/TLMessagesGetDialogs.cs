// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getDialogs
	/// </summary>
	public partial class TLMessagesGetDialogs : TLObject
	{
		public Int32 OffsetDate { get; set; }
		public Int32 OffsetId { get; set; }
		public TLInputPeerBase OffsetPeer { get; set; }
		public Int32 Limit { get; set; }

		public TLMessagesGetDialogs() { }
		public TLMessagesGetDialogs(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesGetDialogs; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			OffsetDate = from.ReadInt32();
			OffsetId = from.ReadInt32();
			OffsetPeer = TLFactory.Read<TLInputPeerBase>(from, cache);
			Limit = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x6B47F94D);
			to.Write(OffsetDate);
			to.Write(OffsetId);
			to.WriteObject(OffsetPeer, cache);
			to.Write(Limit);
			if (cache) WriteToCache(to);
		}
	}
}