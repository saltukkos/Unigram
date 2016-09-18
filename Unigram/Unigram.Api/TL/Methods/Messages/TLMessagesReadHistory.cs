// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.readHistory
	/// </summary>
	public partial class TLMessagesReadHistory : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 MaxId { get; set; }

		public TLMessagesReadHistory() { }
		public TLMessagesReadHistory(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesReadHistory; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from, cache);
			MaxId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE306D3A);
			to.WriteObject(Peer, cache);
			to.Write(MaxId);
			if (cache) WriteToCache(to);
		}
	}
}