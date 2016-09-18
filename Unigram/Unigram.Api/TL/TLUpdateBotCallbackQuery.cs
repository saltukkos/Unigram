// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotCallbackQuery : TLUpdateBase 
	{
		public Int32 MsgId { get; set; }

		public TLUpdateBotCallbackQuery() { }
		public TLUpdateBotCallbackQuery(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateBotCallbackQuery; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			QueryId = from.ReadInt64();
			UserId = from.ReadInt32();
			Peer = TLFactory.Read<TLPeerBase>(from, cache);
			MsgId = from.ReadInt32();
			Data = from.ReadByteArray();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xA68C688C);
			to.Write(QueryId);
			to.Write(UserId);
			to.WriteObject(Peer, cache);
			to.Write(MsgId);
			to.WriteByteArray(Data);
			if (cache) WriteToCache(to);
		}
	}
}